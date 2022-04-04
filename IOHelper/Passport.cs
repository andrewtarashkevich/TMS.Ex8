using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Passport
    {
        public Passport(int serial, int number, string issued, DateTime issuedDate, bool isActive)
        {
            Serial = serial;
            Number = number;
            Issued = issued;
            Issued = issued;
            IsActive = isActive;
        }
        private int serial = -1;
        public int Serial 
        {
            get { return serial; }
            set 
            {
                if (value.ToString().Length == 4)
                    serial = value;
                else
                    throw new Exception("Serial = 4 digits!");
            }
        }
        private int number = -1;
        public int Number 
        {
            get { return number; }
            set
            {
                if (value.ToString().Length == 6)
                    number = value;
                else
                    throw new Exception("NUmber = 6 digits!");
            }
        }
        private string issued = "";
        public string Issued 
        {
            get
            {
                return issued;
            }
            set
            {
                if (value != "")
                    issued = value;
                else
                    throw new Exception("Emprty line!");
            }
        }

        private DateTime issuedDate = DateTime.MinValue;
        public DateTime IssuedDate 
        {
            get
            {
                return issuedDate;
            }
            set
            {
                if (value <= DateTime.Today)
                    issuedDate = value;
                else
                    throw new Exception("Wrong date input!");
            }

        }
        private bool isActive = false;
        public bool IsActive 
        { 
            get
            {
                return isActive;
            }
            set 
            {
                if (value)
                    isActive = value;
                else
                    throw new Exception("Set to true");
            }
        }

        
       
    }
}
