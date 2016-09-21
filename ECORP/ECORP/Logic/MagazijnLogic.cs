using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECORP.Classes;
using ECORP.RepositoryInterfaces;

namespace ECORP.Logic
{
    class MagazijnLogic
    {
        private IMagazijnRepository MagazijnRepo;
        public MagazijnLogic(IMagazijnRepository imr)
        {
            this.MagazijnRepo = imr;
        }

        public List<Product> GetAllProducts()
        {
            return MagazijnRepo.GetAllProducts();
        }

        public void InsertProduct(Product p)
        {
            MagazijnRepo.AddProduct(p);
        }
    }
}
