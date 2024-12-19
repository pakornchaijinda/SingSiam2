using AutoGenReports.Models;
using FluentScheduler;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGenReports.TimeBaseChecker
{
    public static class ReportsSignSiam
    {
        public static async Task autoReport1()
        {
            Models.singsiamdbContext db = new Models.singsiamdbContext();

        }
        public static async Task Report1(int branch_id)
        {
            Models.singsiamdbContext db = new Models.singsiamdbContext();

            if (db.Reports.AsNoTracking().Any(a => (a.ReportType == 1 ) && a.BranchId == branch_id && a.TransactionDate == DateTime.Now.Date.ToString()))
            {
                return;
            }

            var transaction_date = DateTime.Now.Date;
            List<int> num = new List<int> { 2, 4 };
            var list_transaction_history = db.TransactionHistories.AsNoTracking().Include(s => s.Branch).Include(s => s.Receiopttran).ThenInclude(s => s.Receiptdescs).Include(s=>s.Subject).Where(s=>s.CreateAt.Date ==  transaction_date && num.Contains(s.PaymentMethod) && s.BranchId == branch_id).OrderBy(s=>s.Subject.SubjectType).ToList();
       
            if (list_transaction_history.Count != 0)
            {
                var json_head3 = new jsonModel
                {
                    transaction_date = DateTime.Now,
                    branch_id = branch_id,
                    branch_name = list_transaction_history.FirstOrDefault().Branch.BranchName,
                    report_type = 1,
                    transaction_date_format = list_transaction_history.FirstOrDefault().CreateAt.ToString("yyyy-MM-dd"),
                    report1_Income_Outcome_s = new List<report1_income_outcome_transferonly>()
                };
                int i = 1;
                foreach (var items in list_transaction_history)
                {
                    Receipttran receipttran = new Receipttran();
                    string paymenttypename = "";
                    string receipt_desc = "";
                    int? peroid_s = 0;
                    int? peroid_e = 0;
                    int? total_peroid = 0;
                    bool ck_vat = false;
                    try
                    {
                        if (items.ReceiopttranId != null)
                        {
                            receipttran = db.Receipttrans.AsNoTracking().Include(s => s.Receiptdescs).ThenInclude(s => s.Periodtran).Include(s=>s.Promise).Where(s => s.Id == items.ReceiopttranId).FirstOrDefault();

                            if (receipttran.Receiptdesc == "รับฝากเงินล่วงหน้า")
                            {
                                receipt_desc = "รับฝากเงินล่วงหน้า";
                            }
                            peroid_s = receipttran.Receiptdescs.FirstOrDefault().Period;
                            if (receipttran.Receiptdescs.Count > 1)
                            {
                                peroid_e = receipttran.Receiptdescs.LastOrDefault().Period;
                            }
                            total_peroid = receipttran.Promise.Periods;
                            if (receipttran.Promise.Ptype == 1)
                            {
                                ck_vat = true;
                            }
                            else
                            {
                                ck_vat = false;
                            }
                            if (receipttran.PaidBy == 4)
                            {

                                if (receipttran.Cashpaid == 1)
                                {
                                    paymenttypename = "เงินสด";
                                }
                                else if (receipttran.Transferpaid == 1)
                                {
                                    paymenttypename = "เงินโอน";
                                }
                                else
                                {
                                    paymenttypename = "ชำระอื่นๆ";
                                }
                            }
                            else
                            {
                                if (receipttran.Cashpaid == 1)
                                {
                                    paymenttypename = "เงินสด";
                                }
                                else if (receipttran.Transferpaid == 1)
                                {
                                    paymenttypename = "เงินโอน";
                                }
                                else
                                {
                                    paymenttypename = "ชำระอื่นๆ";
                                }
                            }
                        }
                     

                        report1_income_outcome_transferonly json_report1 = new report1_income_outcome_transferonly();
                        json_report1.rowNumber = i;
                        json_report1.detail = items.Subject.SubjectName;

                        if (items.SubjectId == 31)
                        {
                            if (receipt_desc != "")
                            {
                                json_report1.detail_desc = receipt_desc;
                            }
                            else
                            {
                                if (peroid_e != 0)
                                {
                                    json_report1.detail_desc = peroid_s.ToString() + "-" + peroid_e.ToString() + "/" + total_peroid;
                                }
                                else
                                {
                                    json_report1.detail_desc = peroid_s.ToString() + "/" + total_peroid;
                                }
                            }
                            json_report1.payment_type = paymenttypename;
                            json_report1.vat = ck_vat;
                            json_report1.receiptno = receipttran.Receiptno;
                            if (receipt_desc != "")
                            {
                                json_report1.amount = (decimal)items.Price;
                            }
                            else 
                            {

                                json_report1.amount = (decimal)receipttran.Receiptdescs.Sum(s=>s.Amount) *-1;
                                json_report1.amount_charge = (decimal)receipttran.Receiptdescs.Sum(s => s.Chargeamt);
                            }

                           
                            json_report1.income = (decimal)receipttran.Amount;
                        }
                        else if (items.SubjectId == 21)
                        {
                            json_report1.detail_desc = items.Detial;
                            json_report1.amount = items.Price;
                            
                        }
                        else if (items.SubjectId == 7)
                        {
                            json_report1.detail_desc = items.Detial;
                            json_report1.amount = items.Price;
                            json_report1.income = items.Price;
                            json_report1.receiptno = receipttran.Receiptno;
                        }
                        else
                        {

                            if (items.SubjectId == 4)
                            {
                                json_report1.detail_desc = items.Detial;
                                json_report1.expenses = items.Price;
                            }
                            else 
                            {
                                json_report1.expenses = items.Price;
                            }
                        }
                        json_report1.transaction_data = items.CreateAt.Date;
                       
                        i++;
                        json_head3.report1_Income_Outcome_s.Add(json_report1);
                    }
                    catch (Exception ex)
                    {

                    }
                }
                string json_data = Newtonsoft.Json.JsonConvert.SerializeObject(json_head3);
                Models.Report toAdd = new Report 
                {
                    BranchId = json_head3.branch_id,
                    ReportType = json_head3.report_type,
                    JsonData = json_data,
                    CreatedAt = json_head3.transaction_date,
                    TransactionDate = json_head3.transaction_date_format,
                };
                db.Reports.Add(toAdd);
                await db.SaveChangesAsync();
            }
            else 
            {
            
            }
          
        }
        public static async Task Report6(int branch_id) 
        {
            var transaction_date = DateTime.Now.Date;
            Models.singsiamdbContext db = new Models.singsiamdbContext();
            if (db.Reports.AsNoTracking().Any(a => (a.ReportType == 6) && a.BranchId == branch_id && a.TransactionDate == DateTime.Now.Date.ToString()))
            {
                return;
            }
            List<int> subject_id_cost = new List<int> { 11, 12, 13, 14, 15, 16, 17 };

            var list_transaction_history = db.TransactionHistories.AsNoTracking().Include(s => s.Branch).Include(s => s.Receiopttran).ThenInclude(s => s.Receiptdescs).Include(s => s.Subject).Where(s => s.CreateAt.Date ==transaction_date  && subject_id_cost.Contains(s.SubjectId) && s.BranchId == branch_id).OrderBy(s => s.Subject.SubjectType).ToList();

            if (list_transaction_history.Count != 0)
            {
                var json_head6 = new jsonModel6
                {
                    transaction_date = DateTime.Now.Date,
                    branch_id = branch_id,
                    branch_name = list_transaction_history.FirstOrDefault().Branch.BranchName,
                    report_type = 6,
                    transaction_date_format = list_transaction_history.FirstOrDefault().CreateAt.ToString("yyyy-MM-dd"),
                    report6_Summary_Expenses = new List<report6_summary_expenses>()
                };
                int i = 1;
                foreach (var items in list_transaction_history)
                {
                    report6_summary_expenses data = new report6_summary_expenses();
                    data.rowNumber = i;
                    data.detail = items.Subject.SubjectName;
                    data.expenses_amount = items.Price;
                    i++;
                    json_head6.report6_Summary_Expenses.Add(data);
                }
                string json_data = Newtonsoft.Json.JsonConvert.SerializeObject(json_head6);
                Models.Report toAdd = new Report
                {
                    BranchId = json_head6.branch_id,
                    ReportType = json_head6.report_type,
                    JsonData = json_data,
                    CreatedAt = json_head6.transaction_date,
                    TransactionDate = json_head6.transaction_date_format,
                };
                db.Reports.Add(toAdd);
                await db.SaveChangesAsync();
            }
            else { }

            }

        public class report1_income_outcome_transferonly 
        {
            public int rowNumber { get; set; }

            public DateTime transaction_data { get; set; }  
            public string detail { get; set; }
            public string detail_desc { get; set; }
            public string payment_type { get; set; }
           
            public bool vat { get; set; }
            public string receiptno { get; set; }
            public decimal amount { get; set; }
            public decimal amount_charge { get; set; }
            public decimal income { get; set; }
            public decimal expenses { get; set; }
            public decimal remain { get; set; }
        }
        public class report6_summary_expenses 
        {
            public int rowNumber { get; set; }
            public string detail { get; set; }
            public string detail_desc { get; set; }
            public decimal expenses_amount { get; set; }

        }
        public class report3_summary_of_month
        {
         
            public string transactiondate { get; set; }
            public decimal amount_vat { get; set; }
            public decimal amount_charge_vat { get; set; }
            public decimal total_vat { get; set; }

            public decimal amount_novat { get; set; }
            public decimal amount_charge_novat { get; set; }
            public decimal total_novat { get; set; }

            public decimal total_sum_amount { get; set; }
            public decimal total_accumulate { get; set; }

            public decimal total_promise { get; set; }
            public decimal total_accumulate_promise { get; set; }
           



            public decimal expenses_amount { get; set; }

        }
        public class jsonModel
        {
            public int branch_id { get; set; }
            public string branch_name { get; set; }
            public int report_type { get; set; }
            public DateTime transaction_date { get; set; }
            public string transaction_date_format { get; set; }

            public List<report1_income_outcome_transferonly> report1_Income_Outcome_s { get; set; }

        }
        public class jsonModel3
        {
            public int branch_id { get; set; }
            public string branch_name { get; set; }
            public int report_type { get; set; }
            public DateTime transaction_date { get; set; }
            public string transaction_date_format { get; set; }
            public List<report3_summary_of_month> report3_Summary_Of_Months { get; set; }

        }
        public class jsonModel6
        {
            public int branch_id { get; set; }
            public string branch_name { get; set; }
            public int report_type { get; set; }
            public DateTime transaction_date { get; set; }
            public string transaction_date_format { get; set; }

            public List<report6_summary_expenses> report6_Summary_Expenses { get; set; }

        }

      



    }
}
