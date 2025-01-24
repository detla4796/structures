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
            string[] lastNames = { "Петров", "Иванов", "Сидоров", "Смирнов", "Кузнецов", "Попов", "Васильев", "Павлов", "Семенов", "Голубев" };
            string[] streets = { "Ленина", "Пушкина", "Гагарина", "Мира", "Советская", "Октябрьская", "Центральная", "Школьная", "Новая", "Садовая" };
            string[] cities = { "Москва", "Санкт-Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казань", "Челябинск", "Омск", "Самара", "Ростов-на-Дону" };
            for (int i = 0; i < count; i++)
            {
                residents[i] = new Resident
                {
                    LastName = lastNames[random.Next(lastNames.Length)],
                    City = cities[random.Next(cities.Length)],
                    Address = new Address
                    {
                        Street = streets[random.Next(streets.Length)],
                        House = random.Next(1, 100),
                        Apartment = random.Next(1, 300)
                    }
                };
            }
            return residents;
        }
    }
}
