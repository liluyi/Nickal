﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForm
{
    public partial class ExceptionBox : Form
    {
        public ExceptionBox(Exception ex)
        {
            InitializeComponent();
        }
        public static void HandleNotCatchedException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            ExceptionBox Handler = new ExceptionBox(e.Exception);

            Handler.ShowDialog();
        }

    }
}
