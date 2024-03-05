using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    internal class Adresse
    {
        #region Instance fields
        private string _city;
        private string _postnr;
        private string _street;
        private string _streetnumber;
        #endregion


        #region Constructor
        public Adresse()
        {
            _city = "";
            _postnr = "";
            _street = "";
            _streetnumber = "";


        }


        #endregion

        #region Properties

        public string City

        { get { return _city; } set { _city = value; } }

        public string Postnr

        { get { return _postnr; } set { _postnr = value; } }
        public string Street

        { get { return _street; } set { _street = value; } }
        public string Streetnumber

        {
            get { return _streetnumber; } 
            set { _streetnumber = value; } 
        
        }


        #endregion

        #region Methods
        public override string ToString() { return $"City: {City} - Postnr:  {Postnr} - Street:  {Street} -  Streetnumber {Streetnumber}" ; }

        #endregion

    }
}
