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
            var list_transaction_history = db.TransactionHistories.AsNoTracking().Include(s => s.Branch).Include(s => s.Receiopttran).ThenInclude(s => s.Receiptdesc).Include(s=>s.Subject).Where(s=>s.CreateAt.Month ==  Month && num.Contains(s.PaymentMethod) && s.BranchId == branch_id).ToList();
          
            var json_head3 = new jsonModel
            {
                transaction_date = DateTime.Now,
                branch_name = list_transaction_history.FirstOrDefault().Branch.BranchName,
                report_type = "1",
                report1_Income_Outcome_s = new List<report1_income_outcome_transferonly>()
            };
            int i = 1;
            foreach (var items in list_transaction_history) 
            {
                Receipttran receipttran = new Receipttran();
                string paymenttypename = "";
                try 
                {
                    if (items.ReceiopttranId != null)
                    {
                        receipttran = db.Receipttrans.AsNoTracking().Include(s => s.Receiptdescs).ThenInclude(s => s.Periodtran).Where(s => s.Id == items.ReceiopttranId).FirstOrDefault();
                      
                    }
                  
                    var json_report1 = new report1_income_outcome_transferonly
                    {
                       
                        rowNumber = i,
                        detail_desc = items.Receiopttran.Receiptdesc,
                    
                        detail = items.Subject.SubjectName + " : ",

                        
                    };
                    i++;
                    json_head3.report1_Income_Outcome_s.Add(json_report1);
                }
                catch (Exception ex)
                {
                
                }
            }
        }


        public class report1_income_outcome_transferonly //report4//20200227
        {
            public int rowNumber { get; set; }
            public string detail { get; set; }
            public string detail_desc { get; set; }
            public string payment_type { get; set; }
            public string ptomise_peroid { get; set; }
            public bool vat { get; set; }
            public string receiptno { get; set; }
            public string amount { get; set; }
            public string amount_charge { get; set; }
            public string income { get; set; }
            public string expenses { get; set; }
            public string remain { get; set; }
        }
        public class jsonModel
        {
            public string branch_name { get; set; }
            public string report_type { get; set; }
            public DateTime transaction_date { get; set; }
           
            public List<report1_income_outcome_transferonly> report1_Income_Outcome_s { get; set; }
        
        }

    }
}
