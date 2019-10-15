using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace noviflowgo.Pages.Employees
{
    public class employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int EID { get; set; }
        public string FN { get; set; }
        public string LN { get; set; }
        public string Role { get; set; }
        public string status { get; set; }
    }
}
