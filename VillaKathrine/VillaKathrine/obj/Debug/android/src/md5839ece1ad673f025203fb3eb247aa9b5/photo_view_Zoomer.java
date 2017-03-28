package md5839ece1ad673f025203fb3eb247aa9b5;


public class photo_view_Zoomer
	extends android.view.ScaleGestureDetector.SimpleOnScaleGestureListener
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onScale:(Landroid/view/ScaleGestureDetector;)Z:GetOnScale_Landroid_view_ScaleGestureDetector_Handler\n" +
			"";
		mono.android.Runtime.register ("VillaKathrine.photo_view+Zoomer, VillaKathrine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", photo_view_Zoomer.class, __md_methods);
	}


	public photo_view_Zoomer () throws java.lang.Throwable
	{
		super ();
		if (getClass () == photo_view_Zoomer.class)
			mono.android.TypeManager.Activate ("VillaKathrine.photo_view+Zoomer, VillaKathrine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public photo_view_Zoomer (md5839ece1ad673f025203fb3eb247aa9b5.photo_view p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == photo_view_Zoomer.class)
			mono.android.TypeManager.Activate ("VillaKathrine.photo_view+Zoomer, VillaKathrine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "VillaKathrine.photo_view, VillaKathrine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}


	public boolean onScale (android.view.ScaleGestureDetector p0)
	{
		return n_onScale (p0);
	}

	private native boolean n_onScale (android.view.ScaleGestureDetector p0);

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
