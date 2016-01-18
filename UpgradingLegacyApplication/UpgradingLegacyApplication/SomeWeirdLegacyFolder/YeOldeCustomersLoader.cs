using System.Collections.Generic;
using System.Linq;
using UpgradingLegacyApplication.Api.Models;

namespace UpgradingLegacyApplication.Api.SomeWeirdLegacyFolder
{
    public class YeOldeCustomersLoader
    {
        public static IEnumerable<CustomerModel> LoadAllCustomers()
        {
            return new List<CustomerModel>
            {
                new CustomerModel() {Id = 1, Name = "Adlibris"}
                , new CustomerModel() {Id = 2, Name = "Bamba"}
                , new CustomerModel() {Id = 3, Name = "Discshop"}
                , new CustomerModel() {Id = 4, Name = "Köketsfavoriter"}
            };
        }

        public static CustomerModel LoadCustomer(int withId)
        {
            return LoadAllCustomers().Single(p => p.Id == withId);
        }

    }
}