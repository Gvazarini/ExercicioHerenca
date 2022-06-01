using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EtiquetaProduto.Entities
{
    internal class ImportProduct : Product
    {
        public double CustomsFee { get; set; }
        public ImportProduct()
        {

        }
        public ImportProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
        public override string PriceTag()
        {
            return Name + " $" + Price.ToString("F2", CultureInfo.InvariantCulture) + " Customs Fee: ($" + CustomsFee + ")" + " Total: $" + TotalPrice().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
