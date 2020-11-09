using System;
using System.Collections.Generic;
using System.Text;

namespace MySql.DAL.Core.MyDbData
{
    public class Geomagnetism
    {
        /// <summary>
        /// 地磁Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 车位状态（空：未知，0：无车，1：有车
        /// </summary>
        public string State { get; set; } = "未知";

        /// <summary>
        /// 设备安装地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// 上传时间
        /// </summary>
        public DateTime UploadTime { get; set; }

        /// <summary>
        /// 接收时间
        /// </summary>
        public DateTime ReceiveTime { get; set; }

        /// <summary>
        /// 是否在线
        /// </summary>
        public bool IsOnline => (DateTime.Now - ReceiveTime).TotalDays <= 1.0D;

        /// <summary>
        /// 是否有车停放
        /// </summary>
        public bool IsStoped => !string.IsNullOrEmpty(State) && State == "有车";

        ///// <summary>
        ///// 更新状态
        ///// </summary>
        ///// <param name="status"></param>
        //public void Update(Status status)
        //{
        //    Id = status.serial;
            
        //    State = "未知";
        //    if (string.IsNullOrEmpty(status.state))
        //    { }
        //    else if (status.state == "0")
        //    {
        //        State = "无车";
        //    }
        //    else if (status.state == "1")
        //    {
        //        State = "有车";
        //    }

        //    Address = status.address;
        //    if (!string.IsNullOrEmpty(status.lnglat))
        //    {
        //        var lonlat = status.lnglat.Split(',');
        //        if (lonlat.Length == 2 && double.TryParse(lonlat[0], out var lon) && double.TryParse(lonlat[1], out var lat))
        //        {
        //            Longitude = lon;
        //            Latitude = lat;
        //        }
        //        else
        //        {
        //            Longitude = 0.0D;
        //            Latitude = 0.0D;
        //        }
        //    }

        //    //DateTime.TryParseExact(status.event_time, "yyyyMMddHHmmss", null, System.Globalization.DateTimeStyles.None, out var t);
        //    DateTime.TryParse(status.event_time, out var t);
        //    UploadTime = t;
        //    ReceiveTime = DateTime.Now;
        //}

        ///// <summary>
        ///// 更新状态
        ///// </summary>
        ///// <param name="info"></param>
        //public void Update(Info info)
        //{
        //    Id = info.serial;
        //    DateTime.TryParseExact(info.event_time, "yyyyMMddHHmmss", null, System.Globalization.DateTimeStyles.None, out var t);
        //    UploadTime = t;
        //    ReceiveTime = DateTime.Now;
        //}
    }
}
