// -----------------------------------------------------------------------
// <copyright file="NewText.cs" company="微软中国">
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
    /// 静态文本控件
    /// </summary>
    public class NewText : NewBaseText
    {
        protected override String SetData()
        {
            return "静文本";
        }
    }
}
