using DVLD_BusinessLayer;
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
    public partial class frmShowUserInfo : Form
    {
        private int _PersonID; private int _UserID;

        private ClsPeopleBusinessLayer _PersonBl = new ClsPeopleBusinessLayer();
        private ClsUserBusinessLayer _UserBl     = new ClsUserBusinessLayer();

        public frmShowUserInfo(int personID , int userID)
        {
            InitializeComponent();
            _PersonID = personID;
            _UserID = userID;
        }

        private async Task<ClsPersonAndUserInfo> BringThisPersonInfoAsUser(int personID,int userID)
        {
            var Person  = await _PersonBl.GetPersonByIDAsync(personID);
            var User     = await _UserBl.GetUserInfoByUserIDAsync(userID);

            return new ClsPersonAndUserInfo(Person, User);
        }

        private async Task LoadInformation()
        {
            ClsPersonAndUserInfo Result = await BringThisPersonInfoAsUser(_PersonID,_UserID);
            uctrlShowUserInfo1.LoadPersonAndUserInformation(Result.Person, Result.User);
        }

        private async void frmShowUserInfo_Load(object sender, EventArgs e)
        {
            await LoadInformation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    class ClsPersonAndUserInfo
    {
        public ClsPerson Person { get; private set; } 
        public ClsUser User { get; private set; } 

        public ClsPersonAndUserInfo(ClsPerson person, ClsUser user)
        {
            Person = person;
            User = user;
        }
    }
}
