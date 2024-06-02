using WeCare.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WeCare.Models.Repositories
{
    public interface IMedicalFileRepository
    {
        IEnumerable<MedicalFile> GetAllProducts();
        void UpdateProductStocks(int productId, int quantityToRemove);
        void SaveProduct(MedicalFile product);
        void DeleteProduct(int id);
        Task<MedicalFile> GetProduct(int id);
        Task<IList<MedicalFile>> GetProduct();
    }
}
