﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.User.Request;

namespace Yun.UnitTest
{
    [TestClass]
    public class UserUnitTest
    {
        [TestMethod]
        public void ResetFunctionsRequest()
        {
            var req = YunClient.Instance.Execute(new ResetFunctionsRequest(), YunClient.GetAdminToken()).Result;
            Assert.IsTrue(req);
        }

        [TestMethod]
        public void GerPermissionUserRequest()
        {
            var req = YunClient.Instance.Execute(new GerPermissionUserRequest { Id = 172586 }, YunClient.GetAdminToken());
            Assert.IsTrue(req.User != null);
        }

        [TestMethod]
        public void LoginRequest()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new LoginRequest
                {
                    UserName = "测试网站111",
                    Password = "888999",
                    Ip = "192.168.1.1",
                    AppSecret = YunClient.AppSecret
                });

            Assert.IsTrue(req.UserId > 0);
        }
        [TestMethod]
        public void PhoneDynamicLoginRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new PhoneDynamicLoginRequest
                {
                    Ip = "192.168.1.1",
                    Phone = "12345678996",
                    Code = "888999",
                    ShopId = 123,
                    CompanyId = 123
                });

            Assert.IsTrue(req.UserId > 0);
        }
        [TestMethod]
        public void SendLoginCodePhoneRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new SendLoginCodePhoneRequest
                {
                    MobilePhone = "12345678996",
                    CompanyId = 123

                });

            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void ModifyUserInfoRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new ModifyUserInfoRequest()

                {
                    Nick = "12345678996",
                    IsMale = 0,
                    Avatar = "",
                    Email = "",
                    Mobile = "",
                    RealName = "",
                    Birthday = DateTime.Now,
                    Province = "",
                    City = "",
                    Area = "",
                    Address = "",
                    Remark = "",
                    Phone = "",
                    IdCard = "",
                    ////NewImage =
             });

            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void SendVerificationCodeRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new SendVerificationCodeRequest()

                {
                    UserFlag = "12345678996",
                    CompanyId = 123456,
                    SendType = "ABC",
                    Target = "12345678996",
                    ActionName = "HELLO"

                });

            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void ModifyPasswordRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new ModifyPasswordRequest()

                {
                    Password = "12345678996",
                    NewPassword = "123456789",
                    AppSecret = YunClient.AppSecret
                });

            Assert.IsTrue(req != null);
        }
        
        }
}