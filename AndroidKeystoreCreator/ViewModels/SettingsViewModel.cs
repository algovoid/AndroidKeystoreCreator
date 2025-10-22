
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.IO;

namespace AndroidKeystoreCreator.ViewModels;

public partial class SettingsViewModel : ObservableObject
{
    [ObservableProperty] private int themeIndex;

    [RelayCommand]
    private void Save()
    {
        File.WriteAllText("theme.cfg", themeIndex.ToString());
    }
}
