using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace noviflowgo.Pages.Audit
{
    public class audits
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AID { get; set; }
        public string Auditdate{ get; set; }
    public string RLocation { get; set; }
    public string RRole { get; set; }
    // foreign key
    public int DID { get; set; }

}
}
