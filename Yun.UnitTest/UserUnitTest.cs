﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.User.Request;
using Yun.Util;

namespace Yun.UnitTest
{
    [TestClass]
    public class UserUnitTest
    {
        [TestMethod]
        public void ResetPasswordRequest()
        {
            var reqCode =
                YunClient.Instance.Execute(new SendVerificationCodeRequest
                {
                    SendType = "SMS",
                    Target = "15958805628",
                    ActionName = "用户注册",
                    UserFlag = "15958805628"
                }).Result;

            var resetReq = YunClient.Instance.Execute(new ResetPasswordRequest
            {
                AppSecret = YunClient.AppSecret,
                Code = reqCode,
                Password = "12345678",
                Phone = "15958805628",
                UserFlag = "15958805628"
            });

            if (!resetReq.Result)
            {
                Assert.Fail("修改密码失败");
            }

            var loginReq = YunClient.Instance.Execute(new LoginRequest
            {
                AppSecret = YunClient.AppSecret,
                Password = "12345678",
                Ip = "192.168.1.1",
                UserName = "15958805628"
            });

            Assert.IsTrue(loginReq.UserId>0);
        }

        [TestMethod]
        public void GetFunctionsRequest()
        {
            var req = YunClient.Instance.Execute(new GetFunctionsRequest {OnlyShowDisplay = true},
                YunClient.GetAdminToken());

            Assert.IsTrue(req.Functions.Any());
        }

        [TestMethod]
        public void ResetFunctionsRequest()
        {
            var req = YunClient.Instance.Execute(new ResetFunctionsRequest {CompanyId = 100}, YunClient.GetAdminToken()).Result;
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
                    Code = "879417",
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
                    UserName = "AA",
                    AppSecret = YunClient.AppSecret,
                    Password = "888999",
                 
                });

           Assert.IsTrue(req != null);
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

            var sendReq =
                YunClient.Instance.Execute(new SendLoginCodePhoneRequest
                {
                    MobilePhone = "13736169996"
                });

            var req =
                YunClient.Instance.Execute(new PhoneDynamicLoginRequest
                {
                    Ip = "192.168.1.1",
                    Phone = "13736169996",
                    Code = sendReq.Result
                });

            Assert.IsTrue(req.UserId>0);
        }

        [TestMethod]
        public void SendLoginCodePhoneRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new SendLoginCodePhoneRequest
                {
                    MobilePhone = "18606683125",
                    CompanyId = null
                });

            Assert.IsTrue(req != null);
        }
        
        [TestMethod]
        public void ModifyUserInfoRequest()
        {
            YunClient.Format = "json";

            var loginReq = YunClient.Instance.Execute(new LoginRequest
            {
                UserName = "15958805628",
                IgnorePassword = true,
                Ip = "192.168.1.1",
                AppSecret = YunClient.AppSecret
            }).Token;

            var user = YunClient.Instance.Execute(new GetUserRequest(), loginReq);

            var req =
                YunClient.Instance.Execute(new ModifyUserInfoRequest
                {
                    //IdCard = "11111",
                    Mobile = "15958805628",
                    //IsMale = 1
                }, loginReq);

            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void SendVerificationCodeRequest()
        {
            YunClient.Format = "json";

            var loginReq = YunClient.Instance.Execute(new LoginRequest
            {
                UserName = "15958805628",
                IgnorePassword = true,
                Ip = "192.168.1.1",
                AppSecret = YunClient.AppSecret
            }).Token;

            var req =
                YunClient.Instance.Execute(new SendVerificationCodeRequest
                {
                    SendType = "SMS",
                    Target = "15958805628",
                    ActionName = "用户注册",
                }, loginReq);

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
            var mobile = "15958805615";

            YunClient.Format = "json";

            var phoneReq =
                YunClient.Instance.Execute(new SendVerificationCodeRequest
                {
                    SendType = "SMS",
                    Target = mobile,
                    ActionName = "用户注册",
                    UserFlag = mobile
                });

            var req =
                YunClient.Instance.Execute(new PhoneRegisterRequest
                {
                    Ip = "192.168.1.1",
                    Code = phoneReq.Result,
                    Phone = mobile,
                    Secret = YunClient.AppSecret,
                    UserFlag = mobile,
                    Password = "888999"
                });

            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetUserRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetUserRequest()
                {
                    Nick = "15958805628",
                });

            Assert.IsTrue(string.IsNullOrEmpty(req.User.Mobile));
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
                    ShopId=1,
                    CompanyId=3,
                    UserName="lily",
                    Ip="192.168.1.1",
                    AppSecret=YunClient.AppSecret,
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
            var loginReq = YunClient.Instance.Execute(new LoginRequest
            {
                UserName = "15958805628",
                IgnorePassword = true,
                Ip = "192.168.1.1",
                AppSecret = YunClient.AppSecret
            }).Token;
            var req =
                YunClient.Instance.Execute(new BindPhoneRequest()
               {
                    Phone = "15958805628",
                    Code = "098265"
                }, loginReq);
            Assert.IsTrue(req.Result);
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

            var loginReq = YunClient.Instance.Execute(new LoginRequest
            {
                UserName = "15958805628",
                IgnorePassword = true,
                Ip = "192.168.1.1",
                AppSecret = YunClient.AppSecret
            }).Token;

            
            var req =
                YunClient.Instance.Execute(new UnbindPhoneRequest()
                {
                    Code = "056632",
                }, loginReq);
            Assert.IsTrue(req.Result);
        }

        [TestMethod]
        public void UploadAvatarUserRequest()
        {
            YunClient.Format = "json";

            var loginReq = YunClient.Instance.Execute(new LoginRequest
            {
                UserName = "15958805628",
                IgnorePassword = true,
                Ip = "192.168.1.1",
                AppSecret = YunClient.AppSecret
            }).Token;

            var req = YunClient.Instance.Execute(new UploadAvatarUserRequest {Image = new FileItem(@"C:\finally.png")},
                loginReq);

            Assert.IsTrue(req.Result);
        }

    }
}