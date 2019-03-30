using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AxelsBud.Models
{
    public class vorur
    {
        public string nafn { get; set; }
        public string mynd { get; set; }
        public string [] lysing { get; set; }
        public string audkenni { get; set; }
        public string verd { get; set; }
        public string [] imgs { get; set; }
        public string [] links { get; set; }
        public bool multipleLinks { get; set; }
    }
}