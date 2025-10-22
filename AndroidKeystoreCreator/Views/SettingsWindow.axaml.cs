
using Avalonia.Controls;
using AndroidKeystoreCreator.ViewModels;

namespace AndroidKeystoreCreator;

public partial class SettingsWindow : Window
{
    public SettingsWindow()
    {
        InitializeComponent();
        DataContext = new SettingsViewModel();
    }
}
