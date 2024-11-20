using System.Globalization;

namespace Shared;

public class Languages
{
    private int _currentLanguageIndex;

    private readonly CultureInfo[] _supportedCultures =
    [
        new("en-US"),
        new("de-DE")
    ];

    public void ToggleLanguage()
    {
        if (++_currentLanguageIndex >= _supportedCultures.Length)
            _currentLanguageIndex = 0;

        CultureInfo.DefaultThreadCurrentCulture = _supportedCultures[_currentLanguageIndex];
        CultureInfo.DefaultThreadCurrentUICulture = _supportedCultures[_currentLanguageIndex];
    }
}
