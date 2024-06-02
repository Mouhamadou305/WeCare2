using Microsoft.EntityFrameworkCore;
using WeCare.Data;
using WeCare.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeCare.Models.Repositories
{
    public class MedicalFileRepository : IMedicalFileRepository
    {
        private static EhodBDD _context;

        public MedicalFileRepository(EhodBDD context)
        {
                _context = context;
        }
        public async Task<MedicalFile> GetProduct(int id)
        {
            var product = await _context.Product.SingleOrDefaultAsync(m => m.Id == id);
            return product;
        }

        public async Task<IList<MedicalFile>> GetProduct()
        {
            var products = await _context.Product.ToListAsync();
            return products;
        }
        /// <summary>
        /// Get all products from the inventory
        /// </summary>
        public IEnumerable<MedicalFile> GetAllProducts()
        {
            IEnumerable<MedicalFile> productEntities= _context.Product.Where(p => p.Id > 0);
            return productEntities.ToList();
        }

        /// <summary>
        /// Update the stock of a product by its id
        /// </summary>
        public void UpdateProductStocks(int id, int quantityToRemove)
        {
            MedicalFile product = _context.Product.First(p => p.Id == id);
            product.Quantity = product.Quantity - quantityToRemove;

            if (product.Quantity == 0)
                _context.Product.Remove(product);
            else
            {
                _context.Product.Update(product);
                _context.SaveChanges();
            }   
        }

        public void SaveProduct(MedicalFile product)
        {
            if (product != null)
            {
               

                _context.Product.Add(product);
                _context.SaveChanges();
            }
        }

  

        public void DeleteProduct(int id)
        {
            MedicalFile product = _context.Product.First(p => p.Id == id);
            if (product != null)
            {
                _context.Product.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
