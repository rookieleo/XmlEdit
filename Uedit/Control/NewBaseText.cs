
// -----------------------------------------------------------------------
// <copyright file="NewBaseText.cs" company="微软中国">
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

    /// <summary>
    /// 文本控件基类
    /// </summary>
    public class NewBaseText : NewBaseControl
    {
        public NewBaseText()
        {
            Child = new Label();

            (Child as Label).TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }

        public override void Create()
        {
            base.Create();

            if (ControlFont == null)
            {
                Font font = new Font("SimSun", 9f);
                Child.Font = font;
                ControlFont = font;
            }
            else
            {
                Child.Font = ControlFont;
            }
            if (ControlSize == Size.Empty)
            {
                Size size = new Size(50, 30);
                Child.Size = size;
                ControlSize = size;
            }
            else
            {
                Child.Size = ControlSize;
            }
            if (String.IsNullOrEmpty(ControlData))
            {
                Child.Text = SetData();
                ControlData = SetData();
            }
            else
            {
                Child.Text = ControlData;
            }

            Child.TextChanged += new EventHandler(Child_TextChanged);
            Child.LocationChanged += new EventHandler(Child_LocationChanged);
            Child.SizeChanged += new EventHandler(Child_SizeChanged);
        }

        protected virtual String SetData() { return ""; }

        protected void Child_TextChanged(object sender, EventArgs e)
        {
            ControlData = (sender as Control).Text;
            ReportManage.ReportFactory.GetInstance().Change(this);
        }
    }
}
