#r "./windoze/WindowScrape.dll"

using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WindowScrape.Types;
using System.Diagnostics;
using System.Threading.Tasks;

using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

public class Startup
{
    public async Task<object> getWindowDetailsByTitle(String title)
    {
        return Windoze.getDetailsByTitle(title);
    }

    public async Task<object> activateWindow(String title) {
        return Windoze.activateWindow(title);
    }

    public async Task<object> minimizeWindow(String title) {
        return Windoze.minimizeWindow(title);
    }
    public async Task<object> getWindowDetailsByClassName(String className) {
        return Windoze.getDetailsByClassName(className);
    }
}

 enum KeyModifier
{
    None = 0,
    Alt = 1,
    Control = 2,
    Shift = 4,
    WinKey = 8
}

public static class Windoze
{
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

    public static WindowDetails getDetailsByTitle(String title) {
        HwndObject window = HwndObject.GetWindowByTitle(title);
        return new WindowDetails(window);
    }

    public static bool activateWindow(String title) {
        HwndObject window = HwndObject.GetWindowByTitle(title);
        return window.Activate();
    }
    public static bool minimizeWindow(String title) {
        HwndObject window = HwndObject.GetWindowByTitle(title);
        return window.Minimize();
    }

    public static WindowDetails getDetailsByClassName(String className) {
        HwndObject window = HwndObject.GetWindowByClassName(className);
        return new WindowDetails(window);
    }
}

public class WindowDetails
{
    public int x;
    public int y;
    public int height;
    public int width;
    public String title;
    public String className;

    public WindowDetails(HwndObject window)
    {
        height = window.Size.Height;
        width = window.Size.Width;
        x = window.Location.X;
        y = window.Location.Y;
        title = window.Title;
        className = window.ClassName;
    }
}

