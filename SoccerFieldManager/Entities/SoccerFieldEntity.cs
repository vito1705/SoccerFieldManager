using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerFieldManager.Entities
{
    public class SoccerFieldEntity
    {
        [Key]
        public long Id { get; set; }
        public long IdFatherSoccerField { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
    }
}
