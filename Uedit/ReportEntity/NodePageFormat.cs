// -----------------------------------------------------------------------
// <copyright file="NodePageFormat.cs" company="微软中国">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Uedit.ReportEntity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// PageFormat节点
    /// </summary>
    public class NodePageFormat : NodeBase
    {
        public NodePageFormat()
        {
            Name = "PageFormat";
            ChildNodes.Add(new NodeBase() { Name = "formatName", Content = Properties.Resources.DefaultPageFormat });
            ChildNodes.Add(new NodeBase()
            {
                Name = "pageMargin",
                Attrs = new Dictionary<string, object> 
                { 
                    { "unit", Properties.Resources.DefaultMarginUnit }, 
                    { "top", Properties.Resources.DefaultMarginTop }, 
                    { "bottom", Properties.Resources.DefaultMarginBottom }, 
                    { "left", Properties.Resources.DefaultMarginLeft }, 
                    { "right", Properties.Resources.DefaultMarginRight } 
                }
            });

        }
    }
}
