using System.ComponentModel.DataAnnotations;

namespace WebMyPham_DOANPM.Models
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }
        [Required,MinLength(4,ErrorMessage = "Yêu cầu nhập tên danh mục")]
        
        public string Name { get; set; }
        [Required]
        
        public string Description { get; set; }       
        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập mô tả danh mục")]
        
    
        
        public int Status { get; set; }
    }
}
