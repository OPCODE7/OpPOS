using OpPOS.Config;
using OpPOS.Controllers;
using OpPOS.DTO;
using OpPOS.Models;
using OpPOS.Views.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpPOS.Views.Administration.Audit
{
    public partial class FrmLogBookApp : Form
    {
        LogBookAppController logC = new LogBookAppController();
        Helpers.Helper h = new Helpers.Helper();
        public FrmLogBookApp()
        {
            InitializeComponent();
        }

        private void PbxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogBookApp_Load(object sender, EventArgs e)
        {
            startForm();
        }

        private void startForm()
        {
            getLogs("");
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();
                txt.Enabled = false;
            }
            TxtSearch.Focus();
            TxtSearch.Enabled = true;
            BtnCancel.Enabled = false;

            PbxPrint.Enabled = PermissionManager.HasPermission("RPT", "Crear");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            startForm();
        }

        private void getLogs(string searchFilter)
        {
            DgvLogs.Rows.Clear();
            List<LOGBOOK_APP> logs = logC.GetLogs(searchFilter);

            if (logs.Count() == 0)
            {
                h.MsgError(Helpers.App.Msg0012);
                if (String.IsNullOrEmpty(searchFilter))
                {
                    getLogs("");
                }
                return;
            }

            foreach (LOGBOOK_APP log in logs)
            {
                DgvLogs.Rows.Add(log.LOG_ID, log.LOG_DESCRIPTION, Convert.ToDateTime(log.INSERTED_AT).ToShortDateString());
            }
        }

        private void PbxSearch_Click(object sender, EventArgs e)
        {
            getLogs(TxtSearch.Text.Trim());
        }

        private void PbxCancel_Click(object sender, EventArgs e)
        {
            TxtSearch.Clear();
            getLogs("");
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) getLogs(TxtSearch.Text.Trim());
        }

        private void PbxPrint_Click(object sender, EventArgs e)
        {
            if (DgvLogs.Rows.Count > 0)
            {
                FrmDefaultRpt frmGenericRpt = new FrmDefaultRpt();


                DataTable dt = h.GetDataTableFromDataGridView(DgvLogs);

                string pathRpt = @"..\..\Views\Reports\RDLC\ReportLogs.rdlc";

                string dtsName = "DtsLogs";
                frmGenericRpt.fillRpt(dt, pathRpt, dtsName);
                frmGenericRpt.ShowDialog();
            }
            else
            {
                h.MsgError(Helpers.App.Msg0012);
            }
        }

        private void DgvLogs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvLogs.Rows.Count > 0)
            {
                int logId = Convert.ToInt32(DgvLogs.CurrentRow.Cells[0].Value);
                LogBookDTO log = logC.getLog(logId);
                if (log != null)
                {
                    TxtLogId.Text = log.LOG_ID.ToString();
                    TxtUser.Text = log.USER_CODE;
                    TxtAction.Text = log.ACTION_TYPE;
                    TxtModule.Text = log.MODULE_NAME;
                    TxtDescription.Text = log.LOG_DESCRIPTION;

                    BtnCancel.Enabled = true;
                }
            }

        }
    }
}
