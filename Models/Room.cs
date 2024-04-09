using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalBuildingApplication.Models
{
    [Table("Room")]
    public class Room
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public double RoomSquare { get; set; }

        public string TypeName { get; set; }
        public int TypeId { get; set; }
        public string IsAvailable { get; set; }

    }
}
