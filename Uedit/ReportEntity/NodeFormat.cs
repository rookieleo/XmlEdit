// -----------------------------------------------------------------------
// <copyright file="NodeFormat.cs" company="LeoEmpire">
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
    /// 格式节点类
    /// </summary>
    public class NodeFormat : NodeBase
    {
        public NodeFormat()
        {
            Name = "format";
            Attrs.Add("FontSize", "10");
            Attrs.Add("FontName", "宋体");
            Attrs.Add("Rotate", "0");
        }
        public NodeFormat(string elementType)
        {
            Name = "format";

            switch (elementType)
            {
                case "Text":
                    Attrs.Add("FontSize", "10");
                    break;
                case "ActiveText":
                    Attrs.Add("FontSize", "12");
                    break;
                case "Image":
                case "ActiveImage":
                case "BackGroundImage":
                    Attrs.Add("Rotate", "0");
                    break;
                case "Line":
                    Attrs.Add("Rotate", "0");
                    Attrs.Add("LineWidth", "1");
                    Attrs.Add("Color", "definegreen");
                    break;
                case "Table":
                    Attrs.Add("FontSize", "8");
                    Attrs.Add("FontName", "楷体");
                    Attrs.Add("BorderWidth", "2");
                    Attrs.Add("BorderColor", "black");
                    Attrs.Add("WidthAligned", "left");
                    Attrs.Add("HeightAligned", "left");
                    Attrs.Add("CellAlignedW", "left");
                    Attrs.Add("CellAlignedH", "left");
                    break;
            }
        }
    }
}
