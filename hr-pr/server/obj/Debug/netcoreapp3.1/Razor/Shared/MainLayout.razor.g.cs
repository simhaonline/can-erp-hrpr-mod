#pragma checksum "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c8c6565aebea0db1c5b0b26e514bfc5051b1be7"
// <auto-generated/>
#pragma warning disable 1591
namespace CanErpHrPr.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\_Imports.razor"
using CanErpHrPr.Shared;

#line default
#line hidden
#line 3 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Shared\MainLayout.razor"
using Radzen;

#line default
#line hidden
#line 4 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Shared\MainLayout.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 5 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Shared\MainLayout.razor"
using CanErpHrPr.Models.DbAtVdc2;

#line default
#line hidden
    public partial class MainLayout : CanErpHrPr.Layouts.MainLayoutComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenHeader>(4);
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row justify-content-start align-items-center");
                __builder2.AddMarkupContent(9, "\n      ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-md-6 d-flex align-items-center");
                __builder2.AddMarkupContent(12, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSidebarToggle>(13);
                __builder2.AddAttribute(14, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.EventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#line 13 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Shared\MainLayout.razor"
                                     SidebarToggle0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(16);
                __builder2.AddAttribute(17, "Text", "CanErpHrPr");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n      ");
                __builder2.AddMarkupContent(20, "<div class=\"col-md-6 text-lg-right\">\n      </div>\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\n  ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenBody>(23);
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenContentContainer>(26);
                __builder2.AddAttribute(27, "Name", "main");
                __builder2.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(29, "\n    ");
                    __builder3.AddContent(30, 
#line 26 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Shared\MainLayout.razor"
     Body

#line default
#line hidden
                    );
                    __builder3.AddMarkupContent(31, "\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(33, (__value) => {
#line 23 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Shared\MainLayout.razor"
                  body0 = (Radzen.Blazor.RadzenBody)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenSidebar>(35);
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(37, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenPanelMenu>(38);
                __builder2.AddAttribute(39, "style", "height: 100%");
                __builder2.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(41, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(42);
                    __builder3.AddAttribute(43, "Text", "Tbl Gn Departments");
                    __builder3.AddAttribute(44, "Path", "tbl-gn-departments");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(46);
                    __builder3.AddAttribute(47, "Text", "Tbl Hp Bacs");
                    __builder3.AddAttribute(48, "Path", "tbl-hp-bacs");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(50);
                    __builder3.AddAttribute(51, "Text", "Tbl Hp Chi Tiet Chuyen Mons");
                    __builder3.AddAttribute(52, "Path", "tbl-hp-chi-tiet-chuyen-mons");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(54);
                    __builder3.AddAttribute(55, "Text", "Tbl Hp Chi Tiet Cong Tacs");
                    __builder3.AddAttribute(56, "Path", "tbl-hp-chi-tiet-cong-tacs");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(58);
                    __builder3.AddAttribute(59, "Text", "Tbl Hp Chi Tiet Gia Canhs");
                    __builder3.AddAttribute(60, "Path", "tbl-hp-chi-tiet-gia-canhs");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(61, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(62);
                    __builder3.AddAttribute(63, "Text", "Tbl Hp Chi Tiet Luongs");
                    __builder3.AddAttribute(64, "Path", "tbl-hp-chi-tiet-luongs");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(66);
                    __builder3.AddAttribute(67, "Text", "Tbl Hp Chi Tiet Ngoai Ngus");
                    __builder3.AddAttribute(68, "Path", "tbl-hp-chi-tiet-ngoai-ngus");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(70);
                    __builder3.AddAttribute(71, "Text", "Tbl Hp Chuc Vus");
                    __builder3.AddAttribute(72, "Path", "tbl-hp-chuc-vus");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(73, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(74);
                    __builder3.AddAttribute(75, "Text", "Tbl Hp Dan Tocs");
                    __builder3.AddAttribute(76, "Path", "tbl-hp-dan-tocs");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(78);
                    __builder3.AddAttribute(79, "Text", "Tbl Hp Don Vi Tos");
                    __builder3.AddAttribute(80, "Path", "tbl-hp-don-vi-tos");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(81, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(82);
                    __builder3.AddAttribute(83, "Text", "Tbl Hp He Dao Taos");
                    __builder3.AddAttribute(84, "Path", "tbl-hp-he-dao-taos");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(85, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(86);
                    __builder3.AddAttribute(87, "Text", "Tbl Hp Loai Cham Congs");
                    __builder3.AddAttribute(88, "Path", "tbl-hp-loai-cham-congs");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(89, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(90);
                    __builder3.AddAttribute(91, "Text", "Tbl Hp Ngaches");
                    __builder3.AddAttribute(92, "Path", "tbl-hp-ngaches");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(94);
                    __builder3.AddAttribute(95, "Text", "Tbl Hp Nganhs");
                    __builder3.AddAttribute(96, "Path", "tbl-hp-nganhs");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(97, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(98);
                    __builder3.AddAttribute(99, "Text", "Tbl Hp Ngoai Ngus");
                    __builder3.AddAttribute(100, "Path", "tbl-hp-ngoai-ngus");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(101, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(102);
                    __builder3.AddAttribute(103, "Text", "Tbl Hp Nhan Viens");
                    __builder3.AddAttribute(104, "Path", "tbl-hp-nhan-viens");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(105, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(106);
                    __builder3.AddAttribute(107, "Text", "Tbl Hp Phan Loai Nvs");
                    __builder3.AddAttribute(108, "Path", "tbl-hp-phan-loai-nvs");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(109, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(110);
                    __builder3.AddAttribute(111, "Text", "Tbl Hp Quans");
                    __builder3.AddAttribute(112, "Path", "tbl-hp-quans");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(113, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(114);
                    __builder3.AddAttribute(115, "Text", "Tbl Hp Quoc Tiches");
                    __builder3.AddAttribute(116, "Path", "tbl-hp-quoc-tiches");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(117, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(118);
                    __builder3.AddAttribute(119, "Text", "Tbl Hp Tinh Tps");
                    __builder3.AddAttribute(120, "Path", "tbl-hp-tinh-tps");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(121, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(122);
                    __builder3.AddAttribute(123, "Text", "Tbl Hp Ton Giaos");
                    __builder3.AddAttribute(124, "Path", "tbl-hp-ton-giaos");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(125, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(126);
                    __builder3.AddAttribute(127, "Text", "Tbl Hp Trinh Do Chuyen Mons");
                    __builder3.AddAttribute(128, "Path", "tbl-hp-trinh-do-chuyen-mons");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(129, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(130);
                    __builder3.AddAttribute(131, "Text", "Tbl Hp Trinh Do Van Hoas");
                    __builder3.AddAttribute(132, "Path", "tbl-hp-trinh-do-van-hoas");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(133, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(134);
                    __builder3.AddAttribute(135, "Text", "Tbl Hp Xi Nghieps");
                    __builder3.AddAttribute(136, "Path", "tbl-hp-xi-nghieps");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(137, "\n      ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(138, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(139, (__value) => {
#line 30 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Shared\MainLayout.razor"
                     sidebar0 = (Radzen.Blazor.RadzenSidebar)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(140, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenFooter>(141);
            __builder.AddAttribute(142, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(143, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(144);
                __builder2.AddAttribute(145, "Text", "CanErpHrPr, Copyright Ⓒ 2020");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(146, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
