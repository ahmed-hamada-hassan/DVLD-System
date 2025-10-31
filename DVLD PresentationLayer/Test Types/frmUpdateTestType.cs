using DVLD_BusinessLayer.ApplicationsBL;
using DVLD_BusinessLayer.TestTypes;
using DVLD_PresentationLayer.Applications;
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

namespace DVLD_PresentationLayer.Test_Types
{
    public partial class frmUpdateTestType : Form
    {
        ClsTestTypesBusinessLayer _TestTypeBL = new ClsTestTypesBusinessLayer();
        private int _TestTypeID;
        public frmUpdateTestType(int testTypeID)
        {
            InitializeComponent();
            _TestTypeID = testTypeID;
        }

        private async Task FillFormWithData()
        {
            ClsTestType TestType = await _TestTypeBL.GetTestTypeByIDAsync(_TestTypeID);
            lbIDResult.Text = TestType.TestTypeID.ToString();
            txtTitle.Text = TestType.TestTypeTitle.ToString();
            txtDescription.Text = TestType.TestTypeDescription.ToString();
            txtFees.Text = TestType.TestTypeFees.ToString();
        }

        private void CheckTextBox(TextBox txt, string Pattern, string Error, string FieldName, ErrorProvider ErrorProvider)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                ErrorProvider.SetError(txt, $"This field {FieldName} is required");
                txt.BackColor = Color.LightPink;
                txt.Focus();
                return;
            }
            if (!Regex.IsMatch(txt.Text, Pattern))
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
            CheckTextBox(txtTitle, @"^[A-Za-z0-9\-() ]{3,150}$", "Invalid Application Type Title.Title must be 3–150 characters long and can contain only",
             "Title", errorProvider1);
        }

        private void txtFees_Leave(object sender, EventArgs e)
        {
            CheckTextBox(txtFees, @"^\d+(\.\d{1,4})?$", "Invalid Fees value.Fees must be a positive number",
             "Fees", errorProvider1);
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            CheckTextBox(txtDescription, @"^(?!\s)([A-Za-z0-9.,'()\- ]{5,500})(?<!\s)$",
            "Description must be 5–500 characters, can include letters, numbers, spaces, and basic punctuation (.,-()), " +
            "and cannot start or end with spaces.",
             "Description", errorProvider1);
        }

        private bool IsValid()
        {
            if (errorProvider1.GetError(txtTitle) != string.Empty || errorProvider1.GetError(txtFees) != string.Empty 
                || errorProvider1.GetError(txtDescription) != string.Empty)
                return false;

            return true;
        }

        private ClsTestType GetTestTypeInfo()
        {
            return new ClsTestType
            {
                TestTypeID = Convert.ToInt32(lbIDResult.Text),
                TestTypeTitle = Convert.ToString(txtTitle.Text),
                TestTypeFees = Convert.ToDecimal(txtFees.Text),
                TestTypeDescription = Convert.ToString(txtDescription.Text),
            };
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            {
                MessageBox.Show("Invalid Information! , Complete you information", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure want to update this test Type info ?", "Update Test Type",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ClsTestType NewTestType = GetTestTypeInfo();
                if (await _TestTypeBL.UpdateTestTypeAsync(NewTestType))
                {
                    MessageBox.Show("Test Type updated successfully", "Successfully Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = false;
                    if (Owner is frmManageTestTypes parentForm)
                    {
                        await parentForm.PopulateDataGridViewTestTypes();
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("Test Type updated failed", "Failed Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Test Type updated canceled", "Canceled Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private async void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            await FillFormWithData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
