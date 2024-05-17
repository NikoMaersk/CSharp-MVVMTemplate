# C# - Model-ViewModel-Model template

## Features
- Navigation Service
- ViewModelBase with implementation of INotifyPropertyChanged
- Implementation of ICommand
- Style.xaml for styling in the Views

# Navigation
To use navigation in your WPF application you'll need to:
1. Register your ViewModels in the ServiceContainer in App.xaml.cs
2. To change to a new View call "Application.Current.ChangeUserControl(typeof(YourViewModel))"
