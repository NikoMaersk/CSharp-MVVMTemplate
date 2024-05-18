# C# - Model-ViewModel-Model template

## Features
- Navigation Service
- ViewModelBase with implementation of INotifyPropertyChanged
- Implementation of ICommand
- Style.xaml for styling in your Views

## Navigation
To use navigation in your WPF application you'll need to:
1. Create your View and ViewModel. Important to name these with the suffixes "-View" and "-ViewModel" as these are used to match them together
2. Register your ViewModels in the ServiceContainer in App.xaml.cs
3. To change to a new View call "Application.Current.ChangeUserControl(typeof(YourViewModel))"

#### Register in ServiceContainer
![image](https://github.com/NikoMaersk/CSharp-MVVMTemplate/assets/114466889/c1537b69-33fc-4567-ad80-2da3743d7165)

#### Create Command in your ViewModel
![image](https://github.com/NikoMaersk/CSharp-MVVMTemplate/assets/114466889/e3b3cb11-baae-4c2e-802f-afc22cdaedc8)

#### Bind to Command in your View
![image](https://github.com/NikoMaersk/CSharp-MVVMTemplate/assets/114466889/3b902e34-f1f8-4f05-9fe7-3a882de2701a)

## Set initial View
You can specify the initial View, by changing the ChangeUserControl function call in MainWindow.xaml.cs to your ViewModel.

![image](https://github.com/NikoMaersk/CSharp-MVVMTemplate/assets/114466889/8e1c9ed6-2311-4efc-a8f1-fd75aabc5f2b)



