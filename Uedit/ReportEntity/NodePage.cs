// -----------------------------------------------------------------------
// <copyright file="NodePage.cs" company="LeoEmpire">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Uedit.ReportEntity
{
    using System.Collections.Generic;

    /// <summary>
    /// Page节点
    /// </summary>
    public class NodePage : NodeBase
    {
        public NodePage()
        {
            Name = "Page";
            Attrs.Add("Num", "1");
            for (int i = 0; i < Config.DefaultElementNumList.Length; i++)
            {
                Dictionary<string, object> childAttrs = new Dictionary<string, object>();
                childAttrs.Add("Num", Config.DefaultElementNumList[i]);
                childAttrs.Add("Key", Config.DefaultElementKeyList[i]);
                childAttrs.Add("Type", Config.DefaultElementTypeList[i]);
                childAttrs.Add("Desc", Config.DefaultElementDescList[i]);

                List<NodeBase> childChildNodes = new List<NodeBase>();
                childChildNodes.Add(new NodeFormat(Config.DefaultElementTypeList[i]));
                childChildNodes.Add(Config.DefaultElementPositionList[i]);
                if (Config.DefaultElementKeyList[i].Substring(0, 1) != "1")
                    childChildNodes.Add(new NodeRequirement(Config.DefaultElementKeyList[i]));
                childChildNodes.Add(new NodeBase { Name = "data", Content = Config.DefaultElementDataList[i], Attrs = null, ChildNodes = null });

                ChildNodes.Add(new NodeBase { Name = "element", Content = "", Attrs = childAttrs, ChildNodes = childChildNodes });
            }
        }
    }
}
