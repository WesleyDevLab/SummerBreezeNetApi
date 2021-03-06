﻿using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 生成自定义代金券
    /// chenggou.cashcoupon.custom.generate
    /// </summary>
    public class GenerateCustomCashCouponRequest :ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 代金券编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 代金券分类ID
        /// </summary>
        public int CategoryId { get; set; }


        public string GetApiName()
        {
            return "chenggou.cashcoupon.custom.generate";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"code", Code},
                {"categoryid", CategoryId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("code", Code);
            RequestValidator.ValidateRequired("categoryid", CategoryId);
        }
    }
}
