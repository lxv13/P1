using System;

namespace УП_ПП1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Address tom = new Address();
            string addressCity = tom.city;
            string addressStreet = tom.street;
            int addressNumber = tom.number;
            tom.city = "Полоцк";
            tom.street = "Октябрьская";
            tom.number = 57;
            tom.Print();
        }
    }
    class Address
    {
        public string city="Undefined";
        public string street="Undefined";
        public int number=0;

        public void Print()
        {
            Console.WriteLine($"Город: {city}  Улица: {street}   Номер дома: {number}");
        }
    }
}
