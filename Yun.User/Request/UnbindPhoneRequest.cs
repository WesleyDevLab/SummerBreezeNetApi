﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;

namespace Yun.User.Request
{
    public class UnbindPhoneRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 验证码
        /// </summary>
        public string Code { get; set; }


        public string GetApiName()
        {
            return "chenggou.user.mobilephone.unbind";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"code",Code}
            };
            return parameters;
        }

        public void Validate()
        {
           
        }
    }
}
