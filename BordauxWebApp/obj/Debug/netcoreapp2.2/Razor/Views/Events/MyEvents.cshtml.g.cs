#pragma checksum "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/Events/MyEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8c936368f83a582b4766e36ce5faf1de980b9bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_MyEvents), @"mvc.1.0.view", @"/Views/Events/MyEvents.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Events/MyEvents.cshtml", typeof(AspNetCore.Views_Events_MyEvents))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/_ViewImports.cshtml"
using BordauxWebApp;

#line default
#line hidden
#line 2 "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/_ViewImports.cshtml"
using BordauxWebApp.Models;

#line default
#line hidden
#line 3 "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/_ViewImports.cshtml"
using BordauxWebApp.ViewModels;

#line default
#line hidden
#line 4 "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 5 "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/_ViewImports.cshtml"
using BordauxLib.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8c936368f83a582b4766e36ce5faf1de980b9bd", @"/Views/Events/MyEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2e2efc9803e124f6d2961241f365eb9e2d2bbe3", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_MyEvents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EventsEventVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mx-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Events", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 26, true);
            WriteLiteral("\r\n<h1 class=\"text-center\">");
            EndContext();
            BeginContext(55, 13, false);
#line 3 "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/Events/MyEvents.cshtml"
                   Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(68, 71, true);
            WriteLiteral("</h1>\r\n\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        ");
            EndContext();
            BeginContext(139, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8c936368f83a582b4766e36ce5faf1de980b9bd6448", async() => {
                BeginContext(223, 123, true);
                WriteLiteral("\r\n            <button style=\"width: 180px; margin-bottom: 20px;\" class=\"button button-link\">Create event</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(353, 74, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"d-flex flex-wrap justify-content-between\">\r\n");
            EndContext();
#line 12 "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/Events/MyEvents.cshtml"
         foreach (var e in Model)
        {

#line default
#line hidden
            BeginContext(473, 122, true);
            WriteLiteral("            <div class=\"col-md-4\">\r\n                <div class=\"card mb-3\">\r\n                    <div class=\"card-header\">");
            EndContext();
            BeginContext(596, 6, false);
#line 16 "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/Events/MyEvents.cshtml"
                                        Write(e.Name);

#line default
#line hidden
            EndContext();
            BeginContext(602, 100, true);
            WriteLiteral("</div>\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
            EndContext();
            BeginContext(703, 36, false);
#line 18 "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/Events/MyEvents.cshtml"
                                          Write(e.StartDate.Date.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(739, 69, true);
            WriteLiteral("</h5>\r\n                        <p class=\"card-text font-weight-bold\">");
            EndContext();
            BeginContext(809, 6, false);
#line 19 "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/Events/MyEvents.cshtml"
                                                         Write(e.City);

#line default
#line hidden
            EndContext();
            BeginContext(815, 54, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                    ");
            EndContext();
            BeginContext(869, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8c936368f83a582b4766e36ce5faf1de980b9bd10595", async() => {
                BeginContext(959, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 21 "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/Events/MyEvents.cshtml"
                                                                                           WriteLiteral(e.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(970, 46, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 24 "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/Events/MyEvents.cshtml"
        }

#line default
#line hidden
            BeginContext(1027, 18, true);
            WriteLiteral("    </div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EventsEventVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591