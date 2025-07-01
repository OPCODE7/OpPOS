using OpPOS.Config;
using OpPOS.Views;
using OpPOS.Views.Administration.Audit;
using OpPOS.Views.Administration.Configuration;
using OpPOS.Views.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpPOS.Views
{
    public partial class Dashboard : Form
    {
        Helpers.Helper h = new Helpers.Helper();
        PermissionManager permissionManager = new PermissionManager();
        public Dashboard()
        {
            InitializeComponent();
           

            BtnConfig.ForeColor = Color.White;

            // Suscribir al evento Click
            BtnConfig.DropDownOpened += BtnConfig_DropDownOpened;
            BtnConfig.DropDownClosed += BtnConfig_DropDownClosed;
        }

        private void HideForms()
        {
            List<Form> form = Application.OpenForms.Cast<Form>().ToList().Where(x => x.Name != "Dashboard").ToList();
            form.ForEach(x => x.Hide());
        }

        private void BtnBillRanges_Click(object sender, EventArgs e)
        {
            HideForms();

            FrmBillRange frmBillRanges = new FrmBillRange();
            frmBillRanges.MdiParent = this;
            frmBillRanges.Show();
        }

       

       

        private void PbxLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PbxLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.ShowDialog();
        }

        private void BtnConfig_DropDownClosed(object sender, EventArgs e)
        {
            BtnConfig.ForeColor = Color.White;
            changeImageToolStripDropdownButton("configuration.png", BtnConfig);
        }

        private void BtnConfig_DropDownOpened(object sender, EventArgs e)
        {
            BtnConfig.ForeColor = Color.Black;
            changeImageToolStripDropdownButton("configuration-32px-black.png", BtnConfig);
            
        }


       

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LblUserLogged.Text = User.userName;
            LblFecha.Text = DateTime.Now.ToLongDateString();
            LblRole.Text = User.roleName;
        }



        private void changeImageToolStripDropdownButton(string fileName, ToolStripDropDownItem dropdown)
        {
            string folderPath = Application.StartupPath;

            folderPath = Directory.GetParent(folderPath).FullName; 
            folderPath = Directory.GetParent(folderPath).FullName;
            folderPath = Path.Combine(folderPath, "Assets", "Icons");

            string pathImage = Path.Combine(folderPath, fileName);

            if (File.Exists(pathImage))
            {
                using (var imgTemp = Image.FromFile(pathImage))
                {
                    dropdown.Image = new Bitmap(imgTemp);
                }
            }
            else
            {
                h.MsgError("NO SE ENCONTRO NINGUNA IMAGEN: " + pathImage);
            }
        }

        private void BtnManageUsers_DropDownClosed(object sender, EventArgs e)
        {
            BtnManageUsers.ForeColor= Color.White;
            changeImageToolStripDropdownButton("user.png", BtnManageUsers);
        }

        private void BtnManageUsers_DropDownOpened(object sender, EventArgs e)
        {
            BtnManageUsers.ForeColor = Color.Black;
            changeImageToolStripDropdownButton("user-config-black.png", BtnManageUsers);

        }

        private void BtnReports_DropDownClosed(object sender, EventArgs e)
        {
            BtnReports.ForeColor = Color.White;
            changeImageToolStripDropdownButton("report.png", BtnReports);

        }

        private void BtnReports_DropDownOpened(object sender, EventArgs e)
        {
            BtnReports.ForeColor = Color.Black;
            changeImageToolStripDropdownButton("report-black.png", BtnReports);

        }

        private void BtnCompanyData_Click(object sender, EventArgs e)
        {
            HideForms();

            FrmCompany frmCompanyData = new FrmCompany();
            frmCompanyData.MdiParent = this;
            frmCompanyData.Show();

        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            HideForms();

            Users.FrmUsers frmUsers = new Users.FrmUsers();
            frmUsers.MdiParent = this;
            frmUsers.Show();

        }

        private void BtnRoles_Click(object sender, EventArgs e)
        {
            HideForms();
            Users.FrmRoles frmRoles = new Users.FrmRoles();
            frmRoles.MdiParent = this;
            frmRoles.Show();

        }

        private void BtnPermissions_Click(object sender, EventArgs e)
        {
            HideForms();
            Users.FrmPermissions frmPermissions = new Users.FrmPermissions();
            frmPermissions.MdiParent = this;
            frmPermissions.Show();

        }

        private void BtnUserPermissions_Click(object sender, EventArgs e)
        {
            HideForms();
            Users.FrmSetUserPermissions frmSetUserPermissions = new Users.FrmSetUserPermissions();
            frmSetUserPermissions.MdiParent = this;
            frmSetUserPermissions.Show();

        }

        private void BtnManageEmployees_DropDownClosed(object sender, EventArgs e)
        {
            BtnManageEmployees.ForeColor = Color.White;
            changeImageToolStripDropdownButton("team-management.png", BtnManageEmployees);

        }

        private void BtnManageEmployees_DropDownOpened(object sender, EventArgs e)
        {
            BtnManageEmployees.ForeColor = Color.Black;
            changeImageToolStripDropdownButton("team-management-black.png", BtnManageEmployees);

        }

        private void BtnLogs_DropDownClosed(object sender, EventArgs e)
        {
            BtnLogs.ForeColor = Color.White;
            changeImageToolStripDropdownButton("logbook.png", BtnLogs);
        }

        private void BtnLogs_DropDownOpened(object sender, EventArgs e)
        {
            BtnLogs.ForeColor = Color.Black;
            changeImageToolStripDropdownButton("logbook-black.png", BtnLogs);
        }

        private void BtnLogBook_Click(object sender, EventArgs e)
        {
            HideForms();
            FrmLogBookApp frmLogBook = new FrmLogBookApp();
            frmLogBook.MdiParent = this;
            frmLogBook.Show();

        }

        private void BtnEmployees_Click(object sender, EventArgs e)
        {
            HideForms();
            Employees.FrmEmployees frmEmployees = new Employees.FrmEmployees();
            frmEmployees.MdiParent = this;
            frmEmployees.Show();

        }

        private void BtnHoraries_Click(object sender, EventArgs e)
        {
            HideForms();
            Employees.FrmHorary frmHoraries = new Employees.FrmHorary();
            frmHoraries.MdiParent = this;
            frmHoraries.Show();

        }

        private void BtnJobPositions_Click(object sender, EventArgs e)
        {
            HideForms();
            Employees.FrmJobPositions frmJobPositions = new Employees.FrmJobPositions();
            frmJobPositions.MdiParent = this;
            frmJobPositions.Show();

        }

        private void BtnSalaries_Click(object sender, EventArgs e)
        {
            HideForms();
            Employees.FrmSalaries frmSalaries = new Employees.FrmSalaries();
            frmSalaries.MdiParent = this;
            frmSalaries.Show();

        }
    }
}




