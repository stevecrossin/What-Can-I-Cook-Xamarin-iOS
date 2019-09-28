using System;
using Android.Gms.Ads;
using Android.Widget;
using WhatCanICookForms.Control;
using WhatCanICookForms.Droid.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(WhatCanICookForms.Control.AdControlView), typeof(AdViewRenderer))]
namespace WhatCanICookForms.Droid.Helpers
{
    [Obsolete]
    public class AdViewRenderer :  ViewRenderer<Control.AdControlView, AdView>
    {
        string adUnitId = "ca-app-pub-3940256099942544/6300978111"; 
        AdSize adSize = AdSize.SmartBanner;
        AdView adView;

        AdView CreateAdView()
        {
            if (adView != null)
                return adView;
            adView = new AdView(Forms.Context);
            adView.AdSize = adSize;
            adView.AdUnitId = adUnitId;
            var adParams = new LinearLayout.LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent);
            adView.LayoutParameters = adParams;

            adView.LoadAd(new AdRequest.Builder().Build());
            return adView;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<AdControlView> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                CreateAdView();
                SetNativeControl(adView);
            }
        }
    }

}

