using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_EXAM.Models
{
    public class pclass
    {
        public int catid { get; set; }
        public string catname { get; set; }
        
        public int pid { get; set; }
        public int cid { get; set; }

        public string pname { get; set; }
        public int  pcategory { get; set; }
        public int pprice { get; set; }
        public string pdetail { get; set; }
        public string pimage { get; set; }
    }
}