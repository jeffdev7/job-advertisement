#pragma checksum "C:\Users\Jefferson\Documents\Job-Plataform\Job-Plataform\Views\Home\_JobPostListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf49a053cc92306130fea29bb19dea145e56b0bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__JobPostListPartial), @"mvc.1.0.view", @"/Views/Home/_JobPostListPartial.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Jefferson\Documents\Job-Plataform\Job-Plataform\Views\_ViewImports.cshtml"
using Job_Plataform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jefferson\Documents\Job-Plataform\Job-Plataform\Views\_ViewImports.cshtml"
using Job_Plataform.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf49a053cc92306130fea29bb19dea145e56b0bf", @"/Views/Home/_JobPostListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c609ad49eee8f9a74da5b036e8167e00bba92216", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__JobPostListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<JobPost>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"list-group mt-4\">\r\n");
#nullable restore
#line 4 "C:\Users\Jefferson\Documents\Job-Plataform\Job-Plataform\Views\Home\_JobPostListPartial.cshtml"
      
        foreach (JobPost job in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 128, "\"", 156, 3);
            WriteAttributeValue("", 138, "showModal(", 138, 10, true);
#nullable restore
#line 7 "C:\Users\Jefferson\Documents\Job-Plataform\Job-Plataform\Views\Home\_JobPostListPartial.cshtml"
WriteAttributeValue("", 148, job.Id, 148, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 155, ")", 155, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"modal\" class=\"list-group-item list-group-item-action\" aria-current=\"true\">\r\n                <div class=\"d-flex w-100 justify-content-between\">\r\n                    <h5 class=\"mb-1\">");
#nullable restore
#line 9 "C:\Users\Jefferson\Documents\Job-Plataform\Job-Plataform\Views\Home\_JobPostListPartial.cshtml"
                                Write(job.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <small>");
#nullable restore
#line 10 "C:\Users\Jefferson\Documents\Job-Plataform\Job-Plataform\Views\Home\_JobPostListPartial.cshtml"
                      Write(job.JobLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                </div>\r\n                <p class=\"mb-1\">");
#nullable restore
#line 12 "C:\Users\Jefferson\Documents\Job-Plataform\Job-Plataform\Views\Home\_JobPostListPartial.cshtml"
                           Write(job.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <small>Start: ");
#nullable restore
#line 13 "C:\Users\Jefferson\Documents\Job-Plataform\Job-Plataform\Views\Home\_JobPostListPartial.cshtml"
                         Write(job.StartDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n            </a>\r\n");
#nullable restore
#line 15 "C:\Users\Jefferson\Documents\Job-Plataform\Job-Plataform\Views\Home\_JobPostListPartial.cshtml"

        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<JobPost>> Html { get; private set; }
    }
}
#pragma warning restore 1591
