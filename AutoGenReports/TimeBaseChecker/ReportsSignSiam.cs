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
        public static async Task Report1(int Month,int branch_id)
        {
            Models.singsiamdbContext db = new Models.singsiamdbContext();
          
            List<int> num = new List<int> { 2, 4 };
            var list_transaction_history = db.TransactionHistories.AsNoTracking().Include(s => s.Branch).Include(s => s.Receiopttran).ThenInclude(s => s.Receiptdescs).Include(s=>s.Subject).Where(s=>s.CreateAt.Month ==  Month && num.Contains(s.PaymentMethod) && s.BranchId == branch_id).OrderBy(s=>s.Subject.SubjectType).ToList();
         //   var subject_code_income = db.SubjectCosts.AsNoTracking().Where(s => s.SubjectType == 1).Select(s=>s.SubjectId).ToList();
            if (list_transaction_history.Count != 0)
            {
                var json_head3 = new jsonModel
                {
                    transaction_date = DateTime.Now,
                    branch_id = branch_id,
                    branch_name = list_transaction_history.FirstOrDefault().Branch.BranchName,
                    report_type = 1,
                    transaction_date_format = list_transaction_history.FirstOrDefault().CreateAt.ToString("yyyy-MM"),
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


        public class report1_income_outcome_transferonly //report4//20200227
        {
            public int rowNumber { get; set; }
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
        public class jsonModel
        {
            public int branch_id { get; set; }
            public string branch_name { get; set; }
            public int report_type { get; set; }
            public DateTime transaction_date { get; set; }
            public string transaction_date_format { get; set; }

            public List<report1_income_outcome_transferonly> report1_Income_Outcome_s { get; set; }
        
        }

    }
}
