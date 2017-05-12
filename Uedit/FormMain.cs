using System;
using System.ComponentModel;
using System.Windows.Forms;
using Uedit.ReportManage;

namespace Uedit
{
    public partial class FormMain : Form
    {
        private static readonly FormMain frmMain = new FormMain();

        private FormMain()
        {
            InitializeComponent();
        }

        public static FormMain GetInstance()
        {
            return frmMain;
        }

        public void ControlSelected(Control control)
        {
            this.pg_ControlProperty.SelectedObject = control;
        }

        private void lv_Tool_ItemDrag(object sender, ItemDragEventArgs e)
        {
            ((Control)sender).DoDragDrop((e.Item as ListViewItem).Text, DragDropEffects.Copy);
        }

        private void pContainer_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pContainer_DragDrop(object sender, DragEventArgs e)
        {
            ReportFactory.GetInstance().Excute(OperateType.AddControl, pContainer, e.Data.GetData(DataFormats.Text).ToString(), MousePosition.X, MousePosition.Y);
        }

        private void MenuItemClickEvent(object sender, EventArgs e)
        {
            switch ((sender as ToolStripMenuItem).Name)
            {
                case "ms_New":
                    FormName.GetInstance().ShowDialog();
                    if (FormName.GetInstance().DialogResult == System.Windows.Forms.DialogResult.OK)
                    {
                        ReportFactory.GetInstance().Excute(OperateType.NewReport, pContainer);
                        this.pContainer.Visible = true;
                        this.pg_ControlProperty.Visible = true;
                        this.ms_Save.Enabled = true;
                        this.ms_Close.Enabled = true;
                        this.ms_Setting.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("请输入文件名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    break;
                case "ms_Open":
                    OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "XML文件|*.xml|所有文件|*.*" };
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ReportFactory.GetInstance().Excute(OperateType.OpenReport, pContainer, openFileDialog.FileName);
                        pContainer.Visible = true;
                        pg_ControlProperty.Visible = true;
                    }
                    break;
                case "ms_Save":
                    switch (ReportFactory.GetInstance().CurrentOperate)
                    {
                        case OperateType.NewReport:
                            SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "XML文件|*.xml|所有文件|*.*" };
                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                ReportFactory.GetInstance().Save(saveFileDialog.FileName);
                            }
                            break;
                        case OperateType.OpenReport:
                            ReportFactory.GetInstance().Save(Config.FullPath);
                            break;
                    }
                    this.ms_Preview.Enabled = true;
                    break;
                case "ms_Preview":
                    FormPreview.GetInstance().ShowDialog();
                    break;
                case "ms_Close":
                    ReportFactory.GetInstance().Excute(OperateType.CloseReport, pContainer);
                    pg_ControlProperty.Visible = false;
                    pg_ControlProperty.SelectedObject = null;
                    this.ms_Save.Enabled = false;
                    this.ms_Close.Enabled = false;
                    this.ms_Setting.Enabled = false;
                    this.ms_Preview.Enabled = false;
                    break;
                case "ms_Setting":
                    FormConfig.GetInstance().ShowDialog();
                    break;
            }
        }
    }
}
