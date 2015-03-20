using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SGN.Model
{
    public class PersonalInfo 
    {
        public int PersonalInfoId { get; set; }
        public string Bio { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }

        

        public PersonalInfo()
        {

        }
    }
}
