using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Model
{
    public class Exercice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public Image Image { get; set; }

        //public List<Muscle> PrimaryTargetedMuscle { get; set; }
        //public List<Muscle> OtherTargetedMuscle { get; set; }
    }
}
