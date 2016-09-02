using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    /// <summary>
    /// Name :Table:gen code ten table chinh la ten trong ngoac nhon
    /// Key ghi chu truong nay la khoa chinh
    /// required :ghi chú trường này là không thể bỏ trống
    /// </summary>
    [Table("Footers")]
    public class Footer
    {
        [Key]
        public string ID { set; get; }

        [Required]
        public string Content { set; get; }
    }
}