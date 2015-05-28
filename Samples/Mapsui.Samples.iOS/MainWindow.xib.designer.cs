// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using Foundation;
using OpenGLES;
using ObjCRuntime;
using OpenTK.Platform.iPhoneOS;

namespace Mapsui.Samples.iOS {

	using Mapsui.UI.iOS;

	// Base type probably should be MonoTouch.Foundation.NSObject or subclass
	[Foundation.Register("OpenGLESSampleAppDelegate")]
	public partial class OpenGLESSampleAppDelegate {
		
		private UIKit.UIWindow __mt_window;
		
		private MapControl __mt_glView;
		
		#pragma warning disable 0169
		[Foundation.Connect("window")]
		private UIKit.UIWindow window {
			get {
				this.__mt_window = ((UIKit.UIWindow)(this.GetNativeField("window")));
				return this.__mt_window;
			}
			set {
				this.__mt_window = value;
				this.SetNativeField("window", value);
			}
		}
		
		[Foundation.Connect("glView")]
		private MapControl glView {
			get {
				this.__mt_glView = ((MapControl)(this.GetNativeField("glView")));
				return this.__mt_glView;
			}
			set {
				this.__mt_glView = value;
				this.SetNativeField("glView", value);
			}
		}
	}

	// Base type probably should be MonoTouch.UIKit.UIView or subclass
	[Foundation.Register("LocalMapControl")]
	public class MapControl : Mapsui.UI.iOS.MapControl
	{
		[Foundation.Export("layerClass")]
		static Class LayerClass()
		{
			return iPhoneOSGameView.GetLayerClass();
		}

		[Foundation.Export("initWithCoder:")]
		public MapControl (NSCoder coder) : base(coder) {}
	}
}
