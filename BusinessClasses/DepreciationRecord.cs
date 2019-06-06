using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatoLefebvre_Assignment2.BusinessClasses
{
    public class DepreciationRecord
    {
        private int _model, _mileage;
        private float _insuranceDepreciation;

        /// <summary>
        /// Public constructor that creates an instance of DepreciationRecord.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="mileage"></param>
        /// <param name="insuranceDepreciation"></param>
        public DepreciationRecord(int model, int mileage, float insuranceDepreciation)
        {
            Model = model;
            Mileage = mileage;
            InsuranceDepreciation = insuranceDepreciation;
        }

        /// <summary>
        /// Public getter and setter for the property _model.
        /// </summary>
        public int Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (value > 0)
                    _model = value;
                else
                    throw new Exception("ERROR: MODEL CANNOT BE 0");
            }
        }

        /// <summary>
        /// Public getter and setter for the property _mileage.
        /// </summary>
        public int Mileage
        {
            get
            {
                return _mileage;
            }
            set
            {
                if (value >= 0)
                    _mileage = value;
                else
                    throw new Exception("ERROR: MILEAGE CANNOT BE LESS THAN 0");
            }
        }

        /// <summary>
        /// Public getter and setter for the property _insuranceDepreciation.
        /// </summary>
        public float InsuranceDepreciation
        {
            get
            {
                return _insuranceDepreciation;
            }
            set
            {
                if (value >= 0)
                    _insuranceDepreciation = value;
                else
                    throw new Exception("ERROR: INSURANCE DEPRECIATION CANNOT BE LESS THAN 0");
            }
        }

        /// <summary>
        /// Read-only property that calculates the total depreciation based on the age of the car and 
        /// the insurance depreciation set by the seller.
        /// </summary>
        public float TotalDepreciation
        {
            get
            {
                // get the current year
                DateTime today = DateTime.Today;
                int year = today.Year;

                // subtract the current year from the model year to get the difference
                // aka how old the car is
                int yearDifference = year - Model;

                // total depreciation increases by 10% per year before the current year and by
                // 0.9% per 10,000 miles on the mileage
                float totalDepreciation = (yearDifference * 10) + (((float)Mileage / 10000f) * 0.9f)
                    + InsuranceDepreciation;

                return totalDepreciation;
            }
        }
    }
}
