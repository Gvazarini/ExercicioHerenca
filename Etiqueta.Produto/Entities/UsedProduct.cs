using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EtiquetaProduto.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }
        public UsedProduct() 
        { 
        }
        public UsedProduct(string name, double price, DateTime manufacturedDate) : base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }
        public override string PriceTag()
        {
            return Name + "(used), " + Price.ToString("F2", CultureInfo.InvariantCulture)  + (" Manufactured Date: (" + ManufacturedDate.ToString("dd/MM/yyy")+ ")");
        }
    }
}
