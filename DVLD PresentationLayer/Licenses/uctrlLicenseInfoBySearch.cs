using DVLD_BusinessLayer.License_BL;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Licenses
{
    public partial class uctrlLicenseInfoBySearch : UserControl
    {
        private readonly ClsLicensesBL _LicensesBL = new ClsLicensesBL();
        public ClsLicenseAndDriverInfo LicenseInfo { get; private set; }

        public event Action<ClsLicenseAndDriverInfo> LicenseInfoSearched;
        public event EventHandler OnSearchClicked;

        public uctrlLicenseInfoBySearch()
        {
            InitializeComponent();
        }

        private async Task<ClsLicenseAndDriverInfo> _SearchLicenseAsync()
        {
            return LicenseInfo = await _LicensesBL.GetLicenseInfoByLicenseIDAsync(Convert.ToInt32(txtLicenseID.Text.Trim()));
        }
        
        public async Task DoSearch()
        {
            if (string.IsNullOrEmpty(txtLicenseID.Text.Trim()))
            {
                MessageBox.Show("Please enter a License ID to search.", "Input Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var LicenseInfo = await _SearchLicenseAsync();
            if (LicenseInfo != null)
            {
                uctrlLicenseInfo1.DisplayData(LicenseInfo);
                LicenseInfoSearched?.Invoke(LicenseInfo);
                return;
            }
            else
            {
                MessageBox.Show("No license information found for the provided License ID.", "Search Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LicenseInfoSearched?.Invoke(null);
                return;
            }
        }
        public async Task LoadLicenseInfoByID(int LicenseID)
        {
            txtLicenseID.Text = LicenseID.ToString();
            var LicenseInfo = await _SearchLicenseAsync();
            if (LicenseInfo != null)
            {
                groupBox1.Enabled = false;
                uctrlLicenseInfo1.DisplayData(LicenseInfo);
                LicenseInfoSearched?.Invoke(LicenseInfo);
                return;
            }
            else
            {
                MessageBox.Show("No license information found for the provided License ID.", "Search Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LicenseInfoSearched?.Invoke(null);
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OnSearchClicked?.Invoke(this, EventArgs.Empty);
        }

        public async void uctrlLicenseInfoBySearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await DoSearch();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void uctrlLicenseInfoBySearch_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                txtLicenseID.Focus();
            }));
        }

        private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtLicenseID, "Please enter only numeric digits for License ID.");
                return;
            }
            errorProvider1.SetError(txtLicenseID, string.Empty);
        }
    }
}
