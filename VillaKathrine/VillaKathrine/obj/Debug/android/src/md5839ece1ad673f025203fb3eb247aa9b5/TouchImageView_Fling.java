package md5839ece1ad673f025203fb3eb247aa9b5;


public class TouchImageView_Fling
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
		mono.android.Runtime.register ("VillaKathrine.TouchImageView+Fling, VillaKathrine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", TouchImageView_Fling.class, __md_methods);
	}


	public TouchImageView_Fling () throws java.lang.Throwable
	{
		super ();
		if (getClass () == TouchImageView_Fling.class)
			mono.android.TypeManager.Activate ("VillaKathrine.TouchImageView+Fling, VillaKathrine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public TouchImageView_Fling (md5839ece1ad673f025203fb3eb247aa9b5.TouchImageView p0, int p1, int p2) throws java.lang.Throwable
	{
		super ();
		if (getClass () == TouchImageView_Fling.class)
			mono.android.TypeManager.Activate ("VillaKathrine.TouchImageView+Fling, VillaKathrine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "VillaKathrine.TouchImageView, VillaKathrine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
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
