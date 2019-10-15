using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace noviflowgo.Pages.Departments
{
    public class departments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DID { get; set; }
        public string Head { get; set; }
        public string Location { get; set; }
        public string Role { get; set; }

    }
}
