﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PharmasistDashboardForm : Form
    {
        public PharmasistDashboardForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserID = 0;
            Properties.Settings.Default.UserRole = null;
            SignInForm f7 = new SignInForm();
            f7.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddMedicineForm f9 = new AddMedicineForm();
            f9.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageMedicineForm f10 = new ManageMedicineForm();
            f10.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BuyMedicineForm f13 = new BuyMedicineForm();
            f13.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddPrescriptionForm f14 = new AddPrescriptionForm();
            f14.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ManagePrescriptionsForm f15 = new ManagePrescriptionsForm();
            f15.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            ServiceInitialize sinit = new ServiceInitialize();
            sinit.Show();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            ServiceManage sman = new ServiceManage();
            sman.Show();
        }

        private void PharmasistDashboardForm_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.UserRole == "Admin")
            {
                button11.Visible = true;
            }
            else
            {
                button11.Visible = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AdminstratorForm adm = new AdminstratorForm();
            adm.Visible = true;
            this.Hide();
        }
    }
}
