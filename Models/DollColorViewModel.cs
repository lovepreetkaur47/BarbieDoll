using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace BarbieDoll.Models
{
    public class DollColorViewModel
    {
        public List<Doll> Dolls { get; set; }
        public SelectList Color{ get; set; }
        public string DollColor { get; set; }
        public string SearchString { get; set; }
    }
}
