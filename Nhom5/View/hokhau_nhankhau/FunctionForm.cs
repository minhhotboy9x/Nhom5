﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom5.View.hokhau_nhankhau
{
    public partial class FunctionForm : Form
    {
        Form parentForm;
        public FunctionForm()
        {
            InitializeComponent();
        }

        public void getFormRef(Form parentForm)
        {
            this.parentForm = parentForm;
        }

        private void FunctionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parentForm.Invoke((MethodInvoker)(() => this.parentForm.Enabled = true));
        }
    }
}
