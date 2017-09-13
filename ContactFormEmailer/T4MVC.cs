﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC
{
    public static ContactFormEmailer.Web.Controllers.HomeController Home = new ContactFormEmailer.Web.Controllers.T4MVC_HomeController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
}

#pragma warning disable 0436
namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}
#pragma warning restore 0436

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        public const string UrlPath = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
        public static readonly string _references_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/_references.min.js") ? Url("_references.min.js") : Url("_references.js");
        public static readonly string bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap.min.js") ? Url("bootstrap.min.js") : Url("bootstrap.js");
        public static readonly string bootstrap_min_js = Url("bootstrap.min.js");
        public static readonly string jquery_1_10_2_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery-1.10.2.intellisense.min.js") ? Url("jquery-1.10.2.intellisense.min.js") : Url("jquery-1.10.2.intellisense.js");
        public static readonly string jquery_1_10_2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery-1.10.2.min.js") ? Url("jquery-1.10.2.min.js") : Url("jquery-1.10.2.js");
        public static readonly string jquery_1_10_2_min_js = Url("jquery-1.10.2.min.js");
        public static readonly string jquery_1_10_2_min_map = Url("jquery-1.10.2.min.map");
        public static readonly string jquery_validate_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.validate-vsdoc.min.js") ? Url("jquery.validate-vsdoc.min.js") : Url("jquery.validate-vsdoc.js");
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
        public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
        public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
        public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
        public static readonly string modernizr_2_6_2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/modernizr-2.6.2.min.js") ? Url("modernizr-2.6.2.min.js") : Url("modernizr-2.6.2.js");
        public static readonly string respond_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/respond.min.js") ? Url("respond.min.js") : Url("respond.js");
        public static readonly string respond_min_js = Url("respond.min.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        public const string UrlPath = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
        public static readonly string bootstrap_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap.min.css") ? Url("bootstrap.min.css") : Url("bootstrap.css");
        public static readonly string bootstrap_min_css = Url("bootstrap.min.css");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Fonts {
            public const string UrlPath = "~/Content/Fonts";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class oem {
                public const string UrlPath = "~/Content/Fonts/oem";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class myriad_set_pro {
                    public const string UrlPath = "~/Content/Fonts/oem/myriad_set_pro";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
                    public static readonly string myriad_set_pro_text_eot = Url("myriad-set-pro-text.eot");
                    public static readonly string myriad_set_pro_text_svg = Url("myriad-set-pro-text.svg");
                    public static readonly string myriad_set_pro_text_woff = Url("myriad-set-pro-text.woff");
                    public static readonly string myriad_set_pro_text_woff2 = Url("myriad-set-pro-text.woff2");
                    public static readonly string myriad_set_pro_thin_eot = Url("myriad-set-pro-thin.eot");
                    public static readonly string myriad_set_pro_thin_svg = Url("myriad-set-pro-thin.svg");
                    public static readonly string myriad_set_pro_thin_woff = Url("myriad-set-pro-thin.woff");
                    public static readonly string myriad_set_pro_thin_woff2 = Url("myriad-set-pro-thin.woff2");
                    public static readonly string myriad_set_pro_bold_ttf = Url("myriad-set-pro_bold.ttf");
                    public static readonly string myriad_set_pro_medium_ttf = Url("myriad-set-pro_medium.ttf");
                    public static readonly string myriad_set_pro_semibold_ttf = Url("myriad-set-pro_semibold.ttf");
                    public static readonly string myriad_set_pro_text_ttf = Url("myriad-set-pro_text.ttf");
                    public static readonly string myriad_set_pro_thin_ttf = Url("myriad-set-pro_thin.ttf");
                    public static readonly string myriad_set_pro_ultralight_ttf = Url("myriad-set-pro_ultralight.ttf");
                }
            
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class product_sans {
                    public const string UrlPath = "~/Content/Fonts/oem/product-sans";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
                    public static readonly string ProductSans_Light_eot = Url("ProductSans-Light.eot");
                    public static readonly string ProductSans_Light_svg = Url("ProductSans-Light.svg");
                    public static readonly string ProductSans_Light_ttf = Url("ProductSans-Light.ttf");
                    public static readonly string ProductSans_Light_woff = Url("ProductSans-Light.woff");
                    public static readonly string ProductSans_Regular_eot = Url("ProductSans-Regular.eot");
                    public static readonly string ProductSans_Regular_svg = Url("ProductSans-Regular.svg");
                    public static readonly string ProductSans_Regular_ttf = Url("ProductSans-Regular.ttf");
                    public static readonly string ProductSans_Regular_woff = Url("ProductSans-Regular.woff");
                }
            
            }
        
            public static readonly string Ubuntu_Bold_eot = Url("Ubuntu-Bold.eot");
            public static readonly string Ubuntu_Bold_svg = Url("Ubuntu-Bold.svg");
            public static readonly string Ubuntu_Bold_ttf = Url("Ubuntu-Bold.ttf");
            public static readonly string Ubuntu_Bold_woff = Url("Ubuntu-Bold.woff");
            public static readonly string Ubuntu_BoldItalic_eot = Url("Ubuntu-BoldItalic.eot");
            public static readonly string Ubuntu_BoldItalic_svg = Url("Ubuntu-BoldItalic.svg");
            public static readonly string Ubuntu_BoldItalic_ttf = Url("Ubuntu-BoldItalic.ttf");
            public static readonly string Ubuntu_BoldItalic_woff = Url("Ubuntu-BoldItalic.woff");
            public static readonly string Ubuntu_Italic_eot = Url("Ubuntu-Italic.eot");
            public static readonly string Ubuntu_Italic_svg = Url("Ubuntu-Italic.svg");
            public static readonly string Ubuntu_Italic_ttf = Url("Ubuntu-Italic.ttf");
            public static readonly string Ubuntu_Italic_woff = Url("Ubuntu-Italic.woff");
            public static readonly string Ubuntu_Light_eot = Url("Ubuntu-Light.eot");
            public static readonly string Ubuntu_Light_svg = Url("Ubuntu-Light.svg");
            public static readonly string Ubuntu_Light_ttf = Url("Ubuntu-Light.ttf");
            public static readonly string Ubuntu_Light_woff = Url("Ubuntu-Light.woff");
            public static readonly string Ubuntu_LightItalic_eot = Url("Ubuntu-LightItalic.eot");
            public static readonly string Ubuntu_LightItalic_svg = Url("Ubuntu-LightItalic.svg");
            public static readonly string Ubuntu_LightItalic_ttf = Url("Ubuntu-LightItalic.ttf");
            public static readonly string Ubuntu_LightItalic_woff = Url("Ubuntu-LightItalic.woff");
            public static readonly string Ubuntu_Medium_eot = Url("Ubuntu-Medium.eot");
            public static readonly string Ubuntu_Medium_svg = Url("Ubuntu-Medium.svg");
            public static readonly string Ubuntu_Medium_ttf = Url("Ubuntu-Medium.ttf");
            public static readonly string Ubuntu_Medium_woff = Url("Ubuntu-Medium.woff");
            public static readonly string Ubuntu_MediumItalic_eot = Url("Ubuntu-MediumItalic.eot");
            public static readonly string Ubuntu_MediumItalic_svg = Url("Ubuntu-MediumItalic.svg");
            public static readonly string Ubuntu_MediumItalic_ttf = Url("Ubuntu-MediumItalic.ttf");
            public static readonly string Ubuntu_MediumItalic_woff = Url("Ubuntu-MediumItalic.woff");
            public static readonly string Ubuntu_Regular_eot = Url("Ubuntu-Regular.eot");
            public static readonly string Ubuntu_Regular_svg = Url("Ubuntu-Regular.svg");
            public static readonly string Ubuntu_Regular_ttf = Url("Ubuntu-Regular.ttf");
            public static readonly string Ubuntu_Regular_woff = Url("Ubuntu-Regular.woff");
        }
    
        public static readonly string Site_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/Site.min.css") ? Url("Site.min.css") : Url("Site.css");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Styles {
            public const string UrlPath = "~/Content/Styles";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
            public static readonly string _carousel_less = Url("_carousel.less");
            public static readonly string _carousel_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/_carousel.min.css") ? Url("_carousel.min.css") : Url("_carousel.css");
            public static readonly string _carousel_min_css = Url("_carousel.min.css");
            public static readonly string _carriers_less = Url("_carriers.less");
            public static readonly string _carriers_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/_carriers.min.css") ? Url("_carriers.min.css") : Url("_carriers.css");
            public static readonly string _carriers_min_css = Url("_carriers.min.css");
            public static readonly string _custom_less = Url("_custom.less");
            public static readonly string _custom_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/_custom.min.css") ? Url("_custom.min.css") : Url("_custom.css");
            public static readonly string _custom_min_css = Url("_custom.min.css");
            public static readonly string _location_less = Url("_location.less");
            public static readonly string _main_less = Url("_main.less");
            public static readonly string _main_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/_main.min.css") ? Url("_main.min.css") : Url("_main.css");
            public static readonly string _main_min_css = Url("_main.min.css");
            public static readonly string _nav_less = Url("_nav.less");
            public static readonly string _nav_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/_nav.min.css") ? Url("_nav.min.css") : Url("_nav.css");
            public static readonly string _nav_min_css = Url("_nav.min.css");
            public static readonly string _phone_compare_less = Url("_phone-compare.less");
            public static readonly string _phone_compare_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/_phone-compare.min.css") ? Url("_phone-compare.min.css") : Url("_phone-compare.css");
            public static readonly string _phone_compare_min_css = Url("_phone-compare.min.css");
            public static readonly string _rate_less = Url("_rate.less");
            public static readonly string _rate_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/_rate.min.css") ? Url("_rate.min.css") : Url("_rate.css");
            public static readonly string _rate_min_css = Url("_rate.min.css");
            public static readonly string _simple_slider_touch_less = Url("_simple-slider-touch.less");
            public static readonly string _simple_slider_touch_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/_simple-slider-touch.min.css") ? Url("_simple-slider-touch.min.css") : Url("_simple-slider-touch.css");
            public static readonly string _simple_slider_touch_min_css = Url("_simple-slider-touch.min.css");
            public static readonly string styles_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/styles.min.css") ? Url("styles.min.css") : Url("styles.css");
            public static readonly string styles_less = Url("styles.less");
            public static readonly string styles_min_css = Url("styles.min.css");
        }
    
    }

    
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        public static partial class Scripts 
        {
            public static class Assets
            {
                public const string _references_js = "~/Scripts/_references.js"; 
                public const string bootstrap_js = "~/Scripts/bootstrap.js"; 
                public const string bootstrap_min_js = "~/Scripts/bootstrap.min.js"; 
                public const string jquery_1_10_2_intellisense_js = "~/Scripts/jquery-1.10.2.intellisense.js"; 
                public const string jquery_1_10_2_js = "~/Scripts/jquery-1.10.2.js"; 
                public const string jquery_1_10_2_min_js = "~/Scripts/jquery-1.10.2.min.js"; 
                public const string jquery_validate_js = "~/Scripts/jquery.validate.js"; 
                public const string jquery_validate_min_js = "~/Scripts/jquery.validate.min.js"; 
                public const string jquery_validate_unobtrusive_js = "~/Scripts/jquery.validate.unobtrusive.js"; 
                public const string jquery_validate_unobtrusive_min_js = "~/Scripts/jquery.validate.unobtrusive.min.js"; 
                public const string modernizr_2_6_2_js = "~/Scripts/modernizr-2.6.2.js"; 
                public const string respond_js = "~/Scripts/respond.js"; 
                public const string respond_min_js = "~/Scripts/respond.min.js"; 
            }
        }
        public static partial class Content 
        {
            public static partial class Fonts 
            {
                public static partial class oem 
                {
                    public static partial class myriad_set_pro 
                    {
                        public static class Assets
                        {
                        }
                    }
                    public static partial class product_sans 
                    {
                        public static class Assets
                        {
                        }
                    }
                    public static class Assets
                    {
                    }
                }
                public static class Assets
                {
                }
            }
            public static partial class Styles 
            {
                public static class Assets
                {
                    public const string styles_css = "~/Content/Styles/styles.css";
                    public const string styles_min_css = "~/Content/Styles/styles.min.css";
                }
            }
            public static class Assets
            {
                public const string bootstrap_css = "~/Content/bootstrap.css";
                public const string bootstrap_min_css = "~/Content/bootstrap.min.css";
                public const string Site_css = "~/Content/Site.css";
            }
        }
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114


