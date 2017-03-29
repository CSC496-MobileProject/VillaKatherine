package md5839ece1ad673f025203fb3eb247aa9b5;


public class GestureRecognizerView_MyScaleListener
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
		mono.android.Runtime.register ("VillaKathrine.GestureRecognizerView+MyScaleListener, VillaKathrine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GestureRecognizerView_MyScaleListener.class, __md_methods);
	}


	public GestureRecognizerView_MyScaleListener () throws java.lang.Throwable
	{
		super ();
		if (getClass () == GestureRecognizerView_MyScaleListener.class)
			mono.android.TypeManager.Activate ("VillaKathrine.GestureRecognizerView+MyScaleListener, VillaKathrine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public GestureRecognizerView_MyScaleListener (md5839ece1ad673f025203fb3eb247aa9b5.GestureRecognizerView p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == GestureRecognizerView_MyScaleListener.class)
			mono.android.TypeManager.Activate ("VillaKathrine.GestureRecognizerView+MyScaleListener, VillaKathrine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "VillaKathrine.GestureRecognizerView, VillaKathrine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
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
