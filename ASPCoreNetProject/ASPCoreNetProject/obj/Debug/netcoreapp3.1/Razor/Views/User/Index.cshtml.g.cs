#pragma checksum "C:\Users\Prog\Desktop\ASPCoreNetProjectfinal - Copy\ASPCoreNetProject\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d09a7c958a660bee7f8d5ce3e5fbb14e7eb4b5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\Prog\Desktop\ASPCoreNetProjectfinal - Copy\ASPCoreNetProject\Views\_ViewImports.cshtml"
using ASPCoreNetProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Prog\Desktop\ASPCoreNetProjectfinal - Copy\ASPCoreNetProject\Views\_ViewImports.cshtml"
using ASPCoreNetProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Prog\Desktop\ASPCoreNetProjectfinal - Copy\ASPCoreNetProject\Views\_ViewImports.cshtml"
using ASPCoreNetProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d09a7c958a660bee7f8d5ce3e5fbb14e7eb4b5b", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a394ecc291d11593477fa91612607900a798beab", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserviewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top rounded-0  img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%;height:200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-danger float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Prog\Desktop\ASPCoreNetProjectfinal - Copy\ASPCoreNetProject\Views\User\Index.cshtml"
  
    SelectList rols = new SelectList(ViewBag.roles, "Name", "Name");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""https://kit.fontawesome.com/a076d05399.js""></script>
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-xs-12 "">
                    <nav>
                        <div class=""nav nav-tabs nav-fill"" id=""nav-tab"" role=""tablist"">
                            <a class=""nav-item nav-link active"" id=""nav-All-tab"" data-toggle=""tab"" href=""#nav-All"" role=""tab"" aria-controls=""nav-All"" aria-selected=""true"">Users</a>
                        </div>
                    </nav>
                    <div class=""tab-content py-3 px-3 px-sm-0"" id=""nav-tabContent"">
                        <div class=""tab-pane fade show active container-fluid"" id=""nav-All"" role=""tabpanel"" aria-labelledby=""nav-All-tab"">
                            <div class=""row"">
");
#nullable restore
#line 19 "C:\Users\Prog\Desktop\ASPCoreNetProjectfinal - Copy\ASPCoreNetProject\Views\User\Index.cshtml"
                                 foreach (var item in Model)
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div");
            BeginWriteAttribute("id", " id=\"", 1107, "\"", 1120, 1);
#nullable restore
#line 22 "C:\Users\Prog\Desktop\ASPCoreNetProjectfinal - Copy\ASPCoreNetProject\Views\User\Index.cshtml"
WriteAttributeValue("", 1112, item.ID, 1112, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""card promoting-card col-md-4 p-0 m-0"">
                                        <!-- Card content -->

                                        <div class=""card-body d-flex flex-row"">

                                            <div>

                                                <!-- Title -->
                                                <h4 class=""card-title font-weight-bold mb-2"">");
#nullable restore
#line 30 "C:\Users\Prog\Desktop\ASPCoreNetProjectfinal - Copy\ASPCoreNetProject\Views\User\Index.cshtml"
                                                                                        Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n                                                <!-- Subtitle -->\r\n                                                <p class=\"card-text\"><i class=\"far fa-clock pr-2\"></i>");
#nullable restore
#line 33 "C:\Users\Prog\Desktop\ASPCoreNetProjectfinal - Copy\ASPCoreNetProject\Views\User\Index.cshtml"
                                                                                                 Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            </div>

                                        </div>


                                        <!-- Card image -->
                                        <div class=""view overlay"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2d09a7c958a660bee7f8d5ce3e5fbb14e7eb4b5b8000", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2099, "~/images/", 2099, 9, true);
#nullable restore
#line 41 "C:\Users\Prog\Desktop\ASPCoreNetProjectfinal - Copy\ASPCoreNetProject\Views\User\Index.cshtml"
AddHtmlAttributeValue("", 2108, item.ProfilePicture, 2108, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                        </div>

                                        <!-- Card content -->
                                        <div class=""card-body"">

                                            <div class=""collapse-content"">
                                                <span>
                                                    Mail:<a");
            BeginWriteAttribute("href", " href=\"", 2505, "\"", 2530, 2);
            WriteAttributeValue("", 2512, "mailto:", 2512, 7, true);
#nullable restore
#line 50 "C:\Users\Prog\Desktop\ASPCoreNetProjectfinal - Copy\ASPCoreNetProject\Views\User\Index.cshtml"
WriteAttributeValue("", 2519, item.Email, 2519, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-info\"> ");
#nullable restore
#line 50 "C:\Users\Prog\Desktop\ASPCoreNetProjectfinal - Copy\ASPCoreNetProject\Views\User\Index.cshtml"
                                                                                                    Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                </span>\r\n                                                <br />\r\n                                                <span class=\"text-muted\">\r\n                                                    Gender: ");
#nullable restore
#line 54 "C:\Users\Prog\Desktop\ASPCoreNetProjectfinal - Copy\ASPCoreNetProject\Views\User\Index.cshtml"
                                                       Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </span>\r\n                                                \r\n");
