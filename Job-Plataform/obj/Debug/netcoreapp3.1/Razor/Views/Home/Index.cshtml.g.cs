#pragma checksum "C:\Users\Jefferson\Documents\Job-Plataform\Job-Plataform\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38c059f1a1e5de51866b738463f05212b7698ee9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38c059f1a1e5de51866b738463f05212b7698ee9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c609ad49eee8f9a74da5b036e8167e00bba92216", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<JobPost>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Jefferson\Documents\Job-Plataform\Job-Plataform\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""jumbotron bg-primary"">
    <div class=""display-2 text-white text-center"">
        Job Plataform
    </div>

</div>

<h4>
    Finde deinen Traumjob in Deutschland!
</h4>

<div class=row mt-4>
    <div class=""col-6"">
        <input id=""inputQuery"" class=""form-control-lg form-control"" type=""text"" placeholder=""Wonach suchst du?"" />
    </div>
    <div class=""col"">
        <button onclick=""onClickSearch()"" class=""btn btn-lg btn-primary"">Suchen</button>
    </div>
</div>
<hr />
<div id=""partialList"">

</div>

<!-- Modal -->
<div class=""modal fade"" id=""modalJobPost"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""modalTitle"">Modal title</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
             ");
            WriteLiteral("       <span aria-hidden=\"true\">&times;</span>\r\n                </button>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                <img id=\"modalImage\" class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 1280, "\"", 1286, 0);
            EndWriteAttribute();
            WriteLiteral(@"/>
                <div id=""modalDescription"">

                </div>
                <hr />
                <div id=""modalSalary"" class=""mt-2"">

                </div>
                <div id=""modalContact"">

                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>
    debugger;

    $('#partialList').load(""/home/GetJobPostPartial/"");

    function onClickSearch(){
             debugger;
            var query = $('#inputQuery').val();
            $('#partialList').load(""/home/GetJobPostPartial?query="" + query);
             debugger;
             console.log(""shit "" + query);
        }

    function showModal(id){

        $.ajax({
             type: ""GET"",
                url:""");
#nullable restore
#line 76 "C:\Users\Jefferson\Documents\Job-Plataform\Job-Plataform\Views\Home\Index.cshtml"
                Write(Url.Action("GetJobPostById"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                data:{id: id},
                success: function(data){
                    debugger;
                    $('#modalImage').attr('src', `data:image/png;base64,${data.companyImage}`);
                    $('#modalTitle').text(data.jobTitle);
                    $('#modalDescription').text(data.description);
                    $('#modalSalary').text(""Jahresgehalt: $ "" + data.salary);
                    $('#modalContact').text(""Contact: "" + data.contactEmail);
                     $('#modalJobPost').modal('show')
                }
        })  
    }
</script>
");
            }
            );
            WriteLiteral("         ");
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
