#pragma checksum "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\ServiceTypes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25d3a7b26ce9892208bf3b1cd047c722bbe9a42b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PcSMS.Pages.ServiceTypes.Pages_ServiceTypes_Index), @"mvc.1.0.razor-page", @"/Pages/ServiceTypes/Index.cshtml")]
namespace PcSMS.Pages.ServiceTypes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\_ViewImports.cshtml"
using PcSMS;

#line default
#line hidden
#line 3 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\_ViewImports.cshtml"
using PcSMS.Data;

#line default
#line hidden
#line 3 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\ServiceTypes\Index.cshtml"
using PcSMS.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25d3a7b26ce9892208bf3b1cd047c722bbe9a42b", @"/Pages/ServiceTypes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66c73876e155df90816cccb54a7716fb80424351", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ServiceTypes_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\ServiceTypes\Index.cshtml"
  
	ViewData["Title"] = "Index";
	Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            WriteLiteral("\r\n<br />\r\n<br />\r\n<div class=\"border backgroundWhite\">\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-6\">\r\n\t\t\t<h2 class=\"text-info\">Service Types</h2>\r\n\t\t</div>\r\n");
#line 16 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\ServiceTypes\Index.cshtml"
         if ((User.IsInRole(Who.Admin)) || (User.IsInRole(Who.Staff)))
		{

#line default
#line hidden
            WriteLiteral("\t\t\t<div class=\"col-6 text-right\">\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25d3a7b26ce9892208bf3b1cd047c722bbe9a42b6696", async() => {
                WriteLiteral("\r\n\t\t\t\t\t<i class=\"fas fa-plus\"></i>&nbsp; Create New\r\n\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t</div>\r\n");
#line 23 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\ServiceTypes\Index.cshtml"
		}

#line default
#line hidden
            WriteLiteral("\t</div>\r\n\t<br />\r\n\t<div>\r\n");
#line 27 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\ServiceTypes\Index.cshtml"
         if (Model.ServiceType.Count == 0)
		{

#line default
#line hidden
            WriteLiteral("\t\t\t<p>No Service Type exists. Please create a new service type.</p>\r\n");
#line 30 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\ServiceTypes\Index.cshtml"
		}
		else
		{

#line default
#line hidden
            WriteLiteral("\t\t\t<table class=\"table table-striped border\">\r\n\t\t\t\t<tr class=\"bg-primary\">\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
#line 36 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\ServiceTypes\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.ServiceType[0].Name));

#line default
#line hidden
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
#line 39 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\ServiceTypes\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.ServiceType[0].Price));

#line default
#line hidden
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th></th>\r\n\t\t\t\t</tr>\r\n");
#line 43 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\ServiceTypes\Index.cshtml"
                 foreach (var item in Model.ServiceType)
				{

#line default
#line hidden
            WriteLiteral("\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
#line 47 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\ServiceTypes\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
#line 50 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\ServiceTypes\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Price));

#line default
#line hidden
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td style=\"width:150px;\">\r\n\t\t\t\t\t\t\t<div class=\"btn-group\" role=\"group\">\r\n");
#line 54 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\ServiceTypes\Index.cshtml"
                                 if ((User.IsInRole(Who.Admin)) || (User.IsInRole(Who.Staff)))
								{

#line default
#line hidden
            WriteLiteral("\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25d3a7b26ce9892208bf3b1cd047c722bbe9a42b10617", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t<i class=\"fas fa-edit\"></i>\r\n\t\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\ServiceTypes\Index.cshtml"
                                                                                            WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#line 59 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\ServiceTypes\Index.cshtml"
								}

#line default
#line hidden
            WriteLiteral("\t\t\t\t\t\t\t\t&nbsp; &nbsp;\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25d3a7b26ce9892208bf3b1cd047c722bbe9a42b13166", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t<i class=\"far fa-list-alt\"></i>\r\n\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\ServiceTypes\Index.cshtml"
                                                                                           WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("&nbsp; &nbsp;\r\n");
#line 64 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\ServiceTypes\Index.cshtml"
                                 if ((User.IsInRole(Who.Admin)) || (User.IsInRole(Who.Staff)))
								{

#line default
#line hidden
            WriteLiteral("\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25d3a7b26ce9892208bf3b1cd047c722bbe9a42b15792", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t<i class=\"fas fa-trash-alt\"></i>\r\n\t\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\ServiceTypes\Index.cshtml"
                                                                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#line 69 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\ServiceTypes\Index.cshtml"
								}

#line default
#line hidden
            WriteLiteral("\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n");
#line 73 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\ServiceTypes\Index.cshtml"
				}

#line default
#line hidden
            WriteLiteral("\t\t\t</table>\r\n");
#line 75 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\ServiceTypes\Index.cshtml"
		}

#line default
#line hidden
            WriteLiteral("\t</div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PcSMS.Pages.ServiceTypes.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PcSMS.Pages.ServiceTypes.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PcSMS.Pages.ServiceTypes.IndexModel>)PageContext?.ViewData;
        public PcSMS.Pages.ServiceTypes.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