#nullable restore
#line 57 "C:\Users\Prog\Desktop\ASPCoreNetProjectfinal - Copy\ASPCoreNetProject\Views\User\Index.cshtml"
                                                 if (User.IsInRole("Admin"))
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a style=\"font-size:30px\"\r\n                                                       class=\"card-link\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3217, "\"", 3246, 4);
            WriteAttributeValue("", 3227, "Delete", 3227, 6, true);
            WriteAttributeValue(" ", 3233, "(\'", 3234, 3, true);
#nullable restore
#line 60 "C:\Users\Prog\Desktop\ASPCoreNetProjectfinal - Copy\ASPCoreNetProject\Views\User\Index.cshtml"
WriteAttributeValue("", 3236, item.ID, 3236, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3244, "\')", 3244, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <i class=\"fas fa-trash-alt float-right text-danger\"></i>\r\n                                                    </a>\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d09a7c958a660bee7f8d5ce3e5fbb14e7eb4b5b12807", async() => {
                WriteLiteral("\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3487, "role-", 3487, 5, true);
#nullable restore
#line 63 "C:\Users\Prog\Desktop\ASPCoreNetProjectfinal - Copy\ASPCoreNetProject\Views\User\Index.cshtml"
AddHtmlAttributeValue("", 3492, item.ID, 3492, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onload", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3510, "function()", 3510, 10, true);
            AddHtmlAttributeValue(" ", 3520, "{", 3521, 2, true);
            AddHtmlAttributeValue(" ", 3522, "document.getElementById(\'role-", 3523, 31, true);
#nullable restore
#line 63 "C:\Users\Prog\Desktop\ASPCoreNetProjectfinal - Copy\ASPCoreNetProject\Views\User\Index.cshtml"
AddHtmlAttributeValue("", 3553, item.ID, 3553, 8, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3561, "\').value", 3561, 8, true);
            AddHtmlAttributeValue(" ", 3569, "=", 3570, 2, true);
#nullable restore
#line 63 "C:\Users\Prog\Desktop\ASPCoreNetProjectfinal - Copy\ASPCoreNetProject\Views\User\Index.cshtml"
AddHtmlAttributeValue("", 3571, item.UserRole, 3571, 14, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3585, ";}", 3585, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
#nullable restore
#line 63 "C:\Users\Prog\Desktop\ASPCoreNetProjectfinal - Copy\ASPCoreNetProject\Views\User\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = rols;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 63 "C:\Users\Prog\Desktop\ASPCoreNetProjectfinal - Copy\ASPCoreNetProject\Views\User\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.UserRole);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onchange", 6, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3641, "update(\'", 3641, 8, true);
#nullable restore
#line 63 "C:\Users\Prog\Desktop\ASPCoreNetProjectfinal - Copy\ASPCoreNetProject\Views\User\Index.cshtml"
AddHtmlAttributeValue("", 3649, item.ID, 3649, 8, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3657, "\',\'role-", 3657, 8, true);
#nullable restore
#line 63 "C:\Users\Prog\Desktop\ASPCoreNetProjectfinal - Copy\ASPCoreNetProject\Views\User\Index.cshtml"
AddHtmlAttributeValue("", 3665, item.ID, 3665, 8, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3673, "\'", 3673, 1, true);
            AddHtmlAttributeValue(" ", 3674, ")", 3675, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 65 "C:\Users\Prog\Desktop\ASPCoreNetProjectfinal - Copy\ASPCoreNetProject\Views\User\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </div>\r\n\r\n                                        </div>\r\n\r\n                                    </div>\r\n");
#nullable restore
#line 71 "C:\Users\Prog\Desktop\ASPCoreNetProjectfinal - Copy\ASPCoreNetProject\Views\User\Index.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                        
                    </div>

                </div>
            </div>
        </div>
    </div>
</div>
<script>
    function update(userId,roleId) {
        var xhttp;
        console.log(roleId);
        //console.log(document.getElementById(roleId).selectedIndex);
        console.log(document.getElementById(roleId).value);
        xhttp = new XMLHttpRequest();
        xhttp.onreadystatechange = function () {
            if (this.readyState == 4 && this.status == 200) {
                console.log(this.response);
            }
            else {
                console.log(this.response);
            }
        };

        console.log(roleId);
        xhttp.open(""POST"", ""/User/UpdateRole/"", true);
        xhttp.setRequestHeader(""Content-type"", ""application/x-www-form-urlencoded"");
        xhttp.send(""UserUpdated="" + userId + ""&RoleName="" + document.getElementById(roleId).value);
    }
    ");
            WriteLiteral(@"function Delete(id) {
        var xhttp;
        console.log(id);
        xhttp = new XMLHttpRequest();
        xhttp.onreadystatechange = function () {
            if (this.readyState == 4 && this.status == 200) {
                console.log(this.response);
                document.getElementById(id).remove();
            }
            else {
                console.log(""fewefwe"");
            }
        };
        console.log(id);
        xhttp.open(""POST"", ""/User/Delete/"", true);
        xhttp.setRequestHeader(""Content-type"", ""application/x-www-form-urlencoded"");
        xhttp.send(""UserId="" + id);
    }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserviewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
