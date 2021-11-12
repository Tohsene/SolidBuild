using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidBuild
{
    //liskov principle
    public class SoftwareEngineering
    {
    }

    public class BackEnd : SoftwareEngineering
    {
        public void learnOop() { }
    }

    public class FrontEnd : SoftwareEngineering { }

    public class CSharp : BackEnd { }

}
