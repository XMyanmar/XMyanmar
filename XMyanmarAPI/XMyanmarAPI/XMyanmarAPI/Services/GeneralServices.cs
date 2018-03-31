using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XMyanmarAPI.Model.Request;
using XMyanmarAPI.Model.Response;

namespace XMyanmarAPI.Services
{
    partial class GeneralServices : BaseService
    {
        public ResLogin Login(AuthenticationInfo objAuthInfo)
        {
            ResLogin objResponse = new ResLogin();
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