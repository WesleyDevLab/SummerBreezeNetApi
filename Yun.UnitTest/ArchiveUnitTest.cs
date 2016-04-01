﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.User.Archive;


namespace Yun.UnitTest
{
    [TestClass]
    public class ArchiveUnitTest
    {
        [TestMethod]
        public void GetArchivesRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new g
                {
                    Ip = "192.168.1.1",
                    Phone = "12345678996",
                    Code = "888999",
                    ShopId = 123,
                    CompanyId = 123
                });

            Assert.IsTrue(req.UserId > 0);
        }
    }
}
