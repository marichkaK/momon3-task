using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxiDriverApp.DataTypes
{
    public class TaxiDriver
    {
        private uint id;
        private string surname;
        private string name;
        private uint age;
        private string carNumber;
        private uint experience;
        private uint costPerMinute;
        private double payCheck;

        /// <summary>
        /// Properties, which return/define id.
        /// </summary>
        public uint Id
        {
            get
            {
                return id;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Driver id cant be < 0");
                }
                id = value;
            }
        }

        /// <summary>
        /// Properties, which return/define surname.
        /// </summary>
        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("Drive surname cant be empty");
                }
                surname = value;
            }
        }

        /// <summary>
        /// Properties, which return/define the name.
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("Drive name cant be empty");
                }
                name = value;
            }
        }

        /// <summary>
        /// Properties, which return/define the age.
        /// </summary>
        public uint Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    throw new ArgumentOutOfRangeException("Driver is too young!");
                }
                age = value;
            }
        }

        /// <summary>
        /// Properties, which return/define car number.
        /// </summary>
        public string CarNumber
        {
            get
            {
                return carNumber;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("Car Number cant be empty");
                }
                carNumber = value;
            }
        }

        /// <summary>
        /// Properties, which return/define experience of taxi driver.
        /// </summary>
        public uint Experience
        {
            get
            {
                return experience;
            }

            set
            {
                if (value < 2)
                {
                    throw new ArgumentOutOfRangeException("Drive has a small experience");
                }
                experience = value;
            }
        }

        /// <summary>
        /// Properties, which return/define cost per minute.
        /// </summary>
        public uint CostPerMinute
        {
            get
            {
                return costPerMinute;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Cost per minute cant be less then 0");
                }

                costPerMinute = value;
            }
        }

        /// <summary>
        /// Properties, which return/define the bill.
        /// </summary>
        public double PayCheck
        {
            get
            {
                return payCheck;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("PayCheck cnat be < than 0");
                }
                payCheck = value;
            }
        }

        /// <summary>
        /// Constructor without parameters.
        /// </summary>
        public TaxiDriver()
        {
            PayCheck = 0;
        }

        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="_id"> id </param>
        /// <param name="_surname"> surname </param>
        /// <param name="_name"> name </param>
        /// <param name="_age"> age </param>
        /// <param name="_carNumber"> car number </param>
        /// <param name="_experience"> experience </param>
        /// <param name="_cost"> cost per minute drive </param>
        /// <param name="_pay"> sum of the bill </param>
        public TaxiDriver(uint _id, string _surname, string _name, uint _age, string _carNumber, uint _experience, uint _cost, double _pay = 0)
        {
            Id = _id;
            Surname = _surname;
            Name = _name;
            Age = _age;
            CarNumber = _carNumber;
            Experience = _experience;
            CostPerMinute = _cost;
            PayCheck = _pay;
        }

        /// <summary>
        /// ToString Method for Taxi Driver class.
        /// </summary>
        /// <returns> String with TaxiDriver class data fields. </returns>
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5} {6} {7}", Id, Surname, Name, Age, CarNumber, Experience, CostPerMinute, PayCheck);
        }
    }
}
