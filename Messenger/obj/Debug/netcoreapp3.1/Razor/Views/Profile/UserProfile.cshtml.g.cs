#pragma checksum "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "124ab0f18fe512df3bda36239836af6ab375c4a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_UserProfile), @"mvc.1.0.view", @"/Views/Profile/UserProfile.cshtml")]
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
#line 1 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\_ViewImports.cshtml"
using Messenger;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\_ViewImports.cshtml"
using Messenger.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"124ab0f18fe512df3bda36239836af6ab375c4a7", @"/Views/Profile/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ff561a7cda373abe33870e7d650d35986fc2008", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 50%; height: 80%; margin-top:5%;margin-right:-30%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("anchor-username"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Addlike", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-begin", new global::Microsoft.AspNetCore.Html.HtmlString("clearInputField"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-complete", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-failure", new global::Microsoft.AspNetCore.Html.HtmlString("alert(\'Fail\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("sendMessage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/no-profile-pic-icon-24.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 10%;border-radius:50%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
  
    ViewData["Title"] = "Home Page";

    MessengerUser v = Model.User.FirstOrDefault(o => o.Id == ViewBag.UserID);
    var userName = User.Identity.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"width: 40%; height: 500px; margin-left: 30%; box-shadow: 1px 3px 5px 2px rgba(0,0,0,0.52) \">\r\n    <div class=\"container\" style=\"h \">\r\n        <div style=\"margin-left:35%\">\r\n\r\n            ");
#nullable restore
#line 16 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
       Write(await Component.InvokeAsync("ImageRetriever", new { id = v.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n\r\n");
            WriteLiteral("        <h3 style=\"margin-top:2%; margin-left:35%\">");
#nullable restore
#line 21 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
                                              Write(v.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
                                                           Write(v.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h3 style=\"margin-top:5%; margin-left:25%\">Greeting</h3>\r\n");
#nullable restore
#line 23 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
         if (v.Quote != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h4> \"");
#nullable restore
#line 25 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
             Write(v.Quote);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</h4>\r\n");
#nullable restore
#line 26 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>\r\n<div class=\"row\" style=\"margin-top: 0%; margin-left: 26%; width: 42%; \">\r\n\r\n    <div>\r\n        <div class=\"col-md-12\" id=\"chat\">\r\n");
#nullable restore
#line 34 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
                 foreach (var post in Model.Posts.OrderByDescending(p => p.When).Where(p => p.UserID == v.Id)) 
                { 

                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-md-11"" style=""box-shadow: 1px 3px 5px 2px rgba(0,0,0,0.52); padding-left: 0%; padding-right: 0%; padding-bottom: -2%; margin-bottom: 5%; margin-left: 12%; margin-top: 10% "">
                            <div class=""panel panel-default"" style=""margin-bottom:0%"">
                                <div class=""panel-body"">
                                    <section class=""post-heading"">
                                        <div class=""row"">
                                            <div class=""col-md-11"">
                                                <div class=""media"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "124ab0f18fe512df3bda36239836af6ab375c4a713141", async() => {
#nullable restore
#line 47 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
                                                                                                                                                                                                     Write(await Component.InvokeAsync("ImageRetriever", new { id = post.UserID }));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
                                                                                                                                                                                WriteLiteral(post.UserID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "124ab0f18fe512df3bda36239836af6ab375c4a716199", async() => {
                WriteLiteral("<h3 class=\"media-heading\" style=\"margin-top:5%\">");
#nullable restore
#line 48 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
                                                                                                                                                                                                            Write(post.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3><p class=\"anchor-time\" style=\"font-size:small; margin-top:5%\">");
#nullable restore
#line 48 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
                                                                                                                                                                                                                                                                                             Write(post.When.ToString("M/dd/yyyy hh:MM tt"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
                                                                                                               WriteLiteral(post.UserID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                                </div>
                                            </div>
                                            <div class=""col-md-1 float-right"">
                                                <a href=""#""><i class=""glyphicon glyphicon-chevron-down""></i></a>
                                            </div>
                                        </div>
                                    </section>
                                    <hr>
                                    <section class=""post-body"" style=""margin-top:2%; margin-bottom:2%"">
                                        <p>
                                            ");
#nullable restore
#line 60 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
                                       Write(post.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                    </section>\r\n");
#nullable restore
#line 63 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
                                     if (SignInManager.IsSignedIn(User))
                                    {



#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <section class=""post-footer"" style=""margin-bottom:0%"">
                                            <hr>
                                            <div class=""post-footer-option container"">
                                                <ul class=""list-unstyled"" style=""display:inline"">
                                                    <li>
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "124ab0f18fe512df3bda36239836af6ab375c4a721651", async() => {
                WriteLiteral("\r\n                                                            <i class=\"glyphicon glyphicon-thumbs-up\"></i>\r\n                                                            Like ");
#nullable restore
#line 74 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
                                                                  if (post.likes != 0)
                                                            {

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
                                                        Write(post.likes);

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
                                                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
                                                                                                            WriteLiteral(post.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                    </li>
                                                    <li><a href=""#""><i class=""glyphicon glyphicon-share-alt""></i> Share</a></li>
                                                    <li></li>
                                                </ul>
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "124ab0f18fe512df3bda36239836af6ab375c4a725524", async() => {
                WriteLiteral("\r\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "124ab0f18fe512df3bda36239836af6ab375c4a725835", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 85 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                    <div class=""form-group"">
                                                        <input name=""Text"" class=""form-control"" id=""messageText"" placeholder=""Write a Comment!"" />
                                                    </div>
                                                    <div class=""form-group"">
                                                        <input style=""background-color: crimson; width:15%;text-align:center; color: white"" type=""submit"" value=""Send"" id=""submitButton"" class=""btn btn-outline-primary btn-block"" />
                                                    </div>
                                                    <input type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 5922, "\"", 5939, 1);
#nullable restore
#line 92 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
WriteAttributeValue("", 5930, userName, 5930, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"username\" />\r\n                                                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 6033, "\"", 6049, 1);
#nullable restore
#line 93 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
WriteAttributeValue("", 6041, post.id, 6041, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"postId\" />\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </div>
                                            <button type=""button"" class=""collapsible glyphicon glyphicon-chevron-down nav-link btn btn-link text-dark"">Comments</button>
                                            <div class=""content"" style=""overflow:hidden; display:none;margin-top:4%"">
                                                
");
#nullable restore
#line 99 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
                                                 foreach (var comment in Model.Comment.OrderByDescending(p => p.When).Where(p => p.postid == post.id))
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    <hr>
                                                    <div class=""post-footer-comment-wrapper"" style=""margin-top:3%"">
                                                        <div class=""comment"">
                                                            <a href=""#"" class=""anchor-username""><h4 class=""media-heading"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "124ab0f18fe512df3bda36239836af6ab375c4a732049", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
#nullable restore
#line 104 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
                                                                                                                                                                                                     Write(comment.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></a><br />\r\n                                                            <p style=\"margin-left:10%\">\r\n                                                                ");
#nullable restore
#line 106 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
                                                           Write(comment.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                            </p>\r\n                                                            <a href=\"#\" class=\"anchor-time\">");
#nullable restore
#line 108 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
                                                                                       Write(comment.When.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                        </div>\r\n                                                    </div>\r\n                                                    <hr>\r\n");
#nullable restore
#line 112 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </div>\r\n\r\n                                        </section>\r\n");
#nullable restore
#line 116 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 120 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
                              
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\Johnny\Documents\GitHub\Messenger\Messenger\Views\Profile\UserProfile.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<MessengerUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<MessengerUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
