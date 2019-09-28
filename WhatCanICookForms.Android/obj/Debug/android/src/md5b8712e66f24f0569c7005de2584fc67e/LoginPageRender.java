package md5b8712e66f24f0569c7005de2584fc67e;


public class LoginPageRender
	extends md51558244f76c53b6aeda52c8a337f2c37.PageRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("TestFacebookLogin.Droid.LoginPageRender, WhatCanICookForms.Android", LoginPageRender.class, __md_methods);
	}


	public LoginPageRender (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == LoginPageRender.class)
			mono.android.TypeManager.Activate ("TestFacebookLogin.Droid.LoginPageRender, WhatCanICookForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public LoginPageRender (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == LoginPageRender.class)
			mono.android.TypeManager.Activate ("TestFacebookLogin.Droid.LoginPageRender, WhatCanICookForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public LoginPageRender (android.content.Context p0)
	{
		super (p0);
		if (getClass () == LoginPageRender.class)
			mono.android.TypeManager.Activate ("TestFacebookLogin.Droid.LoginPageRender, WhatCanICookForms.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
