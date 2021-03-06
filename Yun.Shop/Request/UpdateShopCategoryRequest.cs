﻿using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    /// <summary>
    /// 更新店铺分类
    /// </summary>
    public class UpdateShopCategoryRequest : ITopRequest<BoolResultResponse>
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
        /// 分类ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.shop.category.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"name", Name},
                {"sort",Sort},
                {"parentid", ParentId},
                {"id", Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateMinValue("sort", Sort, 0);
            RequestValidator.ValidateMinValue("parentid", ParentId, 0);
            RequestValidator.ValidateMinValue("id", Id, 1);
        }
    }
}
