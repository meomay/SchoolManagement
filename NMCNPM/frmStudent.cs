﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMCNPM
{
    public partial class frmStudent : Form
    {
        public delegate void FormCloseHandler();
        public event FormCloseHandler OnFormCloseEventArg;
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnFormCloseEventArg();
        }
    }
}
