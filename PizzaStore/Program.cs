using System.Security.Cryptography.X509Certificates;

namespace PizzaStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Store store = new Store(); 
            store.start();
            
        }
    }
}
