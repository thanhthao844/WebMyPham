
//using MessagePack;
//using System.ComponentModel.DataAnnotations;
//using WebMyPham_DOANPM.Repository.Validation;
//using System.ComponentModel.DataAnnotations.Schema;
namespace WebMyPham_DOANPM.Models

{
    public class ProductVariant
    {
        public int ProductVariantId { get; set; }
        public int ProductId { get; set; }
        public string Size { get; set; } // Dung tích


        public decimal Price { get; set; } // Giá tiền

        public virtual ProductModel Product { get; set; }
    }
}
