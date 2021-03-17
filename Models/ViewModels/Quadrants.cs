using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpGenius.Models.ViewModels
{
    public class Quadrants
    {
        public IEnumerable<SignUpItem> QuadrantI { get; set; }
        public IEnumerable<SignUpItem> QuadrantII { get; set; }
        public IEnumerable<SignUpItem> QuadrantIII { get; set; }
        public IEnumerable<SignUpItem> QuadrantIIII { get; set; }

    }
}
