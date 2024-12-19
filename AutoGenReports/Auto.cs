using FluentScheduler;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGenReports
{
    public class Auto : IJob
    {

        public async void Execute()
        {
            Models.singsiamdbContext db = new Models.singsiamdbContext();
            #region Auto Report 
            try
            {

                var all_branch = db.Branches.AsNoTracking().ToList();
                foreach (var branch in all_branch) 
                {
                    await TimeBaseChecker.ReportsSignSiam.Report1(branch.Id);
                }
               
                Console.WriteLine("Update autoReport1 is completed " + DateTime.Now);
            }
            catch (Exception ex) { Console.WriteLine("Update autoReport1 is error " + ex, ToString()); }

            try
            {

                var all_branch = db.Branches.AsNoTracking().ToList();
                foreach (var branch in all_branch)
                {
                    await TimeBaseChecker.ReportsSignSiam.Report6(branch.Id);
                }

                Console.WriteLine("Update autoReport6 is completed " + DateTime.Now);
            }
            catch (Exception ex) { Console.WriteLine("Update autoReport6 is error " + ex, ToString()); }

            #endregion
        }

    }
}
