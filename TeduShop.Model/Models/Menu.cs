using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//dat thuoc tinh tu tang
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        public string URL { set; get; }

        public int? DisPlayOrder { set; get; }//Cau truc cho phep de trong null able

        [Required]
        public int GroupID { set; get; }

        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { set; get; }//bang nay se cho thang den id cuar bang menugroup

        public string Target { set; get; }

        [Required]//not null
        public bool Status { set; get; }
    }
}