using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using Uedit.ReportManage;
using Uedit.CustomerControl;
using Uedit.ReportEntity;

namespace Uedit.Util
{
    public class Utils
    {
        public static String GetElementKey(String controlType)
        {
            switch (controlType)
            {
                case "Text":
                    return "100000002";
                case "ActiveText":
                    return "3" + Config.FileName.Substring(1) + ((Config.ElementNodeStartNum - 12 >= 10) ? "00" + (Config.ElementNodeStartNum - 12) : "000" + (Config.ElementNodeStartNum - 12));
                case "Image":
                    return "100000005";
                case "ActiveImage":
                    return "4" + Config.FileName.Substring(1) + ((Config.ElementNodeStartNum - 12 >= 10) ? "00" + (Config.ElementNodeStartNum - 12) : "000" + (Config.ElementNodeStartNum - 12));
                case "BackGroundImage":
                    return "100000000";
                case "Line":
                    return "";
                case "Table":
                    return "100000005";
                default:
                    return "";
            }
        }

        public static int GetElementNum(System.Xml.XmlNode element)
        {
            return Convert.ToInt32(element.Attributes["Num"].Value);
        }
        public static String GetElementType(System.Xml.XmlNode element)
        {
            return element.Attributes["Type"].Value;
        }
        public static String GetElementData(System.Xml.XmlNode element)
        {
            return element.SelectSingleNode("data").InnerText;
        }
        public static Point GetElementPosition(System.Xml.XmlNode element)
        {
            return new Point(
                                int.Parse(element.SelectSingleNode("position").Attributes["StartX"].Value),
                                int.Parse(element.SelectSingleNode("position").Attributes["StartY"].Value)
                            );
        }
        public static Size GetElementSize(System.Xml.XmlNode element)
        {
            return new Size(
                                int.Parse(element.SelectSingleNode("position").Attributes["Width"].Value),
                                int.Parse(element.SelectSingleNode("position").Attributes["Height"].Value)
                           );
        }

        public static String GetBase64FromImage(Bitmap image)
        {
            try
            {
                byte[] temp;
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    temp = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(temp, 0, (int)ms.Length);
                }
                return Convert.ToBase64String(temp);
            }
            catch (Exception e)
            {
                throw new Exception("图片转字符串失败");
            }
        }
        public static String GetBase64FromImage(System.Drawing.Image orgImage)
        {
            try
            {
                byte[] temp;
                using (Bitmap image = new Bitmap(orgImage))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        temp = new byte[ms.Length];
                        ms.Position = 0;
                        ms.Read(temp, 0, (int)ms.Length);
                    }
                }
                return Convert.ToBase64String(temp);
            }
            catch (Exception e)
            {
                throw new Exception("图片转字符串失败");
            }
        }
        public static Bitmap GetImageFromBase64(String base64string)
        {
            try
            {
                Bitmap image;
                byte[] temp = Convert.FromBase64String(base64string);
                using (MemoryStream ms = new MemoryStream(temp))
                {
                    image = new Bitmap(ms);
                }
                return image;
            }
            catch (Exception e)
            {
                throw new Exception("字符串转图片失败");
            }
        }
    }
}
