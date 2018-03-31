using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using XMyanmarAPI.Model.Request;
using XMyanmarAPI.Model.Response;
using XMyanmarAPI.Services;

namespace XMyanmarAPI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class XMyanmarAPI : XMyanmarAPIService
    {
        /// <summary>
        /// Login
        /// </summary>
        /// <param name="objAuthInfo"></param>
        public ResLogin Login(AuthenticationInfo objAuthInfo)
        {
            GeneralServices objService = new GeneralServices();
            return objService.Login(objAuthInfo);
        }

        /// <summary>
        /// GetCategory
        /// </summary>
        /// <param name="objAuthInfo"></param>
        /// <returns></returns>
        public ResCategory GetCategory(AuthenticationInfo objAuthInfo)
        {
            MenuService objService = new MenuService();
            return objService.GetCategory(objAuthInfo);
        }
    }
}
