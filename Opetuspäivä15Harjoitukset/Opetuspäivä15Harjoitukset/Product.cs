using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspäivä15Harjoitukset
{
    class Product
    {
        // Id on uniikki luku, joka alkaa numerosta 1 ja kasvaa aina yhdellä
        // uuttaa dataa tallentaessa.
        private static Random rng = new Random();
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name)
        {
            // "Haetaan" tietokannasta data
            Id = rng.Next();
            Name = name;
            Price = Convert.ToDecimal(rng.NextDouble() * 100);
        }


    }
}
