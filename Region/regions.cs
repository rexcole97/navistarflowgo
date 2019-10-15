using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace noviflowgo.Pages.Region
{
    public class regions
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RID { get; set; }
        public int DID { get; set; }



        public string RLocation { get; set; }
        public string RRole { get; set; }



    }
}
