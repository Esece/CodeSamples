###### LINQPad
## Get Main Window

``` csharp
string path = null;

using (var dialog = new System.Windows.Forms.OpenFileDialog())
{
    dialog.InitialDirectory = @"C:\Projects";

    var handle = Process.GetProcessById(Util.HostProcessID).MainWindowHandle;
    var win32Window = new System.Windows.Forms.NativeWindow();
    
    win32Window.AssignHandle(handle);

    if (dialog.ShowDialog(win32Window) != System.Windows.Forms.DialogResult.OK)
    {
        return;
    }

    path = dialog.FileName;
}
```
