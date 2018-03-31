using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using XMyanmarAPI.Model.Request;
using XMyanmarAPI.Model.Response;

namespace XMyanmarAPI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface XMyanmarAPIService
    {
        [OperationContract]
        ResLogin Login(AuthenticationInfo objAuthInfo);

        [OperationContract]
        ResCategory GetCategory(AuthenticationInfo objAuthInfo);
    }
}
