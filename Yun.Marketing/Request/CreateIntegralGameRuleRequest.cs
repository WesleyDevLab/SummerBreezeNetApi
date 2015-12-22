﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 新增积分游戏规则
    /// chenggou.game.integralrule.add
    /// </summary>
    public class CreateIntegralGameRuleRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 游戏ID
        /// </summary>
        public int GameId { get; set; }

        /// <summary>
        /// 所需最小积分
        /// </summary>
        public int MinIntegral { get; set; }

        /// <summary>
        /// 所需最大积分
        /// </summary>
        public int MaxIntegral { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public int GoodsId { get; set; }

        /// <summary>
        /// 自定义商品名字
        /// </summary>
        public string GoodsName { get; set; }

        /// <summary>
        /// 自定义商品描述
        /// </summary>
        public string GoodsDescription { get; set; }

        /// <summary>
        /// 自定义商品库存
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }


        /// <summary>
        /// 是否开启自定义库存
        /// </summary>
        public bool EnabledStock { get; set; }

        /// <summary>
        /// 规则名字
        /// </summary>
        public string RuleName { get; set; }

        public string GetApiName()
        {
            return "chenggou.game.integralrule.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"gameid", GameId},
                {"minintegral", MinIntegral},
                {"maxintegral", MaxIntegral},
                {"goodsid", GoodsId},
                {"goodsname", GoodsName},
                {"goodsdescription", GoodsDescription},
                {"stock", Stock},
                {"sort", Sort},
                {"enabledstock", EnabledStock},
                {"rulename", RuleName}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("gameid", GameId);
        }
    }
}
