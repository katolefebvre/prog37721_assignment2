using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KatoLefebvre_Assignment2.BusinessClasses;

namespace KatoLefebvre_Assignment2.BusinessClasses
{
    /// <summary>
    /// Class for OldCar that derives from Car.
    /// </summary>
    class OldCar : Car
    {
        private DepreciationRecord _record;

        /// <summary>
        /// Public constructor that creates an instance of OldCar.
        /// </summary>
        /// <param name="licensePlateNo"></param>
        /// <param name="carMake"></param>
        /// <param name="purchasePrice"></param>
        /// <param name="type"></param>
        public OldCar(string licensePlateNo, string carMake, float purchasePrice, CarType type,
            DepreciationRecord record) : base(licensePlateNo, carMake,
                purchasePrice, type)
        {
            _record = record;
        }

        /// <summary>
        /// Public getter and setter for instance of DepreciationReceord _record.
        /// </summary>
        public DepreciationRecord Record
        {
            get
            {
                return _record;
            }
            set
            {
                if (!value.Equals(null))
                    _record = value;
                else
                    throw new Exception("ERROR: DEPRECIATION RECORD CANNOT BE NULL");
            }
        }
    }
}
