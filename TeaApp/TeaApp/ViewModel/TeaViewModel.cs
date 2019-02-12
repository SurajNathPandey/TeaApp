using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TeaApp.View;
using Xamarin.Forms;



namespace TeaApp.ViewModel
{
    public class TeaViewModel : BaseClassViewModel
    {
        
        private string userid { get; set; }
        public string UserID
        {
            get
            {
                return userid;
            }
            set
            {
                userid = value;
            }
        }
        private string password { get; set; }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }

        }

        public ICommand button { get; set; }
        public TeaViewModel()
        {

            
            button = new Command(show);
           async void show()
            {
               
                if (UserID == "" && Password == "")
                {
                    await App.Current.MainPage.DisplayAlert
                        ("login user", "enter ID and password", "Cancel");
                }
                else if (UserID == "suljit" && Password == "abc123")
                {
                    await App.Current.MainPage.Navigation.PushModalAsync(new MmenuView());
                }
                else if (UserID != "suljit" && Password != "abc123")
                {
                    await App.Current.MainPage.DisplayAlert("user faild", "write corect ID", "Cancel");
                }
            }

        }
        
    }
}
    
    
           
