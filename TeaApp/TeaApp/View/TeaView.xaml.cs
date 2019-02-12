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
	public partial class TeaView : ContentPage
	{
		public TeaView ()
		{
			InitializeComponent ();
            BindingContext = new TeaViewModel();
		}
	}
}