// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace WaveTest
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSImageView DisplayImage { get; set; }

		[Action ("OpenWavFile:")]
		partial void OpenWavFile (Foundation.NSObject sender);

		[Action ("PlayPause:")]
		partial void PlayPause (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (DisplayImage != null) {
				DisplayImage.Dispose ();
				DisplayImage = null;
			}
		}
	}
}
