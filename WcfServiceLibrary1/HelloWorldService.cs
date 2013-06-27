using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldService
{
    [DataContract]
    public class Name
    {
        [DataMember]
        public string first;
        [DataMember]
        public string last;
    }

    [ServiceContract]
    public interface IHelloWorld
    {
        [OperationContract]
        string SayHello(Name person);
    }

    public class HelloWorldService: IHelloWorld
    {

        public string SayHello(Name person)
        {
            return string.Format("Hello {0} {1}", person.first, person.last);
        }
    }
}
