using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitution.Solution
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<string> Features { get; set; }
    }

    public abstract class MemberShipBase
    {
        public virtual decimal GetPrice(List<Product> products)
        {
            return products.Sum(p => p.Price);
        }
    }



    public class TraditionalMemberShip : MemberShipBase, IReportSupport
    {

        public Stream GetReport(List<Product> products)
        {
            //Raporlama business'ları
            //Sonuçların PDF haline getirilmesi
            // Kullanıcı ücret ödemiş buna erişmeinde sıkıntı yok,
            return new MemoryStream();
        }
    }

    public class TrialMemberShip : MemberShipBase
    {
        // Geçici kullanıcı için raporu implemente etmedik
    }

    public interface IReportSupport
    {
        Stream GetReport(List<Product> products);
    }

}
