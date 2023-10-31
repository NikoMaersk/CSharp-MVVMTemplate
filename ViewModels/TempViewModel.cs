using NavigationTemplate.Utility;
using System.Windows;
using System.Windows.Input;

namespace NavigationTemplate.ViewModels
{
	internal class TempViewModel : ViewModelBase
	{
		public ICommand ChangePageCommand { get; set; }

		public TempViewModel() 
		{
			ChangePageCommand = new RelayCommand(() => { ((App)Application.Current).ChangeUserControl(typeof(TestViewModel)); });
		}
	}
}
