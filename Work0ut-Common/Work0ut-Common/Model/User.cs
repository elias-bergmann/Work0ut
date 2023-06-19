using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work0ut.Model
{
    public class User
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Goal { get; set; } = string.Empty;

        public Program? CurrentProgram { get; set; }
    }
}
