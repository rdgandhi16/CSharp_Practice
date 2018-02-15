using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcexam.Models
{
    public class product
    {
        public int pid { get; set; }
        public int catid { get; set; }

        public string pname { get; set; }
        public string pcategory { get; set; }
        public int pprice { get; set; }
        public string pdetails { get; set; }
        public string pimage { get; set; }
    }
}