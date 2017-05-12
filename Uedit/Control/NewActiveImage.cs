// -----------------------------------------------------------------------
// <copyright file="NewActiveImage.cs" company="微软中国">
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
    /// 动态图片控件
    /// </summary>
    public class NewActiveImage : NewBaseImage
    {
        protected override Bitmap SetImage()
        {
            Bitmap image = new Bitmap(Child.Size.Width, Child.Size.Height);

            using (Graphics g = Graphics.FromImage(image))
            {
                using (Brush b = new SolidBrush(Color.Red))
                {
                    g.FillEllipse(b, 5, 5, Child.Size.Width - 10, Child.Size.Height - 10);
                }
            }

            return image;
        }
    }
}
