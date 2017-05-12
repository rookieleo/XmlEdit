// -----------------------------------------------------------------------
// <copyright file="NodeFactory.cs" company="微软中国">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Uedit.ReportManage
{
    using System.Collections.Generic;
    using Uedit.CustomerControl;
    using Uedit.ReportEntity;
    using System;

    /// <summary>
    /// 节点工厂类.
    /// </summary>
    public class NodeFactory
    {
        private static readonly NodeFactory nFactory = new NodeFactory();

        private NodeFactory() { }

        public static NodeFactory GetInstance() { return nFactory; }

        public NodeBase CreateNode(NewBaseControl control)
        {
            String Key = Util.Utils.GetElementKey(control.ControlType);

            NodeBase element = new NodeBase();
            element.Name = "element";
            element.Attrs.Add("Num", control.ControlNum);
            element.Attrs.Add("Key", Key);
            element.Attrs.Add("Type", control.ControlType);
            element.Attrs.Add("Desc", "");
            element.ChildNodes.Add(new NodeFormat(control.ControlType));

            NodeBase position = new NodeBase();
            position.Name = "position";
            position.Content = "";
            position.Attrs = new Dictionary<string, object> 
                        { 
                            { "StartX", control.ControlPosition.X }, 
                            { "StartY", control.ControlPosition.Y }, 
                            { "Width",  control.ControlSize.Width }, 
                            { "Height", control.ControlSize.Height } 
                        };
            position.ChildNodes = null;

            if (control.ControlType.Contains("Active"))
                element.ChildNodes.Add(new NodeRequirement(Key));

            if (control.ControlType.Equals("Table"))
            {
                position.Attrs.Add("rows", "2");
                position.Attrs.Add("columns", "2");
                position.Attrs.Add("cellWidth", "1,1");
            }

            element.ChildNodes.Add(position);
            
            element.ChildNodes.Add(new NodeBase { Name = "data", Content = control.ControlData, Attrs = null, ChildNodes = null });

            return element;
        }
    }
}
