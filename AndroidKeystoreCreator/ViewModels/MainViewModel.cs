using System;
using AndroidKeystoreCreator.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AndroidKeystoreCreator.ViewModels;

public partial class MainViewModel : ViewModelBase
{
	private readonly KeystoreService _keystoreService = new();
	[ObservableProperty] private string statusMessage = "Ready";

	[RelayCommand]
	private void Generate()
	{
		try
		{
			var path = _keystoreService.GenerateKeystore();
			StatusMessage = $"Generated: {path}";
		}
		catch (Exception ex)
		{
			StatusMessage = $"Error: {ex.Message}";
		}
	}

	[RelayCommand]
	private void OpenSettings()
	{
		var settings = new SettingsWindow();
		settings.ShowDialog(App.Current!.ApplicationLifetime is Avalonia.Controls.ApplicationLifetimes.IClassicDesktopStyleApplicationLifetime d ? d.MainWindow : null);
	}
}
