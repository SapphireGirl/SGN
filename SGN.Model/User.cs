using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SGN.Model
{
    public class User 
    {
          
        
         
        public virtual int UserId { get; set; }
        private string _firstName;
        private string _lastName;
        private string _email;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value.Length > 15)
                {
                    throw new InvalidOperationException("First Name must be less than 15 characters");
                }
                else if (value.Length == 0)
                {
                    throw new InvalidOperationException("First Name cannot be left blank");
                }
                _firstName = value;
            }
        }
        public string LastName
        {
            get { return _lastName; } 
            set
            {
                if (value.Length > 25)
                {
                    throw new InvalidOperationException("Last Name must be less than 25 characters");
                }
                _lastName = value;
            }
        }        
        public string FullNameReverse
        {
            get { return LastName.Trim() + ", " + FirstName; }
        }
        public string FullName
        {
            //get { return string.Format("{0} {1}", FirstName, LastName); }
            get { return FirstName.Trim() +" " + LastName.Trim(); }

            
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (!Email.Contains("@"))
                    throw new Exception("Email must contain @");
                else if (!Email.Contains("a"))
                    throw new Exception("Email does not contain aphabet characters");
            }
        }

        // Navigation Property
        // Must be virtual for LazyLoading
        //public virtual ICollection<ResaleProduct> ResaleProducts { get; set; }
     
        public int ProductsCount { get; set; }
        public DateTime DateCreated { get; set; }
        public Address UserAddress { get; set; }
        public PersonalInfo Info { get; set; }
        

        public User()
        {
            DateCreated = DateTime.Now;
            UserAddress = new Address();
            Info = new PersonalInfo();
          //  ResaleProducts = new Collection<ResaleProduct>();
        }

       
    }
}
