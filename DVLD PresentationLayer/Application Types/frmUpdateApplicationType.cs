using DVLD_BusinessLayer.ApplicationsBL;
using DVLD_PresentationLayer.Application_Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications
{
    public partial class frmUpdateApplicationType : Form
    {
        ClsApplicationTypesBusinessLayer _AppBL = new ClsApplicationTypesBusinessLayer();
        private int _AppID;
        public frmUpdateApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();
            _AppID = ApplicationTypeID;
        }

        private async Task FillFormWithData()
        {
            ClsApplicationType ApplicationType = await _AppBL.GetApplicationTypeByIDAsync(_AppID);
            lbIDResult.Text = ApplicationType.ApplicationID.ToString();
            txtTitle.Text = ApplicationType.ApplicationName.ToString();
            txtFees.Text = ApplicationType.ApplicationFees.ToString();
        }

        private async void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
            await FillFormWithData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckTextBox(TextBox txt,string Pattern,string Error,string FieldName,ErrorProvider ErrorProvider)
        {
            if(string.IsNullOrEmpty(txt.Text))
            {
                ErrorProvider.SetError(txt, $"This field {FieldName} is required");
                txt.BackColor = Color.LightPink;
                txt.Focus();
                return;
            }
            if(!Regex.IsMatch(txt.Text, Pattern))
            {
                ErrorProvider.SetError(txt, Error);
                txt.BackColor = Color.LightPink;
                txt.Focus();
                return;
            }
            ErrorProvider.SetError(txt, string.Empty);
            txt.BackColor = Color.White;
        }

        private void txtTitle_Leave(object sender, EventArgs e)
        {
            CheckTextBox(txtTitle, @"^[A-Za-z0-9\- ]{3,150}$", "Invalid Application Type Title.Title must be 3–150 characters long and can contain only",
                         "Title", errorProvider1);
        }

        private void txtFees_Leave(object sender, EventArgs e)
        {
            CheckTextBox(txtFees, @"^\d+(\.\d{1,4})?$", "Invalid Fees value.Fees must be a positive number",
                         "Fees", errorProvider1);
        }

        private bool IsValid()
        {
            if (errorProvider1.GetError(txtTitle) != string.Empty || errorProvider1.GetError(txtFees) != string.Empty)
                return false;

            return true;
        }

        private ClsApplicationType GetApplicationTypeInfo()
        {
            return new ClsApplicationType
            {
                ApplicationID = Convert.ToInt32(lbIDResult.Text),
                ApplicationName = Convert.ToString(txtTitle.Text),
                ApplicationFees = Convert.ToDecimal(txtFees.Text),
            };
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            {
                MessageBox.Show("Invalid Information! , Complete you information", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure want to update this application info ?", "Update Application",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ClsApplicationType NewApplication = GetApplicationTypeInfo();
                if (await _AppBL.UpdateApplicationTypeInfoAsync(NewApplication))
                {
                    MessageBox.Show("Application updated successfully","Successfully Update",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    btnSave.Enabled = false;
                    if (Owner is frmManageApplicationTypes parentForm)
                    {
                        await parentForm.PopulateDataGridViewForApplicationTypes();
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("Application updated failed", "Failed Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Application updated canceled", "Canceled Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        
        }
    }
}
