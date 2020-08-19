using System;
using AppKit;
using System.Drawing;
using Foundation;
using ObjCRuntime;

namespace WaveTest
{
    static class MainClass
    {
        static void Main(string[] args)
        {
            NSApplication.Init();
            NSApplication.Main(args);
        }
    }
}
