using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    /// <summary>
    ///  int? cho phep null
    /// </summary>
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        public string URL { set; get; }

        [Required]
        public int GroupID { set; get; }

        [Required]
        public bool Status { set; get; }

        public int? DisplayOrder { set; get; }
        public string Target { set; get; }

        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { set; get; }
    }
}