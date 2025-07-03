using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using OpPOS.Config;
using OpPOS.Controllers;
using OpPOS.Helpers;
using OpPOS.Models;
using OpPOS.Views.Reports.DataSets;
using OpPOS.Views.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpPOS.Views.Administration.Suppliers
{
    public partial class FrmSuppliers : Form
    {
        string moduleId = "SUP",codSupplier,rtn,email,phone,address,name;
        bool state,flagIsPaperBin;
        CorrelativesController correlativesController = new CorrelativesController();
        Helper h = new Helper();
        SupplierController sc = new SupplierController();
        LogBookAppController lac = new LogBookAppController();

        private void PbxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateData() == 0)
            {
                if (h.MsgQuestion(App.Msg0002) == "S")
                {
                    SetValues();
                    SUPPLIERS currentSupplier = sc.GetSupplier(TxtSupplierCode.Text.Trim());
                    string changes = "";
                    var separator = ", ";

                    if (currentSupplier.SUPPLIER_CODE != codSupplier)
                        changes += $"SUPPLIER_CODE: '{currentSupplier.SUPPLIER_CODE}' → '{codSupplier}'{separator}";

                    if (currentSupplier.SUPPLIER_RTN != rtn)
                        changes += $"SUPPLIER_DNI: '{currentSupplier.SUPPLIER_RTN}' → '{rtn}'{separator}";

                    if (currentSupplier.SUPPLIER_NAME != name)
                        changes += $"SUPPLIER_NAME: '{currentSupplier.SUPPLIER_NAME}' → '{name}'{separator}";

                    if (currentSupplier.SUPPLIER_PHONE != phone)
                        changes += $"SUPPLIER_PHONE: '{currentSupplier.SUPPLIER_PHONE}' → '{phone}'{separator}";

                    if (currentSupplier.SUPPLIER_EMAIL != email)
                        changes += $"SUPPLIER_EMAIL: '{currentSupplier.SUPPLIER_EMAIL}' → '{email}'{separator}";

                    if (currentSupplier.SUPPLIER_ADDRESS != address)
                        changes += $"SUPPLIER_ADDRESS: '{currentSupplier.SUPPLIER_ADDRESS}' → '{address}'{separator}";

                    if (currentSupplier.SUPPLIER_STATE != state)
                        changes += $"SUPPLIER_STATE: '{currentSupplier.SUPPLIER_STATE}' → '{state}'{separator}";



                    // Limpiar coma final
                    if (!string.IsNullOrEmpty(changes))
                        changes = changes.TrimEnd(',', ' ');

                    currentSupplier.SUPPLIER_CODE = codSupplier;
                    currentSupplier.SUPPLIER_RTN = rtn;
                    currentSupplier.SUPPLIER_NAME = name;
                    currentSupplier.SUPPLIER_PHONE = phone;
                    currentSupplier.SUPPLIER_EMAIL = email;
                    currentSupplier.SUPPLIER_ADDRESS = address;
                    currentSupplier.SUPPLIER_STATE = state;

                    if (sc.UpdateSupplier(currentSupplier) > 0)
                    {
                        string logDesc = $"El usuario {Config.User.userName} modificó al empleado {name}. Cambios: {changes}.";
                        await lac.saveLog(Config.User.userId, "Modificar", logDesc, moduleId, DateTime.Now);
                        h.MsgInfo(App.Msg0003);
                        startForm();
                    }
                    else
                    {
                        h.MsgError(App.Msg0017);
                    }
                }
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            startForm();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData() == 0)
            {
                SetValues();
                SUPPLIERS newSupplier = new SUPPLIERS
                {

                    SUPPLIER_CODE = codSupplier,
                    SUPPLIER_RTN = rtn,
                    SUPPLIER_NAME = name,
                    SUPPLIER_PHONE = phone,
                    SUPPLIER_ADDRESS = address,
                    SUPPLIER_EMAIL = email,
                    SUPPLIER_STATE= true,
                    USER_CODE= Config.User.userId
                };

                if (sc.SaveSupplier(newSupplier) > 0)
                {
                    await lac.saveLog(Config.User.userId, "Insertar", $"El usuario {Config.User.userName} insertó al proveedor {name}.", moduleId, DateTime.Now);
                    h.MsgInfo(App.Msg0001);
                    startForm();
                }
                else
                {
                    h.MsgError(App.Msg0015);
                }
            }
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            SUPPLIERS supplier = sc.GetSupplier(TxtSupplierCode.Text);

            supplier.IS_DEL = true;

            if (h.MsgQuestion(App.Msg0004) == "S")
            {
                if (sc.UpdateSupplier(supplier) > 0)
                {
                    await lac.saveLog(Config.User.userId, "Mover a papelera", $"El usuario {Config.User.userName} movió al empleado {supplier.SUPPLIER_NAME} a la papelera de reciclaje.", moduleId, DateTime.Now);
                    h.MsgInfo(App.Msg0005);
                    startForm();
                }
                else
                {
                    h.MsgError(App.Msg0016);
                }
            }
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetSuppliers(TxtSearch.Text.Trim(), flagIsPaperBin);
            }
        }

        private void PbxSearch_Click(object sender, EventArgs e)
        {
            GetSuppliers(TxtSearch.Text.Trim(), flagIsPaperBin);
        }

        private void PbxCancel_Click(object sender, EventArgs e)
        {
            TxtSearch.Clear();
            GetSuppliers("",flagIsPaperBin);        }

        private void BtnPaperbin_Click(object sender, EventArgs e)
        {
            startForm();
            flagIsPaperBin = true;
            PbxDestroy.Visible = true;
            PbxRecovery.Visible = true;
            BtnNew.Enabled = false;
            BtnCancel.Enabled = true;
            GetSuppliers("", true);
        }

        private async void PbxRecovery_Click(object sender, EventArgs e)
        {
            SUPPLIERS supplier = sc.GetSupplier(TxtSupplierCode.Text);
            supplier.IS_DEL = false;

            if (h.MsgQuestion(App.Msg0009) == "S")
            {
                if (sc.UpdateSupplier(supplier) > 0)
                {
                    await lac.saveLog(Config.User.userId, "Recuperar", $"El usuario {Config.User.userName} restauró al empleado {supplier.SUPPLIER_NAME} de la papelera.", moduleId, DateTime.Now);
                    h.MsgInfo(App.Msg0010);
                    startForm();
                }
                else
                {
                    h.MsgError(App.Msg0019);
                }
            }
        }

        private async void PbxDestroy_Click(object sender, EventArgs e)
        {
            if (h.MsgQuestion(App.Msg0007) == "S")
            {
                if (sc.DeleteSupplier(TxtSupplierCode.Text) > 0)
                {
                    await lac.saveLog(Config.User.userId, "Eliminar", $"El usuario {Config.User.userName} eliminó permanentemente al empleado {TxtSupplierName.Text}.", moduleId, DateTime.Now);
                    h.MsgInfo(App.Msg0008);
                    startForm();
                }
                else
                {
                    h.MsgError(App.Msg0015);
                }
            }
        }

        private void PbxPrint_Click(object sender, EventArgs e)
        {
            if (DgvSuppliers.Rows.Count > 0)
            {
                FrmDefaultRpt frmGenericRpt = new FrmDefaultRpt();


                DataTable dt = h.GetDataTableFromDataGridView(DgvSuppliers);

                string pathRpt = @"..\..\Views\Reports\RDLC\ReportSuppliers.rdlc";

                string dtsName = "DtsSuppliers";
                frmGenericRpt.fillRpt(dt, pathRpt, dtsName);
                frmGenericRpt.ShowDialog();
            }
            else
            {
                h.MsgError(Helpers.App.Msg0012);
            }
        }

        private void DgvSuppliers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvSuppliers.Rows.Count > 0)
            {
                SUPPLIERS supplier = sc.GetSupplier (DgvSuppliers.CurrentRow.Cells[0].Value.ToString());

                if (supplier != null)
                {
                    TxtRTN.Focus();
                    foreach (TextBox Txt in this.Controls.OfType<TextBox>())
                    {
                        Txt.Enabled = true;
                    }

                    MskPhoneNumber.Enabled = true;
                    TxtSupplierCode.Enabled = false;

                    foreach (ComboBox Cmb in this.Controls.OfType<ComboBox>())
                    {
                        Cmb.Enabled = true;
                    }

                    PbxRecovery.Enabled = PermissionManager.HasPermission("PAP", "Modificar");
                    PbxDestroy.Enabled = PermissionManager.HasPermission("PAP", "Eliminar");

                    TxtSupplierCode.Text = supplier.SUPPLIER_CODE;
                    TxtRTN.Text = supplier.SUPPLIER_RTN;
                    TxtSupplierName.Text = supplier.SUPPLIER_NAME;
                    MskPhoneNumber.Text = supplier.SUPPLIER_PHONE;
                    TxtEmail.Text = supplier.SUPPLIER_EMAIL;
                    TxtAddress.Text = supplier.SUPPLIER_ADDRESS;
                    CmbState.SelectedIndex = supplier.SUPPLIER_STATE ? 0 : 1;


                    BtnEdit.Enabled = PermissionManager.HasPermission(moduleId, "Modificar");
                    BtnDelete.Enabled = PermissionManager.HasPermission(moduleId, "Eliminar");
                    BtnEdit.Enabled = flagIsPaperBin ? false : true;
                    BtnDelete.Enabled = flagIsPaperBin ? false : true;
                    BtnNew.Enabled = false;
                    BtnSave.Enabled = false;
                    BtnCancel.Enabled = true;

                }
                else
                {
                    h.MsgError(App.Msg0011);
                }
            }
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {

            BtnCancel.Enabled = true;
            BtnSave.Enabled = true;
            BtnNew.Enabled = false;

            foreach (TextBox Txt in this.Controls.OfType<TextBox>())
            {
                Txt.Enabled = true;
                Txt.Clear();
            }

            CmbState.Enabled = false;
            CmbState.SelectedIndex = -1;

            MskPhoneNumber.Enabled = true;
            TxtSupplierCode.Enabled = false;
            TxtRTN.Focus();


            string nextId = moduleId + correlativesController.getNextId(moduleId);

            TxtSupplierCode.Text = nextId;
            BtnNew.Enabled = false;
        }

       

        public FrmSuppliers()
        {
            InitializeComponent();
        }

        private void FrmSuppliers_Load(object sender, EventArgs e)
        {
            startForm();

        }

        private void SetValues()
        {
            codSupplier = h.SanitizeStr(TxtSupplierCode.Text.Trim());
            rtn = h.SanitizeStr(TxtRTN.Text.Trim());
            name = h.SanitizeStr(TxtSupplierName.Text.Trim());
            address = h.SanitizeStr(TxtAddress.Text.Trim());
            email = h.SanitizeStr(TxtEmail.Text.Trim());
            phone = MskPhoneNumber.Text;
            state = CmbState.SelectedIndex == 0 ? true : false;
        }

        private void startForm()
        {
            flagIsPaperBin = false;
            GetSuppliers("",false);
            BtnNew.Enabled = PermissionManager.HasPermission(moduleId, "Crear");
            BtnDelete.Enabled = false;
            BtnSave.Enabled = false;
            BtnCancel.Enabled = false;
            BtnEdit.Enabled = false;
            BtnPaperbin.Enabled = PermissionManager.HasPermission("PAP", "Acceso");
            PbxRecovery.Visible = false;
            PbxDestroy.Visible = false;
            PbxDestroy.Enabled = false;
            PbxRecovery.Enabled = false;
            PbxPrint.Enabled = PermissionManager.HasPermission("RPT", "Crear");
            foreach (TextBox Txt in this.Controls.OfType<TextBox>())
            {
                Txt.Enabled = false;
                Txt.Clear();
            }

            CmbState.Enabled = false;
            CmbState.SelectedIndex = -1;
            MskPhoneNumber.Enabled = false;
            MskPhoneNumber.Clear();
            TxtRTN.Focus();
            TxtSearch.Enabled = true;
        }


        private int ValidateData()
        {
            int error = 0;

            if(TxtRTN.Text.Trim().Length > 0)
            {
                if (!Regex.Match(TxtRTN.Text.Trim(), RegexPatterns.RTNPattern).Success)
                {
                    h.MsgWarning("Ingresar RTN correctamente!");
                    TxtRTN.Focus();
                    error++;
                    return error;
                }
            }

            if (!Regex.Match(TxtSupplierName.Text, RegexPatterns.AlphabeticPattern).Success)
            {
                h.MsgWarning("Ingresar nombre correctamente. ¡Solo letras sin acentos!");
                TxtSupplierName.Focus();
                error++;
                return error;

            }

            if (!MskPhoneNumber.MaskFull)
            {
                h.MsgWarning("Ingresar número de teléfono correctamente.");
                MskPhoneNumber.Focus();
                error++;
                return error;
            }

            if (TxtEmail.Text.Trim().Length > 0)
            {
                if (!Regex.Match(TxtEmail.Text, RegexPatterns.EmailPattern).Success)
                {
                    h.MsgWarning("Ingresar correo electrónico correctamente.");
                    TxtEmail.Focus();
                    error++;
                    return error;
                }
            }

                

            if (!Regex.Match(TxtAddress.Text, RegexPatterns.AddressPattern).Success)
            {
                h.MsgWarning("Ingresar dirección correctamente. ¡Solo letras, números, puntos y guiones!");
                TxtAddress.Focus();
                error++;
                return error;
            }

           
            return error;

        }
        private void GetSuppliers(string searchFilter = "", bool isDel = false)
        {
            DgvSuppliers.Rows.Clear();
            List<SUPPLIERS> suppliers= sc.GetSuppliers(searchFilter, isDel);
            if (suppliers.Count == 0)
            {
                h.MsgInfo(Helpers.App.Msg0012);
                if (searchFilter != "")
                {
                    GetSuppliers("", isDel);
                }
                return;
            }

            foreach (SUPPLIERS supplier in suppliers) {
                DgvSuppliers.Rows.Add(supplier.SUPPLIER_CODE,supplier.SUPPLIER_RTN,supplier.SUPPLIER_NAME,supplier.SUPPLIER_ADDRESS,supplier.SUPPLIER_PHONE,supplier.SUPPLIER_EMAIL,Convert.ToDateTime(supplier.INSERTED_AT).ToString("dd/MM/yyyy"));
            }


        }
    }
}
