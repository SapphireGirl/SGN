using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGN.Model
{
    public class Person 
    {
       
            public int PersonId { get; set; }
            public string FirstName { get; set; }
            public int[] PersonLocationId { get; set; }
            public int[] LocationIdStrings { get; set; }
            public string[] OrgStructLocDesc { get; set; }
            public string DataTextField { get; set; }
            public string onSelect { get; set; }
            public string primaryFacility { get; set; }


    }
}