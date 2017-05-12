using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Drawing;
using System.Reflection;
using System.Collections;

namespace Uedit
{
    public class Node
    {
        public string Content;
        public List<object> Attrs = new List<object>();
        public List<object> ChildNodes = new List<object>();

        public Node(string content, List<object> attrs, List<object> childNodes)
        {
            this.Content = content;
            this.Attrs = attrs;
            this.ChildNodes = childNodes;
        }
    }

    public class NodePdfTemplateConfiguration
    {
        public string Version;
        public NodePageFormat PageFormat { get; set; }
        public NodeReportContent ReportContent { get; set; }

        public NodePdfTemplateConfiguration() { this.Version = "1.0"; this.PageFormat = new NodePageFormat(); this.ReportContent = new NodeReportContent(); }
        public NodePdfTemplateConfiguration(NodePageFormat pageFormat, NodeReportContent reportContent) { this.PageFormat = pageFormat; this.ReportContent = reportContent; }
    }

    public class NodePageFormat
    {
        public NodeFormatName FormatName { get; set; }
        public NodePageMargin PageMargin { get; set; }

        public NodePageFormat()
        {
            this.FormatName = new NodeFormatName();
            this.PageMargin = new NodePageMargin();
        }
        public NodePageFormat(NodeFormatName formatName, NodePageMargin pageMargin)
        {
            this.FormatName = formatName;
            this.PageMargin = pageMargin;
        }
    }
    public class NodeFormatName { public string Name; public NodeFormatName() { this.Name = "A4"; } public NodeFormatName(string name) { this.Name = name; } }
    public class NodePageMargin
    {
        public string Unit;
        public float MarginTop;
        public float MarginBottom;
        public float MarginLeft;
        public float MarginRight;
        public NodePageMargin()
        {
            this.Unit = "cm";
            this.MarginTop = this.MarginBottom = this.MarginLeft = this.MarginRight = 1.5f;
        }
        public NodePageMargin(string unit, float marginTop, float marginBottom, float marginLeft, float marginRight)
        {
            this.Unit = unit;
            this.MarginTop = marginTop;
            this.MarginBottom = marginBottom;
            this.MarginLeft = marginLeft;
            this.MarginRight = marginRight;
        }
    }

    public class NodeReportContent
    {
        public int PageNum;
        public NodeFormat Format { get; set; }
        public List<NodePage> PageList { get; set; }

        public NodeReportContent()
        {
            this.PageNum = 1;

            this.Format = new NodeFormat();

            this.PageList = new List<NodePage>();
            this.PageList.Add(new NodePage());
        }
        public NodeReportContent(int pageNum, NodeFormat format, List<NodePage> pageList)
        {
            this.PageNum = pageNum;

            this.Format = format;

            this.PageList = pageList;
        }
    }
    public class NodeFormat
    {
        public int FontSize;
        public int LineWidth;
        public string FontName;
        public int Rotate;
        public string Color;

        public NodeFormat() { this.FontSize = 10; this.FontName = "宋体"; this.Rotate = 0; }
        public NodeFormat(string elementType)
        {
            var method = typeof(NodeFormat).GetMethod("InitProperty" + elementType);
            method.Invoke(this, null);
        }
        public NodeFormat(int fontSize, int lineWidth, string fontName, int rotate, string color)
        {
            this.FontSize = fontSize;
            this.LineWidth = lineWidth;
            this.FontName = fontName;
            this.Rotate = rotate;
            this.Color = color;
        }
        public void InitPropertytext()
        {
            this.FontSize = 10;
        }
        public void InitPropertyactiveText()
        {
            this.FontSize = 12;
        }
        public void InitPropertyimage()
        {
            this.Rotate = 0;
        }
        public void InitPropertyactiveImage()
        {
            this.Rotate = 0;
        }
        public void InitPropertybackgroundImage()
        {
            this.Rotate = 0;
        }
        public void InitPropertyline()
        {
            this.Rotate = 0; this.LineWidth = 1; this.Color = "definegreen";
        }
    }
    public class NodePage
    {
        public int Num;
        public List<NodeElement> ElementList { get; set; }

        public NodePage()
        {
            this.Num = 1;
            this.ElementList = new List<NodeElement>();

            for (int i = 0; i < Config.DefaultElementNumList.Length; i++)
            {
                NodeElement element = new NodeElement
                {
                    Num = Config.DefaultElementNumList[i],
                    Key = Config.DefaultElementKeyList[i],
                    Type = Config.DefaultElementTypeList[i],
                    Desc = Config.DefaultElementDescList[i],
                    Data = new NodeData(Config.DefaultElementDataList[i]),
                    Format = new NodeFormat(Config.DefaultElementTypeList[i]),
                    Position = Config.DefaultElementPositionList[i]
                };
                if (Config.DefaultElementKeyList[i].Substring(0, 1) != "1")
                    element.Requirement = new NodeRequirement(Config.DefaultElementKeyList[i].Substring(0, 1));
                ElementList.Add(element);
            }
        }
        public NodePage(int num, List<NodeElement> elementList)
        {
            this.Num = num;
            this.ElementList = elementList;
        }
    }
    public class NodeElement
    {
        public int Num;
        public string Key;
        public string Type;
        public string Desc;

        public NodeData Data { get; set; }
        public NodeFormat Format { get; set; }
        public NodePosition Position { get; set; }
        public NodeRequirement Requirement { get; set; }

        public NodeElement() { }
        public NodeElement(int num, string key, string type, string desc, NodeData data, NodeFormat format, NodePosition position, NodeRequirement requirement)
        {
            this.Num = num;
            this.Key = key;
            this.Type = type;
            this.Desc = desc;
            this.Data = data;
            this.Format = format;
            this.Position = position;
            this.Requirement = requirement;
        }
    }
    public class NodeData { public string Content; public NodeData(string content) { this.Content = content; } }
    public class NodePosition
    {
        public int StartX;
        public int StartY;
        public int Width;
        public int Height;
        public NodePosition() { }
        public NodePosition(int startX, int startY, int width, int height)
        {
            this.StartX = startX;
            this.StartY = startY;
            this.Width = width;
            this.Height = height;
        }
    }
    public class NodeRequirement
    {
        public NodeCondition Condition { get; set; }

        public NodeRequirement(string firstWordOfKey)
        {
            Condition = new NodeCondition(firstWordOfKey);
        }
        public NodeRequirement(NodeCondition condition)
        {
            this.Condition = condition;
        }
    }
    public class NodeCondition
    {
        public string StartTime;
        public string EndTime;
        public string Type;
        public bool Patient;
        public bool MeasureRecord;

        public NodeCondition(string firstWordOfKey)
        {
            var method = typeof(NodeCondition).GetMethod("InitProperty" + firstWordOfKey);
            method.Invoke(this, null);
        }
        public NodeCondition(string startTime, string endTime, string type, bool patient, bool measureRecord)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Type = type;
            this.Patient = patient;
            this.MeasureRecord = measureRecord;
        }
        public void InitProperty2()
        {
            this.Type = "patientInfo"; this.Patient = true;
        }
        public void InitProperty3()
        {
            this.Type = "measureInfo"; this.MeasureRecord = true;
        }
        public void InitProperty4()
        {
            this.Type = "measureInfo"; this.MeasureRecord = true; StartTime = ""; EndTime = "";
        }
        public void InitProperty5()
        {
            this.Type = "healthAdvice"; this.Patient = true;
        }
        public void InitProperty7()
        {
            this.Type = "doctorInfo"; this.MeasureRecord = true;
        }
        public void InitProperty8()
        {
            this.Type = "printInfo"; this.Patient = true;
        }
    }
}
