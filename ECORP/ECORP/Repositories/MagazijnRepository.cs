using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECORP.Classes;
using ECORP.RepositoryInterfaces;

namespace ECORP.Repositories
{
    class MagazijnRepository:IMagazijnRepository

    {
        private Magazijn m = new Magazijn("Magazijn 1", new Address("Minervum", "Breda", "5035", 7232));
        private int id;

        public List<Product> GetAllProducts()
        {
            Product p = new Product("Schroevendraaier", 10, 1123, 10);
            m.Producten.Add(p);
            return m.Producten;
        }

        public void AddProduct(Product p)
        {
            id++;
            p.Id = id;
            m.Producten.Add(p);
        }

        public void DeleteProduct(Product p)
        {
            foreach (Product pr in m.Producten)
            {
                if (p.Id == pr.Id)
                {
                    m.Producten.Remove(p);
                }
            }
        }

        public void AddStock(Product p, int i)
        {
            p.Stock += i;
        }

        public void RemoveStock(Product p, int i)
        {
            p.Stock -= i;
        }


        public void UpdateProduct(Product p)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            Product prd = null;
            foreach (Product pr in m.Producten)
            {
                if (id == pr.Id)
                {
                    prd = pr;
                }
            }
            return prd;
        } 
    }
}
