﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class LoginMobilePhoneRequest : ITopRequest<BoolResultResponse>
    {

        /// <summary>
        /// 验证码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyId { get; set; }

        /// <summary>
        /// 用户标识
        /// </summary>
        public string UserFlag { get; set; }

        /// <summary>
        /// 是否销毁
        /// </summary>
        public bool IsDestroy { get; set; }

        public string GetApiName()
        {
            return "chenggou.user.mobilephone.login";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"code",Code},
                {"companyid",CompanyId},
                {"userflag",UserFlag},
                {"isdestroy",IsDestroy}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("code", Code);
        }
    }
}
