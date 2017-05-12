
// -----------------------------------------------------------------------
// <copyright file="NewBaseImage.cs" company="微软中国">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Uedit.CustomerControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using System.Drawing;
    using Uedit.Util;

    /// <summary>
    /// 图片控件基类
    /// </summary>
    public class NewBaseImage : NewBaseControl
    {
        public NewBaseImage()
        {
            Child = new PictureBox();
        }

        public override void Create()
        {
            base.Create();

            if (ControlSize == Size.Empty)
            {
                Size size = new Size(50, 50);
                Child.Size = size;
                ControlSize = size;
            }
            else
            {
                Child.Size = ControlSize;
            }

            Bitmap image = SetImage();

            if (String.IsNullOrEmpty(ControlData))
            {
                (Child as PictureBox).Image = image;
                ControlData = Utils.GetBase64FromImage(image);
            }
            else
            {
                (Child as PictureBox).Image = Utils.GetImageFromBase64(ControlData);
            }

            Child.LocationChanged += new EventHandler(Child_LocationChanged);
            Child.SizeChanged += new EventHandler(Child_SizeChanged);
        }

        protected virtual Bitmap SetImage() { return new Bitmap(0, 0); }
    }
}
