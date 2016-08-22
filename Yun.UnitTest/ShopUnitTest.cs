﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.Shop.Request;
using Yun.Item.Request;
using Yun.User.Request;

namespace Yun.UnitTest
{
    [TestClass]
    public class ShopUnitTest
    {
        [TestMethod]
        public void AddShopRequest()
        {
            YunClient.Format = "xml";
            var reqLogin =
        YunClient.Instance.Execute(new LoginRequest
         {
           UserName = "18606683125",
           Password = "111111",
          AppSecret = YunClient.AppSecret
          }).Token;
            var req =
                YunClient.Instance.Execute(new AddShopRequest
                {
                    Name = "雨辰的店铺" ,
                    UserName = "amy",
                    Password = "128128",
                    CompanyId = 114,
                    ShopType = 1,
                    Email = "1805768571@qq.com",
                    Ip = "192.168.1.1",
                    ShopkeeperPhone = "18606683125",
                    BusinessLicense = "123456",
                    Bulletin = "1",
                    Banner = "1",
                    Businesslicense="AA001",
                    Address = "浙江宁波",
                    AreaId = 1,
                    AppSecret = YunClient.AppSecret,
                    CategoryId = 1,
                    CertifiedPhotos = "1",
                    CityId = 1,
                    Contacts = "tiantian",
                    Coordinate = "50",
                    Description = "公司主要销售电子产品",
                    DeliveryTime = 10,
                    Hours = "12",
                    HomeUrl = "a",
                    Image = null,

                }, reqLogin);
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void UpdateShopRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new UpdateShopRequest
                {
                    Title = "aa",
                    Phone = "18606683125",
                    Address = "zhejiang",
                    Hours = "12",
                    Coordinate = "120",
                    Summary = "jianjie",
                    Bulletin = "gonggao",
                    HomeUrl = "http://wwww.baidu.com",
                    Image = "00",
                    Description = "miaoshu",
                    Location = "weizhi",


                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddCompanyRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new AddCompanyRequest
                {
                    Name = "宁波雨辰公司",
                    PrepaidCardProportion = 10,

                    AppSecret = YunClient.AppSecret,

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void SearchShopsRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new SearchShopsRequest
                {
                    
                    

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void FindCompaniesRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new FindCompaniesRequest
                {
                    PageSize = 10,
                    PageNum = 1,
                    Name = "宁波雨辰公司"

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddShopAlumbRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new AddShopAlumbRequest
                {



                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddShopAreaRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new AddShopAreaRequest
                {
                    Name = "消费搜00",
                    Sort = 1,
                    ParentId = 1,


                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetShopRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetShopRequest
                {
                    ShopId = 10940,


                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddShopCustomerserviceRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new AddShopCustomerserviceRequest
                {
                    Nick = "甜甜",
                    Qq = "1805768571",
                    IsFemale = true,


                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AskShopQuestionRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new AskShopQuestionRequest
                {
                    ShopId =11609,
                    Content = "店铺内容004",
                    

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void BatchUpdateCustomerSortRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new BatchUpdateCustomerSortRequest
                {


                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void BatchUpdateShopAreaRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new BatchUpdateShopAreaRequest
                {


                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void BatchUpdateShopCategoryRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new BatchUpdateShopCategoryRequest
                {


                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void ClaimShopRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new ClaimShopRequest
                {
                    ShopId = 1,
                    CompanyName = "公司02",
                    IdcardImg = "123456",
                    Email = "1805768571@qq.com",
                    LicenseImg = "123456789",
                    Mobile = "18606683125",

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteShopAlumbRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new DeleteShopAlumbRequest
                {
                    Ids = "1"

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteShopAreaRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new DeleteShopAreaRequest
                {
                    Id = 42659,

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteShopCategoryRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new DeleteShopCategoryRequest
                {
                    Id = 2,

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteShopCustomerServiceRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new DeleteShopCustomerServiceRequest
                {
                    Id = 3,

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteShopQuestionRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new DeleteShopQuestionRequest
                {
                    Ids = "7",

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void ExistCompanyRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new ExistCompanyRequest
                {
                    Content = "6",

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        //[TestMethod]
        //public void FindCompaniesRequest()
        //{
        //    YunClient.Format = "json";
        //    var req =
        //        YunClient.Instance.Execute(new FindCompaniesRequest
        //        {
        //            PageSize = 10,
        //            PageNum = 1,


        //        }, YunClient.GetAdminToken());
        ////    Assert.IsTrue(req != null);
        //}
        [TestMethod]
        public void GetCompanyRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetCompanyRequest
                {
                    Id = 7,


                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetCompanyRequest1()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetCompanyRequest
                {
                    Id = 7,


                });
            Assert.IsTrue(req != null);
        }
        //[TestMethod]
        //public void GetPrevShopAreasRequest()
        //{
        //    YunClient.Format = "xml";
        //    var req =
        //        YunClient.Instance.Execute(new GetPrevShopAreasRequest
        //        {
        //          Id=1,


        //        });
        //    Assert.IsTrue(req != null);
        //}
        //[TestMethod]
        //public void GetPrevShopCategoriesRequest()
        //{
        //    YunClient.Format = "xml";
        //    var req =
        //        YunClient.Instance.Execute(new GetPrevShopCategoriesRequest
        //        {
        //            Id = 1,


        //        });
        //    Assert.IsTrue(req != null);
        //}
        [TestMethod]
        public void GetShopAlumbsRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetShopAlumbsRequest
                {
                    ShopId = 1,
                    OnyDisplay = false
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetShopAreaRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetShopAreaRequest
                {
                    Id = 2,
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetShopAreasRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetShopAreasRequest
                {
                   
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetShopCategoriesRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetShopCategoriesRequest
                {

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetShopCategoryRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetShopCategoryRequest
                {
                    Id=1,
                 
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetShopCustomerserviceDetailRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetShopCustomerserviceDetailRequest
                {
                    Id = 1,

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetShopHomeSeoRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetShopHomeSeoRequest
                {
                  ShopId = 1,

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetShopQuestionRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetShopQuestionRequest
                {
                  Id =6,

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetShopQuestionsRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetShopQuestionsRequest
                {
                    PageSize = 10,
                    PageNum = 1,

                });
            Assert.IsTrue(req != null);
        }
        
        [TestMethod]
        public void UpdateShopAuditStatusRequest()
        {
            YunClient.Format = "json";
            var reqLogin =
       YunClient.Instance.Execute(new LoginRequest
       {
           UserName = "18606683125",
           Password = "111111",
           AppSecret = YunClient.AppSecret
       }).Token;
            var req =
                YunClient.Instance.Execute(new UpdateShopAuditStatusRequest
                {
                   ShopId = 11609,
                   Status = 1,

                }, reqLogin);
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddShopFavouriteRequest()
        {
            YunClient.Format = "json";
            var reqLogin =
     YunClient.Instance.Execute(new LoginRequest
     {
         UserName = "18606683125",
         Password = "111111",
         AppSecret = YunClient.AppSecret
     }).Token;
            var req =
                YunClient.Instance.Execute(new AddShopFavouriteRequest
                {
                  ShopId = 11609,
                  Sort = 1,
                  Note = "beizhu",

                }, reqLogin);
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteShopFavoriteRequest()
        {
            YunClient.Format = "json";
            var reqLogin =
 YunClient.Instance.Execute(new LoginRequest
 {
     UserName = "18606683125",
     Password = "111111",
     AppSecret = YunClient.AppSecret
 }).Token;
            var req =
                YunClient.Instance.Execute(new DeleteShopFavoriteRequest
                {
                    FavouriteIds = "11609",

                }, reqLogin);
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateShopFavoriteRemarkRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new UpdateShopFavoriteRemarkRequest
                {
                    FavouriteId = 1,
                    Remarks = "beizh",

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetShopFavoritesRequest()
        {
            YunClient.Format = "xml";
            var reqLogin =
YunClient.Instance.Execute(new LoginRequest
{
  UserName = "18606683125",
  Password = "111111",
  AppSecret = YunClient.AppSecret
}).Token;
            var req =
                YunClient.Instance.Execute(new GetShopFavoritesRequest
                {
                    

                }, reqLogin);
            Assert.IsTrue(req != null);
        }
        









    }

}


