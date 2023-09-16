using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Address
    {
        private string _city;

        /// <summary>
        /// Method calls the method to set the city field for the address instance
        /// </summary>
        public Address( string city )
        {
            SetCity( city );
        }

        /// <summary>
        /// Method sets the city field for the address instance
        /// </summary>
        public void SetCity(string city)
        {
            _city = city;
        }

        /// <summary>
        /// Method returns the value of city field for the address object
        /// </summary>
        public string GetCity()
        {
            return _city;
        }
    }
}
