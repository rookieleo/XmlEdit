using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Uedit
{
    public partial class FormName : Form
    {
        private static readonly FormName frmName = new FormName();

        public static FormName GetInstance() { return frmName; }

        private FormName()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
            else
            {
                Config.FileName = this.txtName.Text;
                this.txtName.Text = string.Empty;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
