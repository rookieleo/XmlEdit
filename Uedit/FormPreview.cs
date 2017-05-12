using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Uedit
{
    public partial class FormPreview : Form
    {
        private static readonly FormPreview FrmPreview = new FormPreview();
        public static FormPreview GetInstance() { return FrmPreview; }
        private FormPreview()
        {
            InitializeComponent();
        }

        private void ReportPreview_Load(object sender, EventArgs e)
        {
        }

        private void ReportPreview_Shown(object sender, EventArgs e)
        {
        }

    }
}
