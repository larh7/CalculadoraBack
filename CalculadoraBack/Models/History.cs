using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraBack.Models
{
    public class History
    {
        public int Id { get; set; }
        public int number1 { get; set; }
        public int number2 { get; set; }
        public string operation { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
    }
}
