using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldServiceNS
{
    public class HelloWorldService:IHelloWorldService
    {
        public string GetMessage(string Name)
        {
            return "Service Hosted By " + Name;
        }

    }
}
