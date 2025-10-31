using DVLD_PresentationLayer.Application_Types;
using DVLD_PresentationLayer.Applications;
using DVLD_PresentationLayer.Drivers;
using DVLD_PresentationLayer.Licenses;
using DVLD_PresentationLayer.Test_Types;
using DVLD_PresentationLayer.Tests;
using DVLD_PresentationLayer.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            People.frmManagePeople frmManagePeople = new People.frmManagePeople();
            frmManagePeople.ShowDialog();
        }
        private void signToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUsers manageUsers = new frmManageUsers();
            manageUsers.ShowDialog();
        }
        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(var ShowCurrentUserInfo = new frmShowUserInfo(Program.CurrentUser.PersonID, Program.CurrentUser.UserID))
            {
                ShowCurrentUserInfo.ShowDialog();
            }
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(var ChangeCurrentUserPassword = new frmChangePassword(Program.CurrentUser.UserID,Program.CurrentUser.PersonID))
            {
                ChangeCurrentUserPassword.ShowDialog();
            }
        }
        private void manageApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var ManageApplicationTypes = new frmManageApplicationTypes())
            {
                ManageApplicationTypes.ShowDialog();
            }
        }
        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var ManageTestTypes = new frmManageTestTypes())
            {
                ManageTestTypes.ShowDialog();
            }
        }
        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var NewLocalDrivingLicense = new frmNewLocalDrivingLicenseApplication())
            {
                NewLocalDrivingLicense.ShowDialog();
            }
        }
        private void localDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var LocalDrivingLicenseApplication = new frmManageLocalDrivingLicenseApplications())
            {
                LocalDrivingLicenseApplication.ShowDialog();
            }
        }
        private void internationalDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(var InternationalDirvingLicenseApplications = new frmManageInternationalLicenseApplications())
            {
                InternationalDirvingLicenseApplications.ShowDialog();
            }
        }
        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var NewInternationalDrivingLicense = new frmNewInternationalLicenseApplication())
            {
                NewInternationalDrivingLicense.ShowDialog();
            }
        }
        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var RenewDrivingLicense = new frmRenewDrivingLicense())
            {
                RenewDrivingLicense.ShowDialog();
            }
        }
        private void replacementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var ReplacementDrivingLicense = new frmReplacement())
            {
                ReplacementDrivingLicense.ShowDialog();
            }
        }
        private void detainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var DetainLicense = new frmDetainedLicense())
            {
                DetainLicense.ShowDialog();
            }
        }
        private void realseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var ReleaseDetainedLicense = new frmReleaseDetainedLicense())
            {
                ReleaseDetainedLicense.ShowDialog();
            }
        }
        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var ReleaseDetainLicense = new frmReleaseDetainedLicense())
            {
                ReleaseDetainLicense.ShowDialog();
            }
        }
        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var ManageDetainedLicenses = new frmListDetainedLicenses())
            {
                ManageDetainedLicenses.ShowDialog();
            }
        }
        private void reToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var RetakeTest = new frmRetakeTest())
            {
                RetakeTest.ShowDialog();
            }
        }
        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var ManageDrivers = new frmManageDrivers())
            {
                ManageDrivers.ShowDialog();
            }
        }
    }
}
