﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Pizza
    {

        #region Instance fields
        private string _name;
        private int _price;
       
    

        #endregion

        #region Constructor
        public Pizza()
        {
            _name = "";
            _price = 0;
        }


        #endregion

        #region Properties
        public string Name
        {
            get { return _name; } 
            set { _name = value; }  
        }
        
        public int Price
        { 
            get { return _price; }
            set { _price = value; }
        }

        #endregion

        #region Methods

        public override string ToString() { return $"Name: {Name} - Price:  {Price}"; }
        #endregion


        
    }
}
