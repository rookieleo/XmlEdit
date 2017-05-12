// -----------------------------------------------------------------------
// <copyright file="NewTable.cs" company="微软中国">
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
    /// 表格控件
    /// </summary>
    public class NewTable : NewBaseControl
    {
        public NewTable()
        {
            Child = new DataGridView();
            DataGridViewSet();
        }

        public override void Create()
        {
            base.Create();

            if (ControlSize == Size.Empty)
            {
                Size size = new Size(220, 50);
                Child.Size = size;
                ControlSize = size;
            }
            else
            {
                Child.Size = ControlSize;
            }
        }

        /// <summary>
        /// Add column to DataGridView
        /// </summary>
        private void DataGridViewSet()
        {
            using (DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn())
            {
                column1.ReadOnly = true;
                column1.HeaderText = "一";
                column1.DisplayIndex = 0;
                column1.Name = "colIdx";
                (Child as DataGridView).Columns.Add(column1);
            }

            using (DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn())
            {
                column2.ReadOnly = true;
                column2.HeaderText = "二";
                column2.DisplayIndex = 1;
                column2.Name = "colLevelSymbol";
                (Child as DataGridView).Columns.Add(column2);
            }

            // level image column
            //DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            //imgColumn.ReadOnly = true;
            //imgColumn.HeaderText = "四";
            //imgColumn.DisplayIndex = 3;
            //imgColumn.Name = "colLevelSymbol";
            //column.Width = 30;
            //(Child as DataGridView).Columns.Add(imgColumn);

            (Child as DataGridView).RowHeadersVisible = false;
            (Child as DataGridView).BackgroundColor = Color.White;
            (Child as DataGridView).BorderStyle = BorderStyle.None;
            (Child as DataGridView).CellEndEdit += new DataGridViewCellEventHandler(NewTable_CellEndEdit);

        }

        protected void NewTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ReportManage.ReportFactory.GetInstance().Change(this);
        }
    }
}
