﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.Interface;
using Yun.Marketing.Request;
using Yun.Response;

namespace Yun.UnitTest
{
    /// <summary>
    /// MarketingUnitTest 的摘要说明
    /// </summary>
    [TestClass]
    public class MarketingUnitTest
    {
        private string url = "";
        private string appkey = "";
        private string secret = "";
        private string sessionKey = "";

        [TestMethod]
        public void GenerateCashCouponRequest()
        {
            IYunClient client = new DefaultYunClient(url, appkey, secret);
            GenerateCashCouponRequest req = new GenerateCashCouponRequest();
            req.CategoryId = 1;
            req.Num = 29;
            StringResultResponse rsp = client.Execute(req, sessionKey);
            Console.WriteLine(rsp.Body);
            //var req =
            //    YunClient.Instance.Execute(new GenerateCashCouponRequest {CategoryId = 1, Num = 29},
            //        YunClient.GetAdminToken()).Result;
            //
            //Assert.IsTrue(!string.IsNullOrEmpty(req));
        }

        [TestMethod]
        public void FindCashCouponRequest()
        {
            var req =
                YunClient.Instance.Execute(new FindCashCouponRequest {PageNum = 1, PageSize = 20, CategoryId = 1})
                    .CashCoupons;

            Assert.IsTrue(req!=null&&req.Any());
        }

        [TestMethod]
        public void ReceiveVouchersRequest()
        {
            var req = YunClient.Instance.Execute(new ReceiveVouchersRequest {CashCouponCatId = 2, UserId = 149313});

            Assert.IsTrue(req.Result>0);
        }
    }
}
