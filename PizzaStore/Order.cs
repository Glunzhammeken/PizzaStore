using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    internal class Order
    {

        #region Instance fields
        private double _tax;
        private double _delivery;
       
        private Pizza _pizza;
        private Customer _customer;
        #endregion

        #region Constructor

        public Order()
        {
            _pizza = new Pizza();
            _customer = new Customer();
            _tax = 0.25;
            _delivery = 40;
        

        }
        #endregion

        #region Properties

        public double Tax
        {  get { return _tax; } set {  _tax = value; } }

        public double Delivery
        { get { return _delivery; } set { _delivery = value; } }

        public Pizza Pizza
        { get { return _pizza; }  set { _pizza = value; } }

        public Customer Customer { get { return _customer; } set { _customer = value; } }

        
        #endregion

        #region Methods

        
         
        public double CalculateTotalPrice()
        {

            return Pizza.Price + (Pizza.Price * Tax) + Delivery;

        }

        public override string ToString()
        {
            return $"{Customer.ToString()} {Pizza.ToString()} Total Price : {CalculateTotalPrice()}  ";
        }
        #endregion

    }
}
