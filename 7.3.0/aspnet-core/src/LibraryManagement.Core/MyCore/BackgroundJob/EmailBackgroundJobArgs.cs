using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.MyCore.BackgroundJob
{
    public class EmailBackgroundJobArgs
    {
        public List<string> TargetEmails { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
