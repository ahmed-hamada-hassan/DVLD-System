using DVLD_BusinessLayer.PoepleBL;
using DVLD_BusinessLayer.UserBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Users
{
    public partial class uctrlShowUserInfo : UserControl
    {
        public uctrlShowUserInfo()
        {
            InitializeComponent();
        }

        public async void LoadPersonAndUserInformation(ClsPerson Person , ClsUser User)
        {
            await uCtrlShowPersonInfo1.LoadPersonInfo(Person);
            LoadUserLoginInformations(User);
        }

        private void LoadUserLoginInformations(ClsUser User)
        {
            lbUserIDResult.Text = User.UserID.ToString();
            lbUserNameResult.Text = User.UserName;
            lbIsActiveResult.Text = User.IsActive == true ? "True" : "False";
        }
    }
}
