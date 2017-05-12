// -----------------------------------------------------------------------
// <copyright file="NewActiveText.cs" company="微软中国">
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

    /// <summary>
    /// 动态文本控件
    /// </summary>
    public class NewActiveText : NewBaseText
    {
        protected override String SetData()
        {
            Child.ForeColor = Color.Red;
            return "动文本";
        }
    }
}
