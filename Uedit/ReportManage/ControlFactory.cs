// -----------------------------------------------------------------------
// <copyright file="ControlFactory.cs" company="微软中国">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Uedit.ReportManage
{
    using System;
    using Uedit.CustomerControl;
    using System.Drawing;

    public enum ControlType { Text, ActiceText, Image, ActiveImage, BackGroundImage, Table, Line }

    public class ControlFactory
    {
        private static readonly ControlFactory cFactory = new ControlFactory();

        private ControlFactory() { }

        public static ControlFactory GetInstance() { return cFactory; }

        public NewBaseControl CreateControl(String controlType, Point position)
        {
            NewBaseControl control = null;

            switch (controlType)
            {
                case "Text":
                    control = new NewText();
                    break;
                case "ActiveText":
                    control = new NewActiveText();
                    break;
                case "Image":
                    control = new NewImage();
                    break;
                case "ActiveImage":
                    control = new NewActiveImage();
                    break;
                case "BackGroundImage":
                    control = new NewBackGroundImage();
                    break;
                case "Line":
                    control = new NewLine();
                    break;
                case "Table":
                    control = new NewTable();
                    break;
            }
            control.ControlNum = Config.ElementNodeStartNum;
            control.ControlType = controlType;
            control.ControlPosition = position;
            control.Create();

            return control;
        }
    }
}
