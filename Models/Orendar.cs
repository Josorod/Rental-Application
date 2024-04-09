using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalBuildingApplication.Models
{
    [Table("Orendar")]
    public class Orendar
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string YurAdress { get; set; }

        public string BankName { get; set; }
        public string DirecorName { get; set; }
        public string Characteristic { get; set; }
    }
}
