﻿using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 获取全局商品类目
    /// </summary>
    public class GetItemCategorysRequest : ITopRequest<ItemCatsResponse>
    {
        /// <summary>
        /// 上级分类ID,0表示顶级
        /// </summary>
        public int? ParentId { get; set; }

        public string GetApiName()
        {
            return "chenggou.itemcats.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"parentid", ParentId}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
