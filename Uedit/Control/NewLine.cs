// -----------------------------------------------------------------------
// <copyright file="NewLine.cs" company="微软中国">
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
    /// 分割线控件
    /// </summary>
    public class NewLine : NewBaseImage
    {
        protected override Bitmap SetImage()
        {
            Bitmap image = new Bitmap(Child.Size.Width, Child.Size.Height);

            using (Graphics g = Graphics.FromImage(image))
            {
                using (Pen p = new Pen(Color.Red))
                {
                    g.DrawLine(p, Child.Location.X, Child.Location.Y + 5, Child.Location.X + Child.Size.Width, Child.Location.Y + 5);
                }
            }

            return image;
        }
    }
}
