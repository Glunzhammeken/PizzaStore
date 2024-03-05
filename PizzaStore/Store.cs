using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Store
    {
        
        public void start() 
        {
            {

                Pizza Pizza1 = new Pizza();
                Pizza1.Name = "Calzone";
                Pizza1.Price = 100;


                Pizza Pizza2 = new Pizza();
                Pizza2.Name = "PepMedDress";
                Pizza2.Price = 80;

                Pizza Pizza3 = new Pizza();
                Pizza3.Name = "GriseBomben";
                Pizza3.Price = 110;

                Adresse adressefor1 = new Adresse();
                adressefor1.City = "køge";
                adressefor1.Street = "vestergade";
                adressefor1.Streetnumber = "1";
                adressefor1.Postnr = "4600";

                Adresse adressefor2 = new Adresse();
                adressefor2.City = "søborg";
                adressefor2.Street = "Hurlumhejgade";
                adressefor2.Streetnumber = "3";
                adressefor2.Postnr = "2600";

                Adresse adressefor3 = new Adresse();
                adressefor3.City = "new york";
                adressefor3.Street = "central park";
                adressefor3.Streetnumber = "80";
                adressefor3.Postnr = "7000";

                Customer customer1 = new Customer();
                customer1.Name = "John Dillermand";
                customer1.TLFNummer = "40404040";
                customer1.Adresse = adressefor1;


                Customer customer2 = new Customer();
                customer2.Name = "Bo";
                customer2.TLFNummer = "30303030";
                customer2.Adresse = adressefor2;

                Customer customer3 = new Customer();
                customer3.Name = "Leif";
                customer3.TLFNummer = "20202020";
                customer3.Adresse = adressefor3;

                Order order1 = new Order();
                order1.Pizza = Pizza1;
                order1.Customer = customer1;

                Order order2 = new Order();
                order2.Pizza = Pizza2;
                order2.Customer = customer2;

                Order order3 = new Order();
                order3.Pizza = Pizza3;
                order3.Customer = customer3;


                Console.WriteLine(order1);
                Console.WriteLine(order2);
                Console.WriteLine(order3);
                

            }
        }

    }
}
