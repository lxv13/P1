using System;

namespace УП_ПП1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string addressCity = "Полоцк"; string addressStreet = "Октябрьская"; int addressNumber = 57;
            Address tom = new Address( addressCity,  addressStreet,  addressNumber); 
            addressCity = tom.city;
            addressStreet = tom.street;
            addressNumber = tom.number;
            tom.Print();
        }
    }
    class Address
    {
        public string city="Undefined";
        public string street="Undefined";
        public int number=0;
        public Address(string c, string s, int n) { city = c; street = s; number = n; }

        public void Print()
        {
            Console.WriteLine($"Город: {city}  Улица: {street}   Номер дома: {number}");
        }
    }
}
