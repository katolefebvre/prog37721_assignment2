using System;
using System.Collections.Generic;

namespace KatoLefebvre_Assignment2.BusinessClasses
{
    /// <summary>
    /// Abstract class for Car.
    /// </summary>
    public abstract class Car
    {
        private string _licensePlateNo, _carMake;
        private float _purchasePrice;
        private CarType _type;

        /// <summary>
        /// Public constructor that creates an instance of Car.
        /// </summary>
        /// <param name="licensePlateNo"></param>
        /// <param name="carMake"></param>
        /// <param name="purchasePrice"></param>
        /// <param name="type"></param>
        public Car(string licensePlateNo, string carMake, float purchasePrice, CarType type)
        {
            LicensePlateNo = licensePlateNo;
            PurchasePrice = purchasePrice;
            CarMake = carMake;
            Type = type;
        }

        /// <summary>
        /// Public getter and setter for the property _licensePlateNo.
        /// </summary>
        public string LicensePlateNo
        {
            get
            {
                return _licensePlateNo;
            }
            set
            {
                if (!value.Equals(null))
                    _licensePlateNo = value;
                else
                    throw new Exception("ERROR: LICENSE PLATE NO CANNOT BE NULL");
            }
        }

        /// <summary>
        /// Public getter and setter for the property _carMake.
        /// </summary>
        public string CarMake
        {
            get
            {
                return _carMake;
            }
            set
            {
                if (!value.Equals(null))
                    _carMake = value;
                else
                    throw new Exception("ERROR: CAR MAKE CANNOT BE NULL");
            }
        }

        /// <summary>
        /// Public getter and setter for the property _purchasePrice.
        /// </summary>
        public float PurchasePrice
        {
            get
            {
                return _purchasePrice;
            }
            set
            {
                if (value > 0)
                    _purchasePrice = value;
                else
                    throw new Exception("ERROR: PURCHASE PRICE CANNOT BE 0 OR LESS")
            }
        }

        /// <summary>
        /// Public getter and setter for the property _type.
        /// </summary>
        public CarType Type
        {
            get
            {
                return _type;
            }
            set
            {
                if (!value.Equals(null))
                    _type = value;
                else
                    throw new Exception("ERROR: CAR TYPE CANNOT BE NULL");
            }
        }
    }
}