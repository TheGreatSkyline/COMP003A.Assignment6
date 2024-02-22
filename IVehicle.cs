/*
 Author: Joaquin Gomez
 Course: COMP-003A
 Purpose: Object-oriented programming concepts for week 6
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6
{
    /*
      Interfaces are contracts that the inheriting class has to implement.
      Read https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/abstractions-abstract-types-and-interfaces
    */
    internal interface IVehicle
    {
        /// this method is required to be implemented in the inheriting class
        public void GetInfo();
    }
}
