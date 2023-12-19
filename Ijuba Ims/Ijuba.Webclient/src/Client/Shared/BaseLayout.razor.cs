﻿using Ijuba.Webclient.Client.Infrastructure.Preferences;
using Ijuba.Webclient.Client.Infrastructure.Theme;
using MudBlazor;

namespace Ijuba.Webclient.Client.Shared;

public partial class BaseLayout
{
    private ClientPreference? _themePreference;
    private MudTheme _currentTheme = new LightTheme();
    private bool _themeDrawerOpen;
    private bool _rightToLeft;

    protected override async Task OnInitializedAsync()
    {
        _themePreference = await ClientPreferences.GetPreference() as ClientPreference;
        if (_themePreference == null) _themePreference = new ClientPreference();
        SetCurrentTheme(_themePreference);

        //Snackbar.Add("Like this boilerplate? ", Severity.Normal, config =>
        //{
        //    config.BackgroundBlurred = true;
        //    config.Icon = Icons.Custom.Brands.GitHub;
        //    config.Action = "Star us on Github!";
        //    config.ActionColor = Color.Primary;
        //    config.Onclick = snackbar =>
        //    {
        //        Navigation.NavigateTo("https://github.com/fullstackhero/blazor-wasm-boilerplate");
        //        return Task.CompletedTask;
        //    };
        //});
    }

    private MudTheme _theme = new();
    private string modeIcon => _isDarkMode ? Icons.Outlined.DarkMode : @Icons.Outlined.LightMode;
    private bool _isDarkMode;

    void ToggleDarkMode()
    {
        _isDarkMode = !_isDarkMode;
        _currentTheme = _isDarkMode ? new DarkTheme() : new LightTheme();
       // _currentTheme.Palette.Primary = themePreference.PrimaryColor;
       // _currentTheme.Palette.Secondary = themePreference.SecondaryColor;
       // _currentTheme.LayoutProperties.DefaultBorderRadius = $"{themePreference.BorderRadius}px";
      //  _currentTheme.LayoutProperties.DefaultBorderRadius = $"{themePreference.BorderRadius}px";
       // _rightToLeft = themePreference.IsRTL;
    }

    private async Task ThemePreferenceChanged(ClientPreference themePreference)
    {
        SetCurrentTheme(themePreference);
        await ClientPreferences.SetPreference(themePreference);
    }

    private void SetCurrentTheme(ClientPreference themePreference)
    {
        _currentTheme = themePreference.IsDarkMode ? new DarkTheme() : new LightTheme();
        _currentTheme.Palette.Primary = themePreference.PrimaryColor;
        _currentTheme.Palette.Secondary = themePreference.SecondaryColor;
        _currentTheme.LayoutProperties.DefaultBorderRadius = $"{themePreference.BorderRadius}px";
        _currentTheme.LayoutProperties.DefaultBorderRadius = $"{themePreference.BorderRadius}px";
        _rightToLeft = themePreference.IsRTL;
    }
}