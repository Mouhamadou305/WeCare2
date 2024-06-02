using System.Collections.Generic;
using System.Threading.Tasks;
using EhodBoutiqueEnLigne.Models.Entities;
using EhodBoutiqueEnLigne.Models.ViewModels;

namespace EhodBoutiqueEnLigne.Models.Services
{
    public interface IProductService
    {
        List<MedicalFile> GetAllProducts();
        List<ProductViewModel> GetAllProductsViewModel();
        MedicalFile GetProductById(int id);
        ProductViewModel GetProductByIdViewModel(int id);
        void UpdateProductQuantities();
        void SaveProduct(ProductViewModel product);
        void DeleteProduct(int id);
        List<string> CheckProductModelErrors(ProductViewModel product);
        Task<MedicalFile> GetProduct(int id);
        Task<IList<MedicalFile>> GetProduct();
    }
}
