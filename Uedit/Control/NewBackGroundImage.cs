// -----------------------------------------------------------------------
// <copyright file="NewBackGroundImage.cs" company="微软中国">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Uedit.CustomerControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Drawing;
    using System.Windows.Forms;
    using Uedit.Util;

    /// <summary>
    /// 背景图片控件
    /// </summary>
    public class NewBackGroundImage : NewBaseImage
    {
        protected override Bitmap SetImage()
        {
            Bitmap image = new Bitmap(Child.Size.Width, Child.Size.Height);
            using (Graphics g = Graphics.FromImage(image))
            {
                using (Pen p = new Pen(Color.Red))
                {
                    g.DrawRectangle(p, 0, 0, Child.Size.Width - 10, Child.Size.Height - 10);
                }
            }
            return image;
        }
    }
}
