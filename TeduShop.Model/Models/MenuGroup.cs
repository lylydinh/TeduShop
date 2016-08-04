using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//dat thuoc tinh tu tang
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        public virtual IEnumerable<Menu> Menus { set; get; }//chi ra khoa ngaoi va lay ra danh sach cac menu
    }
}