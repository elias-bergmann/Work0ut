using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work0ut.Model
{
    public partial class Exercice
    {
        public string Name { get; set; }
        public string Description { get; set; } 
        public string IconUrl { get; set; }

        //public List<Muscle> PrimaryTargetedMuscle { get; set; }
        //public List<Muscle> OtherTargetedMuscle { get; set; }
    }
}
