﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EQEmu_Patcher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try {
                if (!UtilityLibrary.IsEverquestDirectory()) {
                    MessageBox.Show("Rawr");
                }
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show("You need to run this program with Administrative Privileges");
            }

        }
    }
}