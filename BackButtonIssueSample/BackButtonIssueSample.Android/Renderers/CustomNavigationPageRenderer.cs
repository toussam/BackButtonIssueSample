﻿//using Android.Support.V4.Widget;
//using Android.Support.V7.Widget;
//using BackButtonIssueSample.Droid;
//using BackButtonIssueSample.Droid.Renderers;
//using Xamarin.Forms;
//using Xamarin.Forms.Platform.Android;
//using Xamarin.Forms.Platform.Android.AppCompat;

//[assembly: ExportRenderer(typeof(NavigationPage), typeof(CustomNavigationPageRenderer))]
//namespace BackButtonIssueSample.Droid.Renderers
//{
//    /// <summary>
//    /// This custom renderer is coming from someone who had the same issue and resolved it with thanks to this code.
//    /// Sadly, when we did implement the renderer, the retrieved toolbar into the MainActivity.OnPostCreate method
//    /// is null. Therefore this implementation is completely useless...
//    ///
//    /// Source: https://forums.xamarin.com/discussion/87795/onoptionsitemselected-not-invoked-using-masterdetails-page-on-android
//    /// </summary>
//    public class CustomNavigationPageRenderer : VisualElementRenderer<NavigationPage>
//    {
//        protected override void OnAttachedToWindow()
//        {
//            base.OnAttachedToWindow();

//            Element page = Element.Parent;
//            MasterDetailPage masterDetailPage = null;
//            while (page != null)
//            {
//                if (page is MasterDetailPage)
//                {
//                    masterDetailPage = page as MasterDetailPage;
//                    break;
//                }

//                page = page.Parent;
//            }

//            if (masterDetailPage == null)
//            {
//                return;
//            }

//            var renderer = Platform.GetRenderer(masterDetailPage) as MasterDetailPageRenderer;
//            if (renderer == null)
//            {
//                return;
//            }

//            var drawerLayout = (DrawerLayout)renderer;
//            Toolbar toolbar = null;

//            for (int i = 0; i < ChildCount; i++)
//            {
//                var child = GetChildAt(i);
//                toolbar = child as Toolbar;
//                if (toolbar != null)
//                {
//                    break;
//                }
//            }

//            toolbar?.SetNavigationOnClickListener(new MenuClickListener(Element, drawerLayout));
//        }

//        private class MenuClickListener : Java.Lang.Object, IOnClickListener
//        {
//            readonly NavigationPage navigationPage;
//            private DrawerLayout layout;

//            public MenuClickListener(NavigationPage navigationPage, DrawerLayout layout)
//            {
//                this.navigationPage = navigationPage;
//                this.layout = layout;
//            }

//            public void OnClick(Android.Views.View v)
//            {
//                //var page = navigationPage.CurrentPage as BasePage;
//                //if (navigationPage.Navigation.NavigationStack.Count <= 1)
//                //{
//                //    layout.OpenDrawer((int)GravityFlags.Left);
//                //}

//                //if (page != null)
//                //{
//                //    if (page.OnNavigationBackButtonPressed())
//                //    {
//                //        navigationPage?.PopAsync();
//                //    }
//                //}
//                //else
//                //{
//                //    navigationPage?.PopAsync();
//                //}
//            }
//        }
//    }
//}