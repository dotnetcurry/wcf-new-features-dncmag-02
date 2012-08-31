using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF45_MultipleAuthentication_Single_EDP_In_IIS
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        Employee[] GetEmployees();
    }

    [DataContract]
    public class Employee
    {
        [DataMember]
        public int EmpNo { get; set; }
        [DataMember]
        public string EmpName { get; set; }
    }


    
}
