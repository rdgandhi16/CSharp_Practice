using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_ALL_Cntrl_DB.Models
{
    public class admin
    {
        public List<admin> gen { get; set; }
        [Display(Name="Fname")]
        public string fname { get; set; }
        public bool hoby { get; set; }
        public string hb { get; set; }
        public string sub { get; set; }
        public string state { get; set; }


        public int genid { get; set; }
        public string genname { get; set; }  
        
        public int hbid { get; set; }
        public string hbname { get; set; }
    }
}