using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Customer
    {
        #region Instance fields

        private string _name;
        private string _TLFNummer;
        private Adresse _adresse;
        #endregion

        #region Constructor

        public Customer() 
        {

            _name = "";
            _TLFNummer = "";
            _adresse = new Adresse();
        }
        #endregion

        #region Properties
        public string   Name
        { 
            get { return _name; } 
        set { _name = value; }
        }

        public string TLFNummer
        { 
            get { return _TLFNummer; }
            set { _TLFNummer = value; }
            
        }
        public Adresse Adresse
        { get { return _adresse; } set { _adresse = value; } }
       
        





        #endregion

        #region Methods

        public override string ToString() { return $"Name: {Name} - TLFNummer:  {TLFNummer}"; }
        #endregion

        
    }
}
