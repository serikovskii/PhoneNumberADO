using System.Collections.Generic;
using System.Data.Entity;

namespace PhoneNumber
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<PhoneAppContext>
    {
        protected override void Seed(PhoneAppContext context)
        {
            List<City> cities;

            cities = new List<City>
            {
                new City
                {
                    Name = "Астана",
                    Code = 7172
                },
                new City
                {
                    Name = "Тараз",
                    Code = 7262
                },
                new City
                {
                    Name ="Павлодар",
                    Code = 7182
                },
                new City
                {
                    Name = "Кызылдорда",
                    Code = 7242
                },
                new City
                {
                    Name = "Шымкент",
                    Code = 7252
                }
            };

            context.Cities.AddRange(cities);
            base.Seed(context);
        }
    }
}