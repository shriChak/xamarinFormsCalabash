using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using System.Runtime.InteropServices;
using ObjCRuntime;
using Xamarin.Forms;

namespace xamarinMeetupCalabash.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		[DllImport(Constants.ObjectiveCLibrary, EntryPoint="objc_msgSend")]
		static extern void void_objc_msgSend_int(IntPtr deviceHandle, IntPtr setterHandle, Foundation.NSString intPtr);

		static readonly IntPtr setAccessibilityIdentifier_Handle = Selector.GetHandle("setAccessibilityIdentifier:");

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			global::Xamarin.Forms.Forms.ViewInitialized += (object sender, ViewInitializedEventArgs e) => {

				if (null != e.View.StyleId) {
					e.NativeView.AccessibilityIdentifier = e.View.StyleId;
					Console.WriteLine("Set AccessibilityIdentifier: " + e.View.StyleId);
				}
			};

			// Code for starting up the Xamarin Test Cloud Agent

			Xamarin.Calabash.Start();

			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);
		}
	}
}

