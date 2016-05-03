﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.User.Request;
using Yun.Util;

namespace Yun.UnitTest
{
    [TestClass]
    public class UserUnitTest
    {
        [TestMethod]
        public void ResetFunctionsRequest()
        {
            var req = YunClient.Instance.Execute(new ResetFunctionsRequest {CompanyId = 3}, YunClient.GetAdminToken()).Result;
            Assert.IsTrue(req);
        }

        [TestMethod]
        public void FileUploadRequest()
        {
            var req = YunClient.Instance.Execute(new FileUploadRequest
            {
                Images = new List<FileItem>
                {
                    new FileItem(@"c:\1.png")
                }
            });

            Assert.IsTrue(req.Files!=null);
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
                    UserName = "宁波雨辰环保旗舰店",
                    Password = "888999",
                    Ip = "192.168.1.1",
                    AppSecret = YunClient.AppSecret
                });

            Assert.IsTrue(req.UserId > 0);
        }
        [TestMethod]
        public void LoginMobilePhoneRequest()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new LoginMobilePhoneRequest
                {
                    Code = null,
                    CompanyId = 3,
                    IsDestroy = true,
                    UserFlag = null
                });

            Assert.IsTrue(req != null);
        }

        
        [TestMethod]
        public void AddEmployeeRequest()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new AddEmployeeRequest
                {
                    UserName = "宁波雨辰环保旗舰店",
                    AppSecret = YunClient.AppSecret,
                    Password = "888999",
                    Description = null,
                    DisplayName = null,
                    Email = "1805768571@qq.com",
                    EntryTime = null,
                    IdCard = null,
                    Ip = "192.168.1.1",
                    Phone = null,
                    WorkPlace = null,
                    JobNum = null,
                    OtherName = null,
                    Plane = null,
                    RoleIds = null
                }, YunClient.GetAdminToken());

            Assert.IsTrue(req.Result > 0);
        }
        [TestMethod]
        public void AddRoleRequest
()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new AddRoleRequest

                {
                    RoleType = 123,
                    CompanyId = 001,
                    Description = "miaoshu",
                    Name = "xx",
                    ShopId = 002,
                    Sort = 0.1
                }, YunClient.GetAdminToken());

            Assert.IsTrue(req.Result > 0);
        }

        [TestMethod]
        public void PhoneDynamicLoginRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new PhoneDynamicLoginRequest
                {
                    Ip = "192.168.1.1",
                    Phone = "18606683125",
                    Code = "566020b543fd462ca57fcac847c816ef",
                    ShopId = 123,
                    CompanyId = 123,
                }, YunClient.GetAdminToken());

            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void SendLoginCodePhoneRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new SendLoginCodePhoneRequest
                {
                    MobilePhone = "18606683125",
                    CompanyId = null
                }, YunClient.GetAdminToken());

            Assert.IsTrue(req != null);
        }
        
        [TestMethod]
        public void ModifyUserInfoRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new ModifyUserInfoRequest()

                {
                    Nick = "hello",
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
                    UserFlag = null,
                    CompanyId = 123,
                    SendType = "1805768571@qq.com",
                    Target = null,
                    ActionName = "密码找回"

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
        [TestMethod]
        public void ModifyPasswordUserRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new ModifyPasswordUserRequest()

                {
                    Id = 172586,
                    Password = "12345678996",
                    
                });

            Assert.IsTrue(req != null);
        }
        
        [TestMethod]
        public void ModifyUserCreditRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new ModifyUserCreditRequest()

                {
                    UserNick = null,
                    Credit = 1,
                    ExpiredDay = 1,
                    Remark = null,
                });

            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void ModifyUserMoneyRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new ModifyUserMoneyRequest()

                {
                    UserNick = null,
                    UserId = 1,
                    AllowNegative = true,
                    Ip = "192.168.1.1",
                    Money = 0.1,
                    Remark = null,
             
                    
                });

            Assert.IsTrue(req != null);
        }
        
        [TestMethod]
        public void PhoneRegisterRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new PhoneRegisterRequest()

                {
                    Ip = "192.168.1.1",
                    Address = "gaoxinqu",
                    Area = "china",
                    City="ningbo",
                    Code = null,
                    CompanyId = 123,
                    IdCard = "199202061644",
                    Password = "123",
                    Phone = "18606683125",
                    Province = "zhejiang",
                    Secret = YunClient.AppSecret,
                    ShopId = 123,
                    UserFlag = "flag"
                }, YunClient.GetAdminToken());

            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetUserRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetUserRequest()

                {
                    Nick = "hello",
                    UserId = 172586,
                }, YunClient.GetAdminToken());

            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void LoginOauth2Request()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new LoginOauth2Request()
                 {
                    NickName = null,
                    OAuthId = "1",
                    Avatar = null,
                    Email = "1805768571@qq.com",
                    Ip = "192.168.1.1",
                    OAuth2Type = "1",
                    Phone = "18606683125",
                    RealName = null,
                    ShopId = 1,
                    UserMeta = null,
                });
          Assert.IsTrue(req != null);

        }
        [TestMethod]
        public void RegisterRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new RegisterRequest()

                {

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void BindOauth2AccountRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new BindOauth2AccountRequest()

                {
                    OAuthId = "1",
                    OAuth2Type = "1",
                    UserId = 1,
                    UserMeta = null,

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void BindEmailRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new BindEmailRequest()

                {
                    Email = "1805768571@qq.com",
                    Code = "1"

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void BindPhoneRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new BindPhoneRequest()
               {
                    Phone = "1860668215",
                    Code = "0"

                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void AuthSessionRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new AuthSessionRequest()

                {

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UnbindEmailRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new UnbindEmailRequest()

                {
                    Code = "1"

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UnbindPhoneRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new UnbindPhoneRequest()

                {
                    Code = "1",

                });
            Assert.IsTrue(req != null);
        }
        

    }
}