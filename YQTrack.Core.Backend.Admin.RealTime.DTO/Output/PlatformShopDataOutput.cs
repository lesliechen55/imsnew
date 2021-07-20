﻿using System;
using System.Collections.Generic;
using System.Text;

namespace YQTrack.Core.Backend.Admin.RealTime.DTO.Output
{
    public class PlatformShopDataOutput
    {
        /// <summary>
        /// 平台类型
        /// </summary>
        public int PlatformType { get; set; }

        /// <summary>
        /// 平台名称
        /// </summary>
        public string PlatformTypeName { get; set; }

        /// <summary>
        /// 平台店铺总数量
        /// </summary>
        public int SumCount { get; set; }
    }


    public class UserPlatformShopDataOutput
    {
        /// <summary>
        /// 平台类型
        /// </summary>
        public int PlatformType { get; set; }

        /// <summary>
        /// 平台名称
        /// </summary>
        public long FUserId { get; set; }

    }
}
