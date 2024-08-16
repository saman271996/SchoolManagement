﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class MainLayoutForm : Form
    {
        Form form;
        private bool menuexpand = false, acedmicexpand = false, accountingexpand;
        public MainLayoutForm()
        {
            InitializeComponent();
        }

        private void MainLayoutForm_Load(object sender, EventArgs e)
        {
            form = new AdminDashboard();
            form.TopLevel = false;
            MainPanel.Controls.Add(form);
            form.Show();

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            form.Hide();
            form = new AdminDashboard();
            form.TopLevel = false;
            MainPanel.Controls.Add(form);
            form.Show();
        }

        private void Accounting_Click(object sender, EventArgs e)
        {
            AccountingTransition.Start();
        }

        private void AccountingTransition_Tick(object sender, EventArgs e)
        {
            if (accountingexpand == false)
            {
                flowLayoutPanel3.Height += 40;
                if (flowLayoutPanel3.Height >= 120)
                {
                    AccountingTransition.Stop();
                    accountingexpand = true;
                }

            }
            else
            {
                flowLayoutPanel3.Height -= 40;
                if (flowLayoutPanel3.Height <= 50)
                {
                    AccountingTransition.Stop();
                    accountingexpand = false;
                }
            }
        }

        private void Acedmic_Click(object sender, EventArgs e)
        {
            AcedmicTransition.Start();
        }

        private void AcedmicTransition_Tick(object sender, EventArgs e)
        {
            if (acedmicexpand == false)
            {
                flowLayoutPanel1.Height += 40;
                if (flowLayoutPanel1.Height >= 240)
                {
                    AcedmicTransition.Stop();
                    acedmicexpand = true;
                }

            }
            else
            {
                flowLayoutPanel1.Height -= 40;
                if (flowLayoutPanel1.Height <= 40)
                {
                    AcedmicTransition.Stop();
                    acedmicexpand = false;
                }
            }
        }




        private void Student_Click(object sender, EventArgs e)
        {
            try
            {
                form = (StudentDetails)Application.OpenForms["StudentDetails"];
                if (form == null)
                {
                    form = new StudentDetails();
                }
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                form.TopLevel = false;
                form.Visible = true;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
                form.BringToFront();
                form.Show();

            }
            catch (Exception ex) { }

        }



        private void Parent_Click(object sender, EventArgs e)
        {
            form.Hide();
            form = new Parents();
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.Visible = true;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
            form.Show();
        }

        private void Teacher_Staff_Click(object sender, EventArgs e)
        {
            try
            {
                form = (StaffDetails)Application.OpenForms["StaffDetails"];
                if (form == null)
                {
                    form = new StaffDetails();
                }
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                form.TopLevel = false;
                form.Visible = true;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
                form.BringToFront();
                form.Show();

            }
            catch (Exception ex) { }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            form.Hide();
            form = new SubjectAcademic();
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.Visible = true;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
            form.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            form.Hide();
            form = new ClassAcademic();
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.Visible = true;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userclick_Click(object sender, EventArgs e)
        {
            menutransition.Start();
        }

        private void menutransition_Tick(object sender, EventArgs e)
        {
            if (menuexpand == false)
            {
                UserPanel.Height += 40;
                if (UserPanel.Height >= 120)
                {
                    menutransition.Stop();
                    menuexpand = true;
                }

            }
            else
            {
                UserPanel.Height -= 40;
                if (UserPanel.Height <= 40)
                {
                    menutransition.Stop();
                    menuexpand = false;
                }
            }
        }

    }
}
