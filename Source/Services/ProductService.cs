using Source.Models;

namespace Source.Services {
    public class ProductService : List<ProductModel> {
        public ProductService() {
            AddRange([
                new ProductModel { Id = 1, Name = "Apple IPhone X Pro Max", Price = 5000},
                new ProductModel { Id = 2, Name = "Samsung Galaxy Z Fold 6", Price = 5500},
                new ProductModel { Id = 3, Name = "Nokia Lumia 1080", Price = 3000},
                new ProductModel { Id = 4, Name = "Oppo Reno12", Price = 2000},
            ]);
        }
    }
}
