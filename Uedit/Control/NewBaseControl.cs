using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Uedit.Util;
using Uedit.CustomerEvent;

namespace Uedit.CustomerControl
{
    public class NewBaseControl
    {
        protected MouseHook ControlMouseHook = new MouseHook();


        public Control Child { get; set; }
        public int ControlNum { get; set; }
        public Font ControlFont { get; set; }
        public Size ControlSize { get; set; }
        public String ControlType { get; set; }
        public String ControlData { get; set; }
        public Point ControlPosition { get; set; }


        public NewBaseControl()
        {
            Child = new Control();
        }

        protected void Child_SizeChanged(object sender, EventArgs e)
        {
            ControlSize = (sender as Control).Size;
            ReportManage.ReportFactory.GetInstance().Change(this);
        }

        protected void Child_LocationChanged(object sender, EventArgs e)
        {
            ControlPosition = (sender as Control).Location;
            ReportManage.ReportFactory.GetInstance().Change(this);
        }

        public virtual void Create()
        {
            Child.Tag = ControlNum;
            Child.Name = ControlType;
            Child.Location = ControlPosition;

            ControlMouseHook.AddEvent(Child);
        }
    }
}
