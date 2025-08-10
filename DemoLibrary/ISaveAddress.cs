 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public interface ISaveAddress
    {
        //interface, who ever implements this will have this method
        void SaveAdress(AddressModel address); 
    }
}
