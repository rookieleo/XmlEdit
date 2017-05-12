// -----------------------------------------------------------------------
// <copyright file="NodeCondition.cs" company="LeoEmpire">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Uedit.ReportEntity
{
    using System;
    using System.Collections.Generic;
    using System.Xml;
    using System.Xml.Linq;

    /// <summary>
    /// 所有节点类型的基类
    /// </summary>
    public class NodeBase
    {
        public String Name { get; set; }
        public String Content { get; set; }
        public List<NodeBase> ChildNodes { get; set; }
        public Dictionary<String, object> Attrs { get; set; }

        public NodeBase()
        {
            Name = "";
            Content = "";
            ChildNodes = new List<NodeBase>();
            Attrs = new Dictionary<String, object>();
        }

        public XmlElement Create(XmlDocument doc)
        {
            XmlElement element = doc.CreateElement(Name);
            
            element.InnerText = String.IsNullOrEmpty(Content) ? "" : Content;

            foreach (var attr in Attrs)
            {
                XmlAttribute xAttr = doc.CreateAttribute(attr.Key);
                xAttr.Value = attr.Value.ToString();
                element.Attributes.Append(xAttr);
            }

            foreach (NodeBase node in ChildNodes)
            {
                XmlElement child = doc.CreateElement(node.Name);
                element.AppendChild(node.Create(doc));
            }

            return element;
        }
    }
}
