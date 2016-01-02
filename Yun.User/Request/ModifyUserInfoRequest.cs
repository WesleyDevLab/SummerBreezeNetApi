﻿using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 修改用户的个人资料
    /// </summary>
    public class ModifyUserInfoRequest : ITopUploadRequest<IntResultResponse>
    {
        /// <summary>
        /// 当前用户的用户名
        /// 用户名不能修改
        /// </summary>
        public string Nick { get; set; }


        /// <summary>
        /// 是否是男性
        /// </summary>
        public int IsMale { get; set; }

        /// <summary>
        /// 用户头像
        /// </summary>
        public string Avatar { get; set; }


        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }


        /// <summary>
        /// 用户手机号
        /// </summary>
        public string Mobile { get; set; }


        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealName { get; set; }


        /// <summary>
        /// 用户的生日，UNIX时间戳
        /// </summary>
        public DateTime? Birthday { get; set; }


        /// <summary>
        /// 省
        /// </summary>
        public string Province { get; set; }


        /// <summary>
        /// 市
        /// </summary>
        public string City { get; set; }


        /// <summary>
        /// 区
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        public string Address { get; set; }


        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone { get; set; }


        public string GetApiName()
        {
            return "chenggou.user.modify";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"nick", Nick},
                {"ismale",IsMale},
                {"avatar",Avatar},
                {"email",Email},
                {"mobile",Mobile},
                {"realname",RealName},
                {"birthday",Birthday},
                {"province",Province},
                {"city",City},
                {"area",Area},
                {"address",Address},
                {"remark",Remark},
                {"phone",Phone}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("nick", Nick);
        }

        public IDictionary<string, FileItem> GetFileParameters()
        {
            return new Dictionary<string, FileItem> { { "NewImage", NewImage } };
        }

        /// <summary>
        /// 上传的图片
        /// </summary>
        public FileItem NewImage { get; set; }
    }
}
