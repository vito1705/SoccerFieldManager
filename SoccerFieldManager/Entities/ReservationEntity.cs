using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerFieldManager.Entities
{
    public class ReservationEntity
    {
        [Key]
        public long Id { get; set; }

        public long Id_Client { get; set; }

        public long Id_SoccerField { get; set; }

        public DateTime DateReservation { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }

        public long Price { get; set; }

    }
}
