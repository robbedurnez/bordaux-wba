#pragma checksum "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/Events/ConfirmDeleteEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a281d7c217233d9f5eaaad2cef2ddbaa44e8569"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_ConfirmDeleteEvent), @"mvc.1.0.view", @"/Views/Events/ConfirmDeleteEvent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Events/ConfirmDeleteEvent.cshtml", typeof(AspNetCore.Views_Events_ConfirmDeleteEvent))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a281d7c217233d9f5eaaad2cef2ddbaa44e8569", @"/Views/Events/ConfirmDeleteEvent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2e2efc9803e124f6d2961241f365eb9e2d2bbe3", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_ConfirmDeleteEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventsDetailsVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Events", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right: 5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Overview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left: 5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(24, 14, true);
            WriteLiteral("\r\n<center><h1>");
            EndContext();
            BeginContext(39, 13, false);
#line 3 "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/Events/ConfirmDeleteEvent.cshtml"
       Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(52, 115, true);
            WriteLiteral("</h1></center>\r\n\r\n<div class=\"card justify-content-center\">\r\n    <div class=\"card-body mx-auto\">\r\n        <p>Name: ");
            EndContext();
            BeginContext(168, 10, false);
#line 7 "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/Events/ConfirmDeleteEvent.cshtml"
            Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(178, 26, true);
            WriteLiteral("</p>\r\n        <p>Address: ");
            EndContext();
            BeginContext(205, 17, false);
#line 8 "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/Events/ConfirmDeleteEvent.cshtml"
               Write(Model.AddressLine);

#line default
#line hidden
            EndContext();
            BeginContext(222, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(224, 16, false);
#line 8 "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/Events/ConfirmDeleteEvent.cshtml"
                                  Write(Model.PostalCode);

#line default
#line hidden
            EndContext();
            BeginContext(240, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(242, 10, false);
#line 8 "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/Events/ConfirmDeleteEvent.cshtml"
                                                    Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(252, 23, true);
            WriteLiteral("</p>\r\n        <p>From: ");
            EndContext();
            BeginContext(276, 11, false);
#line 9 "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/Events/ConfirmDeleteEvent.cshtml"
            Write(Model.Start);

#line default
#line hidden
            EndContext();
            BeginContext(287, 24, true);
            WriteLiteral("</p>\r\n        <p>Until: ");
            EndContext();
            BeginContext(312, 9, false);
#line 10 "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/Events/ConfirmDeleteEvent.cshtml"
             Write(Model.End);

#line default
#line hidden
            EndContext();
            BeginContext(321, 29, true);
            WriteLiteral("</p>\r\n        <p>Created by: ");
            EndContext();
            BeginContext(351, 14, false);
#line 11 "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/Events/ConfirmDeleteEvent.cshtml"
                  Write(Model.Promotor);

#line default
#line hidden
            EndContext();
            BeginContext(365, 28, true);
            WriteLiteral("</p>\r\n        <p>Acts:</p>\r\n");
            EndContext();
#line 13 "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/Events/ConfirmDeleteEvent.cshtml"
         foreach (var act in Model.Acts)
        {

#line default
#line hidden
            BeginContext(446, 18, true);
            WriteLiteral("            <p> - ");
            EndContext();
            BeginContext(465, 8, false);
#line 15 "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/Events/ConfirmDeleteEvent.cshtml"
             Write(act.Name);

#line default
#line hidden
            EndContext();
            BeginContext(473, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 16 "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/Events/ConfirmDeleteEvent.cshtml"
        }

#line default
#line hidden
            BeginContext(490, 110, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<p class=\"text-center\">Are you sure?</p>\r\n<div class=\"row justify-content-center\">\r\n    ");
            EndContext();
            BeginContext(600, 201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a281d7c217233d9f5eaaad2cef2ddbaa44e856910741", async() => {
                BeginContext(721, 73, true);
                WriteLiteral("\r\n        <button type=\"submit\" class=\"btn btn-danger\">Yes</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "/Users/robbedurnez/Projects/permanente-evaluatie-web-backend-bordaux_7/BordauxWebApp/Views/Events/ConfirmDeleteEvent.cshtml"
                                                                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(801, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(807, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a281d7c217233d9f5eaaad2cef2ddbaa44e856913944", async() => {
                BeginContext(903, 2, true);
                WriteLiteral("No");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(909, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventsDetailsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
