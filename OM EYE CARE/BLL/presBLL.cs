using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM_EYE_CARE.BLL
{
    class presBLL
    {
        public int pre_id { get; set; }
        public int cust_id { get; set; }
        
        public string R_sph { get; set; }
        public string R_cyl { get; set; }
        public string R_axis { get; set; }
        public string R_vd { get; set; }
        public string R_Nadd { get; set; }
        public string R_vn { get; set; }
        public string L_sph { get; set; }
        public string L_cyl { get; set; }
        public string L_axis { get; set; }
        public string L_vd { get; set; }
        public string L_Nadd { get; set; }
        public string L_vn { get; set; }
        public string Leans_Type { get; set; }
        public string Leans_Side { get; set; }
        public string Leans_Price { get; set; }
        public string Frame_Type { get; set; }
        public string Frame_Price { get; set; }
        public string Paid_amt { get; set; }
        public string Total_amt { get; set; }
        public string Pending_amt { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
    }
}
