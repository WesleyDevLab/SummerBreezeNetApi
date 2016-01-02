﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class InquiryVerificationcodeRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 验证码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 公司id
        /// </summary>
        public int CompanyId { get; set; }

        /// <summary>
        /// 用户标识
        /// </summary>
        public string UserFlag { get; set; }

        /// <summary>
        /// 是否销毁
        /// </summary>
        public bool Isdestroy { get; set; }

        public string GetApiName()
        {
            return "chenggou.user.verificationcode.inquiry";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"code",Code},
                {"companyid",CompanyId},
                {"userflag",UserFlag},
                {"isdestroy",Isdestroy}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("code", Code);
        }
    }
}
