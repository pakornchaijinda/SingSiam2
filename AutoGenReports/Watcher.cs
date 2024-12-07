using FluentScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGenReports
{
    public class RunAutoJob : Registry
    {
        public RunAutoJob()
        {

            Schedule<Auto>().ToRunNow().AndEvery(1).Hours();
        }
    }
}
