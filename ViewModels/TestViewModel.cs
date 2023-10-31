using NavigationTemplate.Utility;
using System.Windows;
using System.Windows.Input;

namespace NavigationTemplate.ViewModels
{
	internal class TestViewModel : ViewModelBase
	{
		public ICommand ChangePageCommand { get; set; }

		public TestViewModel()
		{
			ChangePageCommand = new RelayCommand(ChangePage);
		}

		private void ChangePage()
		{
			((App)Application.Current).ChangeUserControl(typeof(TempViewModel));
		}
	}
}
