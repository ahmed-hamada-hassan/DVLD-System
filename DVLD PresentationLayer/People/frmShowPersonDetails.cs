using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Licenses;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.People
{
    public partial class frmShowPersonDetails : Form
    {
        #region Fields
        private readonly int _personID;
        #endregion

        #region Constructors
        public frmShowPersonDetails()
        {
            InitializeComponent();
        }
        public frmShowPersonDetails(int personID) : this()
        {
            _personID = personID;
        }
        #endregion

        #region Private Methods
        private async Task LoadPersonAsync()
        {
            ClsPeopleBusinessLayer clsPeopleBusinessLayer = new ClsPeopleBusinessLayer();
            var person = await clsPeopleBusinessLayer.GetPersonByIDAsync(_personID);

            await uCtrlShowPersonInfo1.LoadPersonInfo(person);
        }
        #endregion

        #region Form's Event Handlers
        private async void frmShowPersonDetails_Load(object sender, EventArgs e)
        {
            await LoadPersonAsync();
        }
        private async void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.Owner is frmManagePeople ParentForm)
            {
                await ParentForm.RefreshPeopleDataGridView();
                Close();
                return;
            }
            if(this.Owner is frmListDetainedLicenses ParentForm2)
            {
                await ParentForm2.RefreshDetainedLicensesDataGridView();
                Close();
                return;
            }
            Close();
        }
        #endregion

    }
}
