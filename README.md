# C# - Model-ViewModel-Model template

## Features
- Navigation Service
- ViewModelBase with implementation of INotifyPropertyChanged
- Implementation of ICommand
- Style.xaml for styling in the Views

## Navigation
To use navigation in your WPF application you'll need to:
1. Register your ViewModels in the ServiceContainer in App.xaml.cs
2. To change to a new View call "Application.Current.ChangeUserControl(typeof(YourViewModel))"

#### Register
![image](https://github.com/NikoMaersk/CSharp-MVVMTemplate/assets/114466889/c1537b69-33fc-4567-ad80-2da3743d7165)

#### Command
![image](https://github.com/NikoMaersk/CSharp-MVVMTemplate/assets/114466889/e3b3cb11-baae-4c2e-802f-afc22cdaedc8)

