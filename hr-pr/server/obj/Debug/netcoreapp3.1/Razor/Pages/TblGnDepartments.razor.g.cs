#pragma checksum "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\TblGnDepartments.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "916edc5e4ee8851c53b15142da70d43bffd881cd"
// <auto-generated/>
#pragma warning disable 1591
namespace CanErpHrPr.Pages
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
#line 6 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\TblGnDepartments.razor"
using Radzen;

#line default
#line hidden
#line 7 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\TblGnDepartments.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 8 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\TblGnDepartments.razor"
using CanErpHrPr.Models.DbAtVdc2;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-gn-departments")]
    public partial class TblGnDepartments : CanErpHrPr.Pages.TblGnDepartmentsComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(4);
                __builder2.AddAttribute(5, "Size", "H1");
                __builder2.AddAttribute(6, "Text", "Tbl Gn Departments");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\n      ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-12");
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(14);
                __builder2.AddAttribute(15, "Icon", "add_circle_outline");
                __builder2.AddAttribute(16, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(17, "Text", "Add");
                __builder2.AddAttribute(18, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 15 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\TblGnDepartments.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblGnDepartment>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 17 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\TblGnDepartments.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 17 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\TblGnDepartments.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 17 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\TblGnDepartments.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<CanErpHrPr.Models.DbAtVdc2.TblGnDepartment>>(
#line 17 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\TblGnDepartments.razor"
                                                                                                     getTblGnDepartmentsResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CanErpHrPr.Models.DbAtVdc2.TblGnDepartment>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CanErpHrPr.Models.DbAtVdc2.TblGnDepartment>(this, 
#line 17 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\TblGnDepartments.razor"
                                                                                                                                                                                               Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblGnDepartment>>(28);
                    __builder3.AddAttribute(29, "Property", "Department_ID");
                    __builder3.AddAttribute(30, "Title", "Department ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblGnDepartment>>(32);
                    __builder3.AddAttribute(33, "Property", "Deparment_Name");
                    __builder3.AddAttribute(34, "Title", "Deparment Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblGnDepartment>>(36);
                    __builder3.AddAttribute(37, "Property", "Description");
                    __builder3.AddAttribute(38, "Title", "Description");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<CanErpHrPr.Models.DbAtVdc2.TblGnDepartment>>(40);
                    __builder3.AddAttribute(41, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 25 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\TblGnDepartments.razor"
                                                                                                                                               false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(42, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 25 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\TblGnDepartments.razor"
                                                                                                                                                                false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(43, "Width", "70px");
                    __builder3.AddAttribute(44, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 25 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\TblGnDepartments.razor"
                                                                                                                                                                                               TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(45, "Template", (Microsoft.AspNetCore.Components.RenderFragment<CanErpHrPr.Models.DbAtVdc2.TblGnDepartment>)((canErpHrPrModelsDbAtVdc2TblGnDepartment) => (__builder4) => {
                        __builder4.AddMarkupContent(46, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(47);
                        __builder4.AddAttribute(48, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 27 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\TblGnDepartments.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(49, "Icon", "close");
                        __builder4.AddAttribute(50, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 27 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\TblGnDepartments.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(51, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 27 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\TblGnDepartments.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, canErpHrPrModelsDbAtVdc2TblGnDepartment)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(52, "onclick", 
#line 27 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\TblGnDepartments.razor"
                                                                                                                                                                                                                       true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(53, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(55, (__value) => {
#line 17 "F:\My Programming Projects\can-erp-ot-projects\can-erp-hrpr-mod\hr-pr\server\Pages\TblGnDepartments.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<CanErpHrPr.Models.DbAtVdc2.TblGnDepartment>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
