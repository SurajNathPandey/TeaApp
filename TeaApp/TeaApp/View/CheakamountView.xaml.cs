using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TeaApp.ViewModel;
namespace TeaApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CheakamountView : ContentPage
	{
		public CheakamountView ()
		{
			InitializeComponent ();
            BindingContext = new CheaklocationViewModel();
		}
	}
}