using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApplication4
{
    public class Model
    {
        public List<Phone> Phones { get; set; }

        public Model()
        {
            Phones = new List<Phone>
            {
                new Phone
                {
                    Name = "Samsung Galaxy3",
                    Price = 14000,
                    BatteryCapacity = 1500,
                    Memory = 64,
                    Weight = 300,
                    CoolFactor = 3,
                    ReleaseDate = DateTime.Now.AddYears(-1),
                    IsSpecialized = false
                },

                new Phone
                {
                    Name = "Nokia 3564",
                    Price = 6000,
                    BatteryCapacity = 2000,
                    Memory = 16,
                    Weight = 150,
                    CoolFactor = 1,
                    ReleaseDate = DateTime.Now.AddYears(-10),
                    IsSpecialized = false
                },

                new Phone
                {
                    Name = "Raik 2000",
                    Price = 8000,
                    BatteryCapacity = 3000,
                    Memory = 16,
                    Weight = 350,
                    CoolFactor = 1,
                    ReleaseDate = DateTime.Now.AddYears(-6),
                    IsSpecialized = true
                },

                new Phone
                {
                    Name = "IPhone SE",
                    Price = 40000,
                    BatteryCapacity = 3000,
                    Memory = 64,
                    Weight = 200,
                    CoolFactor = 5,
                    ReleaseDate = DateTime.Now,
                    IsSpecialized = false
                },

                new Phone
                {
                    Name = "IPhone 12",
                    Price = 70000,
                    BatteryCapacity = 3000,
                    Memory = 64,
                    Weight = 210,
                    CoolFactor = 5,
                    ReleaseDate = DateTime.Now,
                    IsSpecialized = false
                },

                new Phone
                {
                    Name = "IPhone 11",
                    Price = 80000,
                    BatteryCapacity = 3000,
                    Memory =256,
                    Weight = 200,
                    CoolFactor = 5,
                    ReleaseDate = DateTime.Now,
                    IsSpecialized = false
                }
            };
        }
    }

    public class Phone
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int BatteryCapacity { get; set; }
        public int Memory { get; set; }
        public int Weight { get; set; }
        public int CoolFactor { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool IsSpecialized { get; set; }
    }
}
