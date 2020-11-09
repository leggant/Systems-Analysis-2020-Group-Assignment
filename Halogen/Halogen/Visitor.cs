using System;
using System.Collections.Generic;
using System.Text;

namespace Halogen
{
   public class Visitor : Person
    {
        private int visitoridNumber;
        private string companyName;
        private string companyphone;
        private DateTime visitDate;

        public Visitor()
           : base ()
        {

        }
            
        public override void SetaccessLevel()
        {

        }
    } 
}
