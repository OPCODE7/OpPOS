using Microsoft.Reporting.WinForms;
using OpPOS.Views.Reports.DataSets;
using OpPOS.Views.Reports.DataSets.DtsGetCompanyDataTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpPOS.Views.Reports
{
    public partial class FrmDefaultRpt : Form
    {
        public FrmDefaultRpt()
        {
            InitializeComponent();
        }

        

        public void fillRpt(DataTable dt, string rdlcPath, string dtsName)
        {
            ReportDataSource rds = new ReportDataSource(dtsName, dt);
            DtsGetCompanyData dsCompany = new DtsGetCompanyData();
            var adapterCompany = new SP_GET_COMPANY_DATATableAdapter();
            adapterCompany.Fill(dsCompany.SP_GET_COMPANY_DATA);

            ReportDataSource rdsCompany = new ReportDataSource("DtsGetCompanyData", (DataTable)dsCompany.SP_GET_COMPANY_DATA);

            RptGeneric.LocalReport.ReportPath = Path.GetFullPath(rdlcPath);
            RptGeneric.LocalReport.DataSources.Clear();
            RptGeneric.LocalReport.DataSources.Add(rdsCompany);
            RptGeneric.LocalReport.DataSources.Add(rds);
            RptGeneric.SetDisplayMode(DisplayMode.PrintLayout);
            RptGeneric.ZoomMode = ZoomMode.Percent;
            RptGeneric.ZoomPercent = 100;

            RptGeneric.RefreshReport();
        }

        private void PbxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDefaultRpt_Load(object sender, EventArgs e)
        {

            this.RptGeneric.RefreshReport();
        }
    }
}
