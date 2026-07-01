using System;
using System.Collections.Generic;

public class WindowManager
{

    List<string> windowStack = new List<string>();
    public void Open(string windowName)
    {
        if(!windowStack.Contains(windowName))
            windowStack.Add(windowName);

    }

    public void Close(string windowName)
    {
        if (windowStack.Contains(windowName))
            windowStack.Remove(windowName);
    }

    public string GetTopWindow()
    {
        var win = "";
        if (windowStack != null)
        {
            win = windowStack.Select(static w => w).LastOrDefault();
        }

        return win;
    }

    //public static void Main(string[] args)
    //{
    //    WindowManager wm = new WindowManager();
    //    wm.Open("Calculator");
    //    wm.Open("Browser");
    //    wm.Open("Player");
    //    wm.Close("Browser");
    //    Console.WriteLine(wm.GetTopWindow());
    //}
}
