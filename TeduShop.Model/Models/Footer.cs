using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Footers")]
    ///tao ra ten bang can gen ra database

    public class Footer
    {
        [Key]//dinh dang day la khoa chinh kieu string nen khong can chi ra la identity
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//dat thuoc tinh tu tang
        public string ID { set; get; }
        [Required]//bat buoc phai nhap
        public string Content { set; get; }
    }
}
