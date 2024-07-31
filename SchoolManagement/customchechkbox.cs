using MaterialSkin.Controls;
using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Windows.Forms;
using static SchoolManagement.Helper.Helper;

namespace SchoolManagement
{
    public partial class customchechkbox : Form
    {
        SchoolManagementEntities Db = new SchoolManagementEntities();
        public customchechkbox()
        {
            InitializeComponent();
        }
       
        private void customchechkbox_Load(object sender, EventArgs e)
        {
            var itemdata = Db.Subjects.Where(x => x.IsDelete != true).AsNoTracking().ToList();

            MaterialCheckbox selectAllCheckbox = new MaterialCheckbox();
            selectAllCheckbox.Text = "Select All";
            selectAllCheckbox.AutoSize = true;
            selectAllCheckbox.Click += materialCheckedListBox1_Click;
            materialCheckedListBox.Items.Add(selectAllCheckbox);

            foreach (var item in itemdata)
            {
                MaterialCheckbox csx = new MaterialCheckbox();
                csx.Text = item.SubjectName;
                csx.Tag = Convert.ToString(item.SubjectId);
                materialCheckedListBox.Items.Add(csx);
            }
            materialCheckedListBox.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            materialCheckedListBox.Visible = !materialCheckedListBox.Visible;
        }

        private void materialCheckedListBox1_Click(object sender, EventArgs e)
        {
            bool isChecked = ((MaterialCheckbox)sender).Checked;

            for (int i = 1; i < materialCheckedListBox.Items.Count; i++)
            {
                if (materialCheckedListBox.Items[i] is MaterialCheckbox checkbox)
                {
                    checkbox.Checked = isChecked;
                }
            }
        }
    }
}
