#pragma checksum "D:\31-10-BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14f2a69f18160cde41ab44811240f455f4d84f68"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp_Demo_ZobiWebSolutions.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\31-10-BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\31-10-BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\31-10-BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\31-10-BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\31-10-BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\31-10-BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\31-10-BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\31-10-BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\_Imports.razor"
using BlazorApp_Demo_ZobiWebSolutions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\31-10-BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\_Imports.razor"
using BlazorApp_Demo_ZobiWebSolutions.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\31-10-BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\_Imports.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\31-10-BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\_Imports.razor"
using Blazor.LoadingIndicator;

#line default
#line hidden
#nullable disable
    public class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<BlazorApp_Demo_ZobiWebSolutions.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main main-right");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "top-row px-5");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.AddMarkupContent(12, "<h4>Procurement Activity Manager</h4>\r\n        ");
            __builder.OpenElement(13, "span");
            __builder.AddAttribute(14, "class", "welcome-user");
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(16);
            __builder.AddAttribute(17, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.AddMarkupContent(19, "<b>Welcome,</b> ");
                __builder2.AddContent(20, 
#nullable restore
#line 20 "D:\31-10-BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\Shared\MainLayout.razor"
                                     context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(21, "!\r\n\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "content px-4");
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(28);
            __builder.AddAttribute(29, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.AddContent(31, 
#nullable restore
#line 34 "D:\31-10-BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\Shared\MainLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(32, "\r\n            ");
            }
            ));
            __builder.AddAttribute(33, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(34, "\r\n\r\n\r\n\r\n\r\n                ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "container");
                __builder2.AddMarkupContent(37, "\r\n                    ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "row");
                __builder2.AddMarkupContent(40, "\r\n                        ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "col-md-5 login-box-col mx-auto");
                __builder2.AddMarkupContent(43, "\r\n                            ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "myform form ");
                __builder2.AddMarkupContent(46, "\r\n                                ");
                __builder2.AddMarkupContent(47, @"<div class=""logo mb-3"">
                                    <div class=""col-md-12 text-center"">
                                        <img src=""/assests/pam_circletransparent.png"" width=""75"">
                                        <h1 class=""welcome-title"">Welcom to PAM</h1>
                                        <p class=""login-sub-title"">Please Login to continue</p>
                                    </div>
                                </div>
                                
                                ");
                __builder2.OpenElement(48, "form");
                __builder2.AddAttribute(49, "name", "login");
                __builder2.AddAttribute(50, "class", "login-form");
                __builder2.AddMarkupContent(51, "\r\n");
#nullable restore
#line 64 "D:\31-10-BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\Shared\MainLayout.razor"
                                     if (errorMessage != null)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(52, "                                    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "alert alert-danger alert-dismissible fade show");
                __builder2.AddMarkupContent(55, "\r\n                                        ");
                __builder2.AddMarkupContent(56, "<button type=\"button\" class=\"close\" data-dismiss=\"alert\">&times;</button>\r\n                                        ");
                __builder2.AddMarkupContent(57, "<strong>Oh snap!</strong> ");
                __builder2.AddContent(58, 
#nullable restore
#line 68 "D:\31-10-BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\Shared\MainLayout.razor"
                                                                   errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(59, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n");
#nullable restore
#line 70 "D:\31-10-BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\Shared\MainLayout.razor"
                                       
                                    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(61, "\r\n                                    ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "form-group");
                __builder2.AddMarkupContent(64, "\r\n                                        ");
                __builder2.AddMarkupContent(65, "<label for=\"exampleInputEmail1\" class=\"form-label\">User Name</label>\r\n                                        ");
                __builder2.OpenElement(66, "input");
                __builder2.AddAttribute(67, "type", "email");
                __builder2.AddAttribute(68, "name", "email");
                __builder2.AddAttribute(69, "class", "form-control");
                __builder2.AddAttribute(70, "id", "email");
                __builder2.AddAttribute(71, "aria-describedby", "emailHelp");
                __builder2.AddAttribute(72, "placeholder", "Email Address");
                __builder2.AddAttribute(73, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "D:\31-10-BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\Shared\MainLayout.razor"
                                                                                                                                                                          Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Username = __value, Username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n                                    ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "form-group");
                __builder2.AddMarkupContent(79, "\r\n                                        ");
                __builder2.AddMarkupContent(80, "<label for=\"exampleInputEmail1\" class=\"form-label\">Password</label>\r\n                                        ");
                __builder2.OpenElement(81, "input");
                __builder2.AddAttribute(82, "type", "password");
                __builder2.AddAttribute(83, "name", "password");
                __builder2.AddAttribute(84, "id", "password");
                __builder2.AddAttribute(85, "class", "form-control");
                __builder2.AddAttribute(86, "aria-describedby", "emailHelp");
                __builder2.AddAttribute(87, "placeholder", "Enter Password");
                __builder2.AddAttribute(88, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 79 "D:\31-10-BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\Shared\MainLayout.razor"
                                                                                                                                                                                    Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(89, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Password = __value, Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                                    ");
                __builder2.AddMarkupContent(92, "<div class=\"form-group text-center\">\r\n                                        <button type=\"submit\" class=\" btn btn-block btn-primary login-btn tx-tfm\">Login</button>\r\n                                    </div>\r\n                                    ");
                __builder2.AddMarkupContent(93, "<div class=\"form-group\">\r\n                                        <h3 class=\"info-title text-center\">Problem accessing you account?</h3>\r\n                                    </div>\r\n                                    ");
                __builder2.AddMarkupContent(94, "<div class=\"form-group\">\r\n                                        <p class=\"text-center\"><a href=\"#\" class=\"link\">Contact Support</a></p>\r\n                                    </div>\r\n\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n\r\n\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(100, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 126 "D:\31-10-BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\BlazorApp_Demo_ZobiWebSolutions\Shared\MainLayout.razor"
       
    string Username = "";
    string Password = "";

    string errorMessage = null;

     protected override async Task OnInitializedAsync()
    {
         var uri = navManager.ToAbsoluteUri(navManager.Uri);

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("name", out var param))
        {
            errorMessage = param.First();
        }
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
            await JSRuntime.InvokeAsync<object>("ValidateLogin");
       
        // StateHasChanged();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
