using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    public class Address
    {
        private string street;
        private int houseNumber;
        private string postalCode;
        private string city;

        public Country Country
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}