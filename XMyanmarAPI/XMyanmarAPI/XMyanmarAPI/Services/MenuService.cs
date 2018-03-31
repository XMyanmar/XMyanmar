using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XMyanmarAPI.Model.Request;
using XMyanmarAPI.Model.Response;

namespace XMyanmarAPI.Services
{
    // Menu click services
    partial class MenuService:BaseService
    {
        public ResCategory GetCategory(AuthenticationInfo objAuthInfo)
        {
            ResCategory objResponse = new ResCategory();
            try
            {
                // entry log
            }

            catch (Exception ex)
            {
                objResponse.Result = CreateResult(ex, objAuthInfo);
            }
            finally
            {
                // exit log
            }

            return objResponse;

        }
    }
}