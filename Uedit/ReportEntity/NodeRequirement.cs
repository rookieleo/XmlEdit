// -----------------------------------------------------------------------
// <copyright file="NodeRequirement.cs" company="LeoEmpire">
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
    /// requirement节点
    /// </summary>
    public class NodeRequirement : NodeBase
    {
        public NodeRequirement() { }
        public NodeRequirement(String key)
        {
            Name = "requirement";

            String firstWord = key.Substring(0, 1);

            Dictionary<string, object> childAttrs = new Dictionary<string, object>();

            switch (firstWord)
            {
                case "1":
                case "2":
                    childAttrs.Add("Type", "patientInfo");
                    childAttrs.Add("Patient", "true");
                    break;
                case "3":
                    childAttrs.Add("Type", "measureInfo");
                    childAttrs.Add("MeasureRecord", "true");
                    break;
                case "4":
                    childAttrs.Add("Type", "measureInfo");
                    childAttrs.Add("MeasureRecord", "true");
                    childAttrs.Add("StartTime", "");
                    childAttrs.Add("EndTime", "");
                    break;
                case "5":
                    childAttrs.Add("Type", "healthAdvice");
                    childAttrs.Add("Patient", "true");
                    break;
                case "6":
                    break;
                case "7":
                    childAttrs.Add("Type", "doctorInfo");
                    childAttrs.Add("MeasureRecord", "true");
                    break;
                case "8":
                    childAttrs.Add("Type", "printInfo");
                    childAttrs.Add("Patient", "true");
                    break;
            }
            ChildNodes.Add(new NodeBase { Name = "condition", Content = "", Attrs = childAttrs, ChildNodes = null });
        }
    }
}
