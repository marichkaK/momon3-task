using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DataTypes
{
    /// <summary>
    /// Represents class of Taxi Client.
    /// </summary>
    class TaxiClient
    {
        // fields.
        private uint id;
        private string name;
        private string phoneNumber;

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
                    throw new ArgumentOutOfRangeException("Client Id cant be < than 0");
                }

                id = value;
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
                    throw new ArgumentOutOfRangeException("Name cant be empty");
                }
                name = value;
            }
        }

        /// <summary>
        /// Properties, which return/define phone number.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                if (value.Length < 10 || value.Length > 13)
                {
                    throw new ArgumentOutOfRangeException("Phone number is incorrect");
                }
                phoneNumber = value;
            }
        }

        /// <summary>
        /// Constructor without parameters.
        /// </summary>
        public TaxiClient()
        {
        }

        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="_id"> id </param>
        /// <param name="_name"> taxi client name </param>
        /// <param name="_phoneNumber"> phone number </param>
        public TaxiClient(uint _id, string _name, string _phoneNumber)
        {
            Id = _id;
            Name = _name;
            PhoneNumber = _phoneNumber;
        }

        /// <summary>
        /// ToString Method for Taxi Client class.
        /// </summary>
        /// <returns> String with TaxiClient class data fields. </returns>
        public override string ToString()
        {
            return String.Format("{0} {1} {2}", Id, Name, PhoneNumber);
        }
    }
}
