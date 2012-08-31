using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF45_MultipleAuthentication_Single_EDP_In_IIS
{
    public class Service : IService
    {
        Employee[] Employees;
        public Service()
        {
            Employees = new Employee[]
            {
                 new Employee() {EmpNo=101,EmpName="A"},
                 new Employee() {EmpNo=102,EmpName="B"},
                 new Employee() {EmpNo=103,EmpName="C"},
                 new Employee() {EmpNo=104,EmpName="D"}
            };
        }
        public Employee[] GetEmployees()
        {
            return Employees;
        }
    }
}
