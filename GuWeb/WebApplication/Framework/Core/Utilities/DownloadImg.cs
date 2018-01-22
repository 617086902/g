﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities {
    /// <summary>
    /// 下载图片
    /// </summary>
    public class DownloadImg {
        /// <summary>
        /// 下载
        /// </summary>
        /// <param name="url">图片地址</param>
        /// <param name="imgPath">保存本地路径</param>
        public static void Load(string url, string imgPath) {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream reader = response.GetResponseStream();
            FileStream writer = new FileStream(imgPath, FileMode.OpenOrCreate, FileAccess.Write);
            byte[] buff = new byte[4096];
            int c = 0; //实际读取的字节数
            while ((c = reader.Read(buff, 0, buff.Length)) > 0) {
                writer.Write(buff, 0, c);
            }
            writer.Close();
            writer.Dispose();
            reader.Close();
            reader.Dispose();
            response.Close();
        }
    }
}