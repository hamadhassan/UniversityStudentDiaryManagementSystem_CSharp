﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityStudentDiaryManagementSystem
{
    public partial class frmHelpingMaterial : Form
    {
        public frmHelpingMaterial()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmHelpingMaterial_Load(object sender, EventArgs e)
        {
            cmbxType.SelectedIndex = 0; 
        }
    }
}
