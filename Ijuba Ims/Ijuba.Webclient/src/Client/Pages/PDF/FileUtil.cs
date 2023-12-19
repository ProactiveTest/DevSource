using Microsoft.JSInterop;

namespace Ijuba.Webclient.Client.Pages.PDF;

public static class FileUtil
{
    public static ValueTask<object> SaveAs(this IJSRuntime js, string filename, byte[] data)
           => js.InvokeAsync<object>(
               "saveAsFile",
               filename,
               Convert.ToBase64String(data));



    public static void OpenNewTab(this IJSRuntime js, string filename, byte[] data)
    => js.InvokeVoidAsync("jsOpenIntoNewTab",
                            filename,
                            Convert.ToBase64String(data)
                            );
}
