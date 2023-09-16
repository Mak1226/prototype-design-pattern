using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Person : IPrototype
    {
        private string? _name;

        public Address? Address { get; set; }

        /// <summary>
        /// Method sets the name field of the instance
        /// </summary>
        public void SetName(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Method returns the name field of the instance
        /// </summary>
        public string GetName()
        {
            return _name;
        }

        /// <summary>
        /// Method makes clone of the instance, i.e., Shallow Copy
        /// </summary>
        public Person ShallowCopy()
        {
            return (Person)MemberwiseClone();
        }

        /// <summary>
        /// Method makes clone of the instance, i.e., Deep Copy
        /// </summary>
        public Person DeepCopy()
        {
            Person clone = (Person)MemberwiseClone();

            Address address = new(Address.GetCity());

            clone.Address = address;
            return clone;
        }

        /// <summary>
        /// Method returns the value of data fields of instance
        /// </summary>
        public override string ToString()
        {
            return $"Hi, I'm {_name} and I live in {Address?.GetCity()}";
        }

        public Person? shallowCopy()
        {
            throw new NotImplementedException();
        }

        public Person? deepCopy()
        {
            throw new NotImplementedException();
        }
    }
}
