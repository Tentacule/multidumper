﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultidumperGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Font = SystemFonts.MessageBoxFont;
            splitContainer.SplitterDistance = splitContainer.Width / 2;

        }
     

        private void Form1_Resize(object sender, EventArgs e)
        {
            splitContainer.SplitterDistance = splitContainer.Width / 2;
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if ()
        }
    }
}
