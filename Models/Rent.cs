using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalBuildingApplication.Models
{
    [Table("Rent")]
    public class Rent
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int OrendarId { get; set; }
        public string CompanyName { get; set; }
        public string price { get; set; }

        public DateTime datestart { get; set; }
        public DateTime dateEnd { get; set; }
    }
}
