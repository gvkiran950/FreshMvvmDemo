using FreshMvvm;
using FreshMvvmExample.Model;
using FreshMvvmExample.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace FreshMvvmExample.PageModels
{
    public class UsersListPageModel : FreshBasePageModel
    {
        public List<Users> Users { get; set; }
        public UsersListPageModel()
        {

        }

        public override void Init(object initData)
        {
            base.Init(initData);
            Users = new List<Users>()
            {
                new Users{Name="xyz",PhoneNumber="1234678",Address="Kp"},
                new Users{Name="xyz1",PhoneNumber="1234678554",Address="Kp"},
                new Users{Name="xyz2",PhoneNumber="1234678",Address="Kp"},
                new Users{Name="xyz3",PhoneNumber="1234678",Address="Kp"},
                new Users{Name="xyz4",PhoneNumber="1234678",Address="Kp"}
            };
        }

        public Users SelectUser
        {
            get { return null; }
            set
            {
                CoreMethods.PushPageModel<UserPageModel>(value);
               // var page = new UserPage();
                //async () => await NavigationPage.PushAsync(page);
               //new PushAsync(UserPage)
            }
        }
    }
}
