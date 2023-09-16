using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prototype;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestSetNameAndGetname()
        {
            /// <summary>
            /// Creating new instance and initializing its name and address
            /// </summary>
            Person person = new();
            person.SetName("John");
            person.Address = new Address("Boston");
            
            /// <summary>
            /// Line1: Checking the name of person instance
            /// Line2: Checking the address of person instance
            /// </summary>
            Assert.AreEqual("John", person.GetName());
            Assert.AreEqual("Boston", person.Address.GetCity());
        }

        [TestMethod]
        public void TestShallowCopy()
        {
            /// <summary>
            /// Creating new instance and initializing its name and address
            /// </summary>
            Person originalPerson = new();
            originalPerson.SetName("Alice");
            originalPerson.Address = new Address("New York");

            /// <summary>
            /// Line1: Creating shallowCopy instance
            /// Line2: Modifying the address in the shallowCopy instance
            /// Line3: Since in shallow-copy the memory is shared, the change in shallowCopy instance will be reflected in originalPerson instance
            /// </summary>
            Person shallowCopy = originalPerson.ShallowCopy();
            shallowCopy.Address.SetCity("Los Angeles"); 

            /// <summary>
            /// Line1: Ensure shallowCopy and originalPerson have same Name
            /// Line2: Checking the name of shallowCopy instance
            /// Line3: Ensure shallowCopy and originalPerson city have same value
            /// Line4: Checking the city of shallowcopy instance
            /// Line5: Ensure shallowCopy and originalPerson have same Address instance
            /// </summary>
            Assert.AreEqual(originalPerson.GetName(), shallowCopy.GetName());
            Assert.AreEqual("Alice",originalPerson.GetName());
            Assert.AreEqual(originalPerson.Address.GetCity(), shallowCopy.Address.GetCity());
            Assert.AreEqual("Los Angeles", originalPerson.Address.GetCity()); 
            Assert.AreEqual(originalPerson.Address, shallowCopy.Address);
        }


        [TestMethod]
        public void TestDeepCopy()
        {
            /// <summary>
            /// Creating new instance and initializing its name and address
            /// </summary>
            Person originalPerson = new();
            originalPerson.SetName("Bob");
            originalPerson.Address = new Address("Los Angeles");

            /// <summary>
            /// Line1: Creating the deepCopy instance
            /// Line2: Modifying the address in the deepCopy instance
            /// Line3: Since in deep-copy the memory not shared, the change in deepCopy instance will not affect originalPerson instance
            /// </summary>
            Person deepCopy = originalPerson.DeepCopy();
            deepCopy.Address.SetCity("Miami");

            /// <summary>
            /// Line1: Ensure deepCopy and originalPerson Name have same values
            /// Line2: Checking the name of deepCopy instance
            /// Line3: Ensure deepCopy and originalPerson city have different values
            /// Line4: Checking the Address of originalPerson instance
            /// Line5: Checking the Address of deepCopy instance
            /// Line6: Ensure deepCopy and originalPerson have different Address instance
            /// </summary>
            Assert.AreEqual(originalPerson.GetName(), deepCopy.GetName());
            Assert.AreEqual("Bob",deepCopy.GetName());
            Assert.AreNotEqual(originalPerson.Address.GetCity(), deepCopy.Address.GetCity());
            Assert.AreEqual("Los Angeles",originalPerson.Address.GetCity());
            Assert.AreEqual("Miami",deepCopy.Address.GetCity());
            Assert.AreNotSame(originalPerson.Address, deepCopy.Address);
        }

        [TestMethod]
        public void TestToString()
        {
            /// <summary>
            /// Creating new instance and initializing its name and address
            /// </summary>
            Person person = new();
            person.SetName("Emily");
            person.Address = new Address("London");

            /// <summary>
            /// Printing the result
            /// </summary>
            string result = person.ToString();

            /// <summary>
            /// Ensuring the result is same
            /// </summary>
            Assert.AreEqual("Hi, I'm Emily and I live in London", result);
        }
    }
}
