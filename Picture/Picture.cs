using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JS.Utils.RazorTemplates.Model
{
    public class Picture
    {
        public List<Source> Sources { get; set; } = new List<Source>();
        public string Alt { get; set; }
        public string Src { get; set; }

    }
}
