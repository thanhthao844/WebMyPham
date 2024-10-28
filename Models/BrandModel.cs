using System.ComponentModel.DataAnnotations;

namespace WebMyPham_DOANPM.Models
{
    public class BrandModel
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập tên thương hiệu")]

        public string Name { get; set; }
      

        public string Description { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập mô tả thương hiệu")]

      public string Slug { get; set; }

        public int Status { get; set; }
    }
}
