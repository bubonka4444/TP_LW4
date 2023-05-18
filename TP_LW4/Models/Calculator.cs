
using System.ComponentModel.DataAnnotations;

namespace TP_LW4.Models
{
    public class CalculatorModel
    {
        [Required(ErrorMessage = "Please enter a value for Num1.")]
        public double Num1 { get; set; }

        [Range(-100, 100, ErrorMessage = "Please enter a value between -100 and 100 for Num2.")]
        public double Num2 { get; set; }
        public string Operation { get; set; }
    }
}