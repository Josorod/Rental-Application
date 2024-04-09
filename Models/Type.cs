using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalBuildingApplication.Models
{
    [Table("RoomType")]
    public class Type
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public double  Coef { get; set; }
    }
}
