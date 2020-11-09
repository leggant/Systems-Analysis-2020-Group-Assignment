using System;
using System.Collections.Generic;
using System.Text;

namespace Halogen
{
    public enum accessLEvel
    {
        manegement,
        generalStaff,
        healthAndSafety,
        HR,
        Finance,
        legal,
        contractor,
        sitevisitor,
        tempstaff,
        nolongeremployed
    }
    public abstract class Person
    {
        protected int idnumber;
        protected int workplaceID;
        protected string firstname;
        protected string middlename;
        protected string lastName;
        protected string address;
        protected string city;
        protected string mobilePhone;
        protected string emailaddress;


        public Person()
        {
            
        }
        public abstract void SetaccessLevel();
    }
}
