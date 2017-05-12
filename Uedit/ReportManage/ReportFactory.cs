using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using Uedit.CustomerControl;
using Uedit.ReportEntity;

namespace Uedit.ReportManage
{
    public enum OperateType { No, NewReport, OpenReport, SaveReport, PreviewReport, CloseReport, AddControl }

    public sealed class ReportFactory
    {
        private static readonly ReportFactory rFactory = new ReportFactory();
        private XmlDocument mDoc = new XmlDocument();
        private List<NewBaseControl> ControlList = new List<NewBaseControl>();

        public OperateType CurrentOperate { get; set; }

        private ReportFactory() { }

        public static ReportFactory GetInstance() { return rFactory; }

        public void Excute(OperateType operateType, Control container = null, string fileName = "", int x = 0, int y = 0)
        {
            this.CurrentOperate = operateType;

            switch (operateType)
            {
                case OperateType.No:
                    break;
                case OperateType.NewReport:
                    CreateDefaultTemplate();
                    Display(container);
                    break;
                case OperateType.OpenReport:
                    AnalysisXmlFile(fileName);
                    Display(container);
                    break;
                case OperateType.SaveReport:
                    break;
                case OperateType.PreviewReport:
                    break;
                case OperateType.CloseReport:
                    Clean();
                    container.Controls.Clear();
                    container.Visible = false;
                    break;
                case OperateType.AddControl:
                    Add(fileName, container.PointToClient(new Point(x, y)));
                    Display(container);
                    break;
            }
        }

        public void Save(String filePath)
        {
            mDoc.Save(filePath);
            Config.FullPath = filePath;
        }

        private void Clean()
        {
            ControlList.Clear();
            mDoc = new XmlDocument();
            Config.ElementNodeStartNum = 13;
        }
        
        public void Remove(Control child, Control container)
        {
            int controlID = Convert.ToInt32(child.Tag);
            int count = container.Controls.Count;

            child.Dispose();
            foreach (Control control in container.Controls)
            {
                if (Convert.ToInt32(control.Tag) > controlID)
                    control.Tag = Convert.ToInt32(control.Tag) - 1;
            }

            ControlList.RemoveAt(controlID - 1);
            foreach (NewBaseControl control in ControlList)
            {
                if (control.ControlNum > controlID)
                    control.ControlNum -= 1;
            }

            XmlNode parentNode = mDoc.SelectSingleNode("//Page[@Num=1]");
            XmlNode beDeletNode = mDoc.SelectSingleNode("//element[@Num=" + controlID + "]");
            parentNode.RemoveChild(beDeletNode);
            foreach (XmlNode node in parentNode.ChildNodes)
            {
                if (Convert.ToInt32(node.Attributes["Num"].Value) > controlID)
                    node.Attributes["Num"].Value = (Convert.ToInt32(node.Attributes["Num"].Value) - 1).ToString();
            }

            Config.ElementNodeStartNum = (controlID >= Config.ElementNodeStartNum) ? Config.ElementNodeStartNum : Config.ElementNodeStartNum - 1;
        }

        public void Change(NewBaseControl baseControl)
        {
            XmlNode ChangeNode = mDoc.SelectSingleNode("//element[@Num=" + baseControl.ControlNum + "]");

            XmlNode position = ChangeNode.SelectSingleNode("position");
            position.Attributes["StartX"].Value = baseControl.ControlPosition.X.ToString();
            position.Attributes["StartY"].Value = baseControl.ControlPosition.Y.ToString();
            position.Attributes["Width"].Value = baseControl.ControlSize.Width.ToString();
            position.Attributes["Height"].Value = baseControl.ControlSize.Height.ToString();

            XmlNode data = ChangeNode.SelectSingleNode("data");
            data.InnerText = baseControl.ControlData;
        }

        private void CreateDefaultTemplate()
        {
            NodeBase DefaultNode = new NodeBase();
            DefaultNode.Name = "PdfTemplateConfiguration";
            DefaultNode.Attrs.Add("version", "1.0");
            DefaultNode.ChildNodes.Add(new NodePageFormat());
            DefaultNode.ChildNodes.Add(new NodeBase()
                                       {
                                           Name = "ReportContent",
                                           Attrs = new Dictionary<string, object> { { "pageNum", Properties.Resources.DefaultPageCount } },
                                           ChildNodes = new List<NodeBase> { new NodeFormat(), new NodePage() }
                                       });

            mDoc.AppendChild(mDoc.CreateXmlDeclaration("1.0", "utf-8", ""));
            mDoc.AppendChild(DefaultNode.Create(mDoc));

            Analysis();
        }

        private void AnalysisXmlFile(String filePath)
        {
            mDoc.Load(filePath);
            Analysis();
            Config.FullPath = filePath;
            Config.FileName = Path.GetFileNameWithoutExtension(filePath);
        }

        private void Add(String controlType, Point position)
        {
            NewBaseControl control = ControlFactory.GetInstance().CreateControl(controlType, position);
            ControlList.Insert(Config.ElementNodeStartNum - 1, control);

            NodeBase node = NodeFactory.GetInstance().CreateNode(control);
            XmlElement beInsertNode = node.Create(mDoc);

            XmlNode parentNode = mDoc.SelectSingleNode("//Page[@Num=1]");
            XmlNode previousNode = mDoc.SelectSingleNode("//element[@Num=" + (Config.ElementNodeStartNum - 1) + "]");
            parentNode.InsertAfter(beInsertNode, previousNode);

            Config.ElementNodeStartNum++;
        }

        private void Display(Control container)
        {
            foreach (NewBaseControl control in ControlList)
            {
                container.Controls.Add(control.Child);
                control.Child.BringToFront();
            }
        }

        private void Analysis()
        {
            foreach (XmlNode element in mDoc.SelectSingleNode("//Page").ChildNodes)
            {
                NewBaseControl newControl = ControlFactory.GetInstance().CreateControl(Util.Utils.GetElementType(element), Util.Utils.GetElementPosition(element));

                newControl.ControlNum = Util.Utils.GetElementNum(element);
                newControl.ControlType = Util.Utils.GetElementType(element);
                newControl.ControlSize = Util.Utils.GetElementSize(element);
                newControl.ControlData = Util.Utils.GetElementData(element);
                newControl.Create();

                ControlList.Add(newControl);
            }
        }
    }
}
