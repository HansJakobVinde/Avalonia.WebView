using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMHTMLIFrameElement", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomHtmlIFrameElement : DomHtmlElement
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlign = "align";

	private static readonly IntPtr selAlignHandle = Selector.GetHandle("align");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentDocument = "contentDocument";

	private static readonly IntPtr selContentDocumentHandle = Selector.GetHandle("contentDocument");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentWindow = "contentWindow";

	private static readonly IntPtr selContentWindowHandle = Selector.GetHandle("contentWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameBorder = "frameBorder";

	private static readonly IntPtr selFrameBorderHandle = Selector.GetHandle("frameBorder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeight = "height";

	private static readonly IntPtr selHeightHandle = Selector.GetHandle("height");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLongDesc = "longDesc";

	private static readonly IntPtr selLongDescHandle = Selector.GetHandle("longDesc");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMarginHeight = "marginHeight";

	private static readonly IntPtr selMarginHeightHandle = Selector.GetHandle("marginHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMarginWidth = "marginWidth";

	private static readonly IntPtr selMarginWidthHandle = Selector.GetHandle("marginWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrolling = "scrolling";

	private static readonly IntPtr selScrollingHandle = Selector.GetHandle("scrolling");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlign_ = "setAlign:";

	private static readonly IntPtr selSetAlign_Handle = Selector.GetHandle("setAlign:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrameBorder_ = "setFrameBorder:";

	private static readonly IntPtr selSetFrameBorder_Handle = Selector.GetHandle("setFrameBorder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHeight_ = "setHeight:";

	private static readonly IntPtr selSetHeight_Handle = Selector.GetHandle("setHeight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLongDesc_ = "setLongDesc:";

	private static readonly IntPtr selSetLongDesc_Handle = Selector.GetHandle("setLongDesc:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMarginHeight_ = "setMarginHeight:";

	private static readonly IntPtr selSetMarginHeight_Handle = Selector.GetHandle("setMarginHeight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMarginWidth_ = "setMarginWidth:";

	private static readonly IntPtr selSetMarginWidth_Handle = Selector.GetHandle("setMarginWidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScrolling_ = "setScrolling:";

	private static readonly IntPtr selSetScrolling_Handle = Selector.GetHandle("setScrolling:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSrc_ = "setSrc:";

	private static readonly IntPtr selSetSrc_Handle = Selector.GetHandle("setSrc:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWidth_ = "setWidth:";

	private static readonly IntPtr selSetWidth_Handle = Selector.GetHandle("setWidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSrc = "src";

	private static readonly IntPtr selSrcHandle = Selector.GetHandle("src");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWidth = "width";

	private static readonly IntPtr selWidthHandle = Selector.GetHandle("width");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMHTMLIFrameElement");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Align
	{
		[Export("align")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAlignHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAlignHandle));
		}
		[Export("setAlign:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAlign_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAlign_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomDocument ContentDocument
	{
		[Export("contentDocument", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomDocument>(Messaging.IntPtr_objc_msgSend(base.Handle, selContentDocumentHandle));
			}
			return Runtime.GetNSObject<DomDocument>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentDocumentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomAbstractView ContentWindow
	{
		[Export("contentWindow", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomAbstractView>(Messaging.IntPtr_objc_msgSend(base.Handle, selContentWindowHandle));
			}
			return Runtime.GetNSObject<DomAbstractView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentWindowHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string FrameBorder
	{
		[Export("frameBorder")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFrameBorderHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFrameBorderHandle));
		}
		[Export("setFrameBorder:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFrameBorder_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFrameBorder_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Height
	{
		[Export("height")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selHeightHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHeightHandle));
		}
		[Export("setHeight:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHeight_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHeight_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string LongDesc
	{
		[Export("longDesc")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLongDescHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLongDescHandle));
		}
		[Export("setLongDesc:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLongDesc_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLongDesc_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string MarginHeight
	{
		[Export("marginHeight")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMarginHeightHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMarginHeightHandle));
		}
		[Export("setMarginHeight:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMarginHeight_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMarginHeight_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string MarginWidth
	{
		[Export("marginWidth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMarginWidthHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMarginWidthHandle));
		}
		[Export("setMarginWidth:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMarginWidth_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMarginWidth_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string Name
	{
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
		[Export("setName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Scrolling
	{
		[Export("scrolling")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selScrollingHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selScrollingHandle));
		}
		[Export("setScrolling:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetScrolling_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetScrolling_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Src
	{
		[Export("src")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSrcHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSrcHandle));
		}
		[Export("setSrc:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSrc_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSrc_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Width
	{
		[Export("width")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selWidthHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWidthHandle));
		}
		[Export("setWidth:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetWidth_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetWidth_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomHtmlIFrameElement(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomHtmlIFrameElement(IntPtr handle)
		: base(handle)
	{
	}
}