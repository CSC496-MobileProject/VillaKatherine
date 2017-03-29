package md5839ece1ad673f025203fb3eb247aa9b5;


public class TouchImageView_TouchImageViewListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.view.View.OnTouchListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTouch:(Landroid/view/View;Landroid/view/MotionEvent;)Z:GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler:Android.Views.View/IOnTouchListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("VillaKathrine.TouchImageView+TouchImageViewListener, VillaKathrine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", TouchImageView_TouchImageViewListener.class, __md_methods);
	}


	public TouchImageView_TouchImageViewListener () throws java.lang.Throwable
	{
		super ();
		if (getClass () == TouchImageView_TouchImageViewListener.class)
			mono.android.TypeManager.Activate ("VillaKathrine.TouchImageView+TouchImageViewListener, VillaKathrine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public TouchImageView_TouchImageViewListener (md5839ece1ad673f025203fb3eb247aa9b5.TouchImageView p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == TouchImageView_TouchImageViewListener.class)
			mono.android.TypeManager.Activate ("VillaKathrine.TouchImageView+TouchImageViewListener, VillaKathrine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "VillaKathrine.TouchImageView, VillaKathrine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}


	public boolean onTouch (android.view.View p0, android.view.MotionEvent p1)
	{
		return n_onTouch (p0, p1);
	}

	private native boolean n_onTouch (android.view.View p0, android.view.MotionEvent p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
