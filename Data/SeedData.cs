using lab4.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Lab4COM3773.Data
{
    public static class SeedData
    {
        // this is an extension method to the ModelBuilder class
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                GetCities()
            );
            modelBuilder.Entity<Province>().HasData(
                GetProvinces()
            );
        }

        private static List<City> GetCities()
        {
            var cities = new List<City>
            {
                new City()
                {
                    CityId =1,
                    CityName = "Vancouver",
                    Population = 675218,
                    ProvinceCode = "BC"
                },
                new City()
                {
                    CityId = 2,
                    CityName = "Richmond",
                    Population = 218307,
                    ProvinceCode = "BC"
                },
                new City()
                {
                    CityId = 3,
                    CityName = "Burnaby",
                    Population = 233700,
                    ProvinceCode = "BC"
                },
                new City()
                {
                    CityId = 4,
                    CityName = "Calgary",
                    Population = 1392609,
                    ProvinceCode = "AB"
                },
                new City()
                {
                    CityId = 5,
                    CityName = "Edmonton",
                    Population = 1429743,
                    ProvinceCode = "AB"
                },
                new City()
                {
                    CityId = 6,
                    CityName = "Athabasca",
                    Population = 2965,
                    ProvinceCode = "AB"
                },
                new City()
                {
                    CityId = 7,
                    CityName = "Whitehorse",
                    Population = 24000,
                    ProvinceCode = "YT"
                },
                new City()
                {
                    CityId = 8,
                    CityName = "Dawson City",
                    Population = 1410,
                    ProvinceCode = "YT"
                },
                new City()
                {
                    CityId = 9,
                    CityName = "Faro",
                    Population = 344,
                    ProvinceCode = "YT"
                }

            };
            return cities;
        }

        private static List<Province> GetProvinces()
        {
            var provinces = new List<Province>()
            {
                new Province()
                {
                    ProvinceCode = "BC",
                    ProvinceName = "British Columbia",
                },
                
                new Province()
                {
                    ProvinceCode = "AB",
                    ProvinceName = "Alberta",
                },

                new Province()
                {
                    ProvinceCode = "YT",
                    ProvinceName = "Yukon",
                }

            };
            return provinces;
        }

    }
}
