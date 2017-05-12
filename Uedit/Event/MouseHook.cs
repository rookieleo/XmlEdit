using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Uedit.ReportManage;

namespace Uedit.CustomerEvent
{
    public class MouseHook
    {
        private bool IsMove = false;
        private Point m_StartPosition = new Point(0, 0);

        public void AddEvent(Control control)
        {
            control.MouseUp += new MouseEventHandler(Owner_MouseUp);
            control.MouseDown += new MouseEventHandler(Owner_MouseDown);
            control.MouseMove += new MouseEventHandler(Owner_MouseMove);
            control.MouseClick += new MouseEventHandler(Owner_MouseClick);
        }

        private void Owner_MouseDown(object sender, MouseEventArgs e)
        {
            IsMove = true;
            m_StartPosition = new Point(e.X, e.Y);
        }

        private void Owner_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMove)
            {
                int offsetX = e.X - m_StartPosition.X;
                int offsetY = e.Y - m_StartPosition.Y;
                Control control = (sender as Control);
                control.Left = (offsetX > 0) ? control.Left + offsetX : control.Left - Math.Abs(offsetX);
                control.Top = (offsetY > 0) ? control.Top + offsetY : control.Top - Math.Abs(offsetY);
            }
        }

        private void Owner_MouseUp(object sender, MouseEventArgs e)
        {
            Control control = (sender as Control);
            IsMove = false;
            control.Refresh();
            control.ResumeLayout();
        }

        private void Owner_MouseClick(object sender, MouseEventArgs e)
        {
            Control control = sender as Control;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    FormMain.GetInstance().ControlSelected(control);
                    break;
                case MouseButtons.Right:
                    ReportFactory.GetInstance().Remove(control, control.Parent);
                    break;
            }
        }
    }
}
