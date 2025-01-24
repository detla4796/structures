using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure
{
    internal class ResidentTask
    {
        public struct Address
        {
            public string Street;
            public int House;
            public int Apartment;
        }
        public struct Resident
        {
            public string LastName;
            public Address Address;
            public string City;
        }
        public static void Run()
        {
            Resident[] residents = GenerateResidents(100);
            for (int i = 0; i < residents.Length; i++)
            {
                for (int j = 0; j < residents.Length; j++)
                {
                    if (residents[i].Address.Street == residents[j].Address.Street && residents[i].Address.House == residents[j].Address.House && residents[i].Address.Apartment == residents[j].Address.Apartment && i != j)
                    {
                        Console.WriteLine($"First resident: {residents[i].LastName}, City: {residents[i].City}");
                        Console.WriteLine($"Second resident: {residents[j].LastName}, City: {residents[j].City}");
                        Console.WriteLine($"Address: {residents[i].Address.Street} {residents[i].Address.House} {residents[i].Address.Apartment}");
                        return;
                    }
                }
            }
            Console.WriteLine("No matches found");
        }
        public static Resident[] GenerateResidents(int count)
        {
            Resident[] residents = new Resident[count];
            Random random = new Random();
            string[] lastNames = { "Petrov", "Ivanov", "Sidorov", "Smirnov", "Kuznetsov", "Popov", "Vasiliev", "Pavlov", "Semenov", "Golubev" };
            string[] streets = { "Lenina", "Pushkina", "Gagarina", "Mira", "Sovetskaya", "Oktyabrskaya", "Tsentralnaya", "Shkolnaya", "Novaya", "Sadovaya" };
            string[] cities = { "Moscow", "Saint Petersburg", "Novosibirsk", "Yekaterinburg", "Nizhny Novgorod", "Kazan", "Chelyabinsk", "Omsk", "Samara", "Rostov-on-Don" };
            for (int i = 0; i < count; i++)
            {
                residents[i] = new Resident
                {
                    LastName = lastNames[random.Next(lastNames.Length)],
                    City = cities[random.Next(cities.Length)],
                    Address = new Address
                    {
                        Street = streets[random.Next(streets.Length)],
                        House = random.Next(1, 20),
                        Apartment = random.Next(1, 15)
                    }
                };
            }
            return residents;
        }
    }
}
