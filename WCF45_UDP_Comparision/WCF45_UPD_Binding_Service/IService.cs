using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCF45_UPD_Binding_Service
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract(IsOneWay=true)]
        void PostMessages(MessagePost message);
    }

    [DataContract]
    public class MessagePost
    {
        [DataMember]
        public string MessageDetails { get; set; }
    }


}
