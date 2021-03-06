﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    /// <summary>
    /// 新增店铺分类
    /// </summary>
    public class AddShopCategoryRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 分类名称
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// 分类排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 分类父ID
        /// </summary>
        public int ParentId { get; set; }

        /// <summary>
        /// 其他ID
        /// </summary>
        public int OtherId { get; set; }

        public string GetApiName()
        {
            return "chenggou.shop.category.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"name", Name},
                {"sort",Sort},
                {"parentid",ParentId},
                {"otherid",OtherId }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateMinValue("sort", Sort, 0);
            RequestValidator.ValidateMinValue("parentid", ParentId, 0);
        }
    }
}
