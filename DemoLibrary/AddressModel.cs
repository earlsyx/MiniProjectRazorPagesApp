using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class AddressModel
    {
        public string  StreetAddress { get; set; }
        public string City { get; set; }    
        public string State { get; set; }    
        public string ZipCode { get; set; }

        //Lambda Expression, Here is the code I want you to return.
        // a way of shortcuting things.
        // lambda expression is basically just assumptions because you undesrtand what's going on
        public string AddressDisplayValue => $"{StreetAddress}, {City}, {State} {ZipCode}";
      

    }
}
