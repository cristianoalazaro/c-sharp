using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceAbstract
{
    internal class Printer : Device, IPrinter
    {
        public void Print(string document)
        {
            throw new NotImplementedException();
        }

        public override void ProcessDoc(string documento)
        {
            throw new NotImplementedException();
        }
    }
}
