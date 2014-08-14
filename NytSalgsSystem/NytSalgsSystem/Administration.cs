using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NytSalgsSystem
{
    class Administration
    {
        public Administration()
        {
            ProductList = new List<Product>();
        } 

        private List<Product> ProductList;

        //tilføj 1 stk. af den givne vare til lageret.
        public void Add(Product item) {
            ProductList.Add(item);
        }

        //tilføj det givne antal af den givne vare til lageret.
        public void Add(Product item, int amount) {
            for (int i = 0; i < amount; i++ )
                ProductList.Add(item);
        }
        
        //fjern 1 stk. af den givne vare fra lageret.
        public bool Remove(Product item) {
            if (ProductList.Exists(x => x.Name == item.Name))
            {
                ProductList.Remove(item);
                return true;
            }
            else
                return false;
                
        }

        //fjern det givne antal af den givne vare fra lageret.
        public bool Remove(Product item, int amount)
        {
            int count = 0;

            foreach (Product p in ProductList)
            {
                if (p.Name == item.Name)
                    count++;
            }

            if (count != amount)
                return false;

            foreach (Product p in ProductList)
            {
                if (p.Name == item.Name)
                    ProductList.Remove(p);
            }

            return true;

        }
    }
}
