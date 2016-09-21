using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECORP.Classes;

namespace ECORP.RepositoryInterfaces
{
    interface IMagazijnRepository
    {
        List<Product> GetAllProducts();

        void AddProduct(Product p);

        void DeleteProduct(Product p);

        void UpdateProduct(Product p);

        Product GetProductById(int id);
    }
}
