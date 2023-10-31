using NavigationTemplate.ViewModels;
using System.Windows;

namespace NavigationTemplate
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			((App)Application.Current).ContentControlRef = this.ContentContainer;
			((App)App.Current).ChangeUserControl(typeof(TempViewModel));
		}
	}
}
