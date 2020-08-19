using System;
using AppKit;
using Foundation;
using System.IO;

namespace WaveTest
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        // 
        private NSSound sound = null;
        private NSImage image = null;
        private bool isPaused = true;


        partial void OpenWavFile(NSObject sender)
        {


            var dlg = NSOpenPanel.OpenPanel;
            dlg.CanChooseFiles = true;
            dlg.CanChooseDirectories = false;
            dlg.AllowedFileTypes = new string[] { "mp3" };


            if (dlg.RunModal() == 1)
            {
                var url = dlg.Urls[0];
            }

            sound = new NSSound(dlg.Filename, byRef: false);
            var fil = new FileInfo(dlg.Filename);

            sound.Play();
            isPaused = false;
            string imagePath = "/Users/sansirajalingam/Desktop/bla.jpg";

            image = new NSImage(imagePath);
            

        }

        

        partial void PlayPause(NSObject sender)
        {
            if (isPaused)
            {
                sound.Resume();
                isPaused = false;
            }
            else {
                sound.Pause();
                isPaused = true;
            }
            

        }
        
    }
}

