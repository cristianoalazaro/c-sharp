using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceAbstract
{
    internal class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            throw new NotImplementedException();
        }

        public override void ProcessDoc(string documento)
        {
            throw new NotImplementedException();
        }

        public string Scan()
        {
            throw new NotImplementedException();
        }
    }
}
