#pragma checksum "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\Shared\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c126501f14ee3d59d0fb5664598a1165d177efa9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PcSMS.Pages.Shared.Pages_Shared__StatusMessage), @"mvc.1.0.view", @"/Pages/Shared/_StatusMessage.cshtml")]
namespace PcSMS.Pages.Shared
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c126501f14ee3d59d0fb5664598a1165d177efa9", @"/Pages/Shared/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66c73876e155df90816cccb54a7716fb80424351", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#line 3 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\Shared\_StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
	var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
            WriteLiteral("\t<div");
            BeginWriteAttribute("class", " class=\"", 138, "\"", 195, 4);
            WriteAttributeValue("", 146, "alert", 146, 5, true);
            WriteAttributeValue(" ", 151, "alert-", 152, 7, true);
#line 6 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\Shared\_StatusMessage.cshtml"
WriteAttributeValue("", 158, statusMessageClass, 158, 19, false);

#line default
#line hidden
            WriteAttributeValue(" ", 177, "alert-dismissible", 178, 18, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n\t\t<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n\t\t");
#line 8 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\Shared\_StatusMessage.cshtml"
   Write(Model);

#line default
#line hidden
            WriteLiteral("\r\n\t</div>\r\n");
#line 10 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\Shared\_StatusMessage.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591