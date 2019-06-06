using System;
using System.Collections.Generic;

namespace KatoLefebvre_Assignment2.BusinessClasses
{
    /// <summary>
    /// Dealership class.
    /// </summary>
    public class Dealership
    {
        private string _name, _address, _email;
        private int _businessNumber, _phone;
        private List<Car> _carList;

        /// <summary>
        /// Public constructor that creates an instance of Dealership and the CarList.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="email"></param>
        /// <param name="businessNumber"></param>
        /// <param name="phone"></param>
        public Dealership(string name, string address, string email, int businessNumber, int phone)
        {
            Name = name;
            Address = address;
            Email = email;
            BusinessNumber = businessNumber;
            Phone = phone;
            CarList = new List<Car>();
        }

        /// <summary>
        /// Public getter and setter for the property _name.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!value.Equals(null))
                    _name = value;
                else
                    throw new Exception("ERROR: NAME CANNOT BE NULL");
            }
        }

        /// <summary>
        /// Public getter and setter for the property _address.
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                if (!value.Equals(null))
                    _address = value;
                else
                    throw new Exception("ERROR: ADDRESS CANNOT BE NULL");
            }
        }

        /// <summary>
        /// Public getter and setter for the property _email.
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (!value.Equals(null))
                    _email = value;
                else
                    throw new Exception("ERROR: NAME CANNOT BE NULL");
            }
        }

        /// <summary>
        /// Public getter and setter for the property _businessNumber.
        /// </summary>
        public int BusinessNumber
        {
            get
            {
                return _businessNumber;
            }
            set
            {
                if (value > 0)
                    _businessNumber = value;
                else
                    throw new Exception("ERROR: NAME CANNOT BE NULL");
            }
        }

        /// <summary>
        /// Public getter and setter for the property _phone.
        /// </summary>
        public int Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                if (value > 999999999)
                    _phone = value;
                else
                    throw new Exception("ERROR: NAME CANNOT BE NULL");
            }
        }

        /// <summary>
        /// Public getter and setter for the List _carList.
        /// </summary>
        public List<Car> CarList
        {
            get
            {
                return _carList;
            }
            set
            {
                if (value != null)
                    _carList = value;
            }
        }

        /* I decided to separate the two methods for adding either a new car or an old car to the list because of the constructors and 
         * the properties required. An OldCar requires a DepreciationRecord whereas a NewCar doesn't. A DepreciationRecord would be 
         * required as a parameter for a single method, but I don't want to create one if the Car is New. */

        /// <summary>
        /// Method to add a NewCar to the CarList.
        /// </summary>
        /// <param name="licensePlateNo"></param>
        /// <param name="carMake"></param>
        /// <param name="purchasePrice"></param>
        /// <param name="type"></param>
        public void AddNewCar(string licensePlateNo, string carMake, float purchasePrice, CarType type)
        {
            Car car = new NewCar(licensePlateNo, carMake, purchasePrice, type);
            CarList.Add(car);
        }

        /// <summary>
        /// Method to add an OldCar to the CarList.
        /// </summary>
        /// <param name="licensePlateNo"></param>
        /// <param name="carMake"></param>
        /// <param name="purchasePrice"></param>
        /// <param name="type"></param>
        /// <param name="record"></param>
        public void AddOldCar(string licensePlateNo, string carMake, float purchasePrice, CarType type, DepreciationRecord record)
        {
            Car car = new OldCar(licensePlateNo, carMake, purchasePrice, type, record);
            CarList.Add(car);
        }
    }
}