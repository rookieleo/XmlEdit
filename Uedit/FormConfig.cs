using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Uedit
{
    public partial class FormConfig : Form
    {
        private static readonly FormConfig FrmConfig = new FormConfig();
        public static FormConfig GetInstance() { return FrmConfig; }
        private FormConfig()
        {
            InitializeComponent();
        }
    }
}
