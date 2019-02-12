using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaApp.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeaApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MmenuView : MasterDetailPage
    {
		public MmenuView ()
		{
            IsPresented = false;
            InitializeComponent ();
            BindingContext = new MmenuViewModelcs();
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            IsPresented = true;
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            IsPresented = false;
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {

        }
    }
}