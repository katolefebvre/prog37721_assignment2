using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KatoLefebvre_Assignment2.BusinessClasses;

namespace KatoLefebvre_Assignment2.BusinessClasses
{
    /// <summary>
    /// Class for NewCar that derives from Car.
    /// </summary>
    class NewCar : Car
    {
        /// <summary>
        /// Public constructor that creates an instance of NewCar.
        /// </summary>
        /// <param name="licensePlateNo"></param>
        /// <param name="carMake"></param>
        /// <param name="purchasePrice"></param>
        /// <param name="type"></param>
        public NewCar(string licensePlateNo, string carMake, float purchasePrice, CarType type)
            : base(licensePlateNo, carMake, purchasePrice, type)
        {
        }
    }
}
