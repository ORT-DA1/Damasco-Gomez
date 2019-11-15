using ParkingBusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF
{
    public class ServicePurchase
    {
        private DataAccess dataAccess;
        public ServicePurchase()
        {

        }
        public List<Purchase> GetSaleByLicensePlate(string licensePlate)
        {
            List<Purchase> purchases = new List<Purchase>();
            return purchases;

        }
    
        public List<Purchase> GetSaleByCountryAndPeriod(string fecha, int horaIni, int horaFin, string pais)
        {
            List<Purchase> purchases = new List<Purchase>();
            return purchases;

        }
        public Purchase GetPurchaseById(Guid id)
        {
            Purchase purchase = new PurchaseUruguay();
            return purchase;

        }
        public Purchase GetPurchaseByDate(string fecha)
        {
            Purchase purchase = new PurchaseUruguay();
            return purchase;

        }
    }
}
