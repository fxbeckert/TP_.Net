using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostApplication
{
    class HostObject : MarshalByRefObject, RemotingObjects.IRemoteObject
    {
        private int c = 0;
        public String sayHello (String name)
        {
            c++;
            return "Hello " + name + " number of invocations : " + c.ToString();

        }
    }
}
