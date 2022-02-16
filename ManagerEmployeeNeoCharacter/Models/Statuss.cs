using System.ComponentModel.DataAnnotations;

namespace ManagerEmployeeNeoCharacter.Models
{
    public class Statuss
    {
        public int StatussID { get; set; }

        [Display(Name = "وضعیت")]
        public bool Status { get; set; }

        [Display(Name = "شماره")]
        public int NumberSend { get; set; }

        [Display(Name = "پیوست")]
        public string Attach { get; set; }

        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
    }
}