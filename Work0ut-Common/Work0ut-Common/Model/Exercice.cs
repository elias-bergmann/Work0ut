using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work0ut.Model
{
    public partial class Exercice
    {
        public string? Id { get; set; }
        public List<Set> Sets { get; set; } = new List<Set>();
        public string Comment { get; set; } = string.Empty;

    }
}
