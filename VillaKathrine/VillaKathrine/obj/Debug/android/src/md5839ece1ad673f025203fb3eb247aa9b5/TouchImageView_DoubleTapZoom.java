package md5839ece1ad673f025203fb3eb247aa9b5;


public class TouchImageView_DoubleTapZoom
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		java.lang.Runnable
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_run:()V:GetRunHandler:Java.Lang.IRunnableInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("VillaKathrine.TouchImageView+DoubleTapZoom, VillaKathrine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", TouchImageView_DoubleTapZoom.class, __md_methods);
	}


	public TouchImageView_DoubleTapZoom () throws java.lang.Throwable
	{
		super ();
		if (getClass () == TouchImageView_DoubleTapZoom.class)
			mono.android.TypeManager.Activate ("VillaKathrine.TouchImageView+DoubleTapZoom, VillaKathrine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public TouchImageView_DoubleTapZoom (md5839ece1ad673f025203fb3eb247aa9b5.TouchImageView p0, float p1, float p2, float p3, boolean p4) throws java.lang.Throwable
	{
		super ();
		if (getClass () == TouchImageView_DoubleTapZoom.class)
			mono.android.TypeManager.Activate ("VillaKathrine.TouchImageView+DoubleTapZoom, VillaKathrine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "VillaKathrine.TouchImageView, VillaKathrine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:System.Single, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.Single, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.Single, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.Boolean, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2, p3, p4 });
	}


	public void run ()
	{
		n_run ();
	}

	private native void n_run ();

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
