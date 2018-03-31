using DataAccess.Dao;
using DataAccess.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XMyanmarAPI.Model;
using XMyanmarAPI.Model.Request;
using XMyanmarAPI.Utility;
using System.Runtime.CompilerServices;

namespace XMyanmarAPI.Services
{
    partial class BaseService
    {
        /// <summary>
        /// 設定ファイル用フォルダ
        /// </summary>
        private const string LOG_CONFIG_DIR = @"App_Data";

        /// <summary>
        /// 初期化済みフラグ
        /// </summary>
        private static bool _initialized = false;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        protected BaseService()
        {
            if (_initialized == false)
            {
                LogHelper.Initialize();
                DBHelper.Initialize();

                _initialized = true;
            }
        }

        /// <summary>
        /// T.B.D
        /// </summary>
        /// <param name="loginID"></param>
        /// <param name="password"></param>
        /// <param name="bCheckExpired"></param>
        /// <returns></returns>
        //protected User Login(string loginID, string password, bool bCheckExpired = true)
        //{
        //    User objUser = LoginDao.Login(loginID, password, bCheckExpired);

        //    return objUser;
        //}

        protected Result CreateResult(Exception exIn, AuthenticationInfo objAuthInfo,
         [CallerMemberName] string sMethodName = "",
         [CallerFilePath] string sFilePath = "",
         [CallerLineNumber] int nLineNumber = 0)
        {
            Result ret = new Result();

            try
            {

            }
            catch (Exception ex)
            {

            }

            return ret;
        }
    }
}