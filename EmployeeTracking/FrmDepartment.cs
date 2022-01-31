using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace EmployeeTracking
{
    public partial class FrmDepartment : Form
    {
        public FrmDepartment()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtDepartment.Text.Trim() == "")
            {
                MessageBox.Show("Please Fill the field !!");
            }
            else
            {
                DEPARTEMENT department = new DEPARTEMENT();
                department.Department = txtDepartment.Text;
                BLL.DepartmentBLL.addDepartment(department);
                MessageBox.Show("New Departement was Insert SuccessFully");
            }
               

        }
    }
}
