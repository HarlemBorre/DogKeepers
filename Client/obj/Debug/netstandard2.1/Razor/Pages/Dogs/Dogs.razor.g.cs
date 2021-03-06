#pragma checksum "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a69b7524633b5d9ba8f56f176d093790272ae5c8"
// <auto-generated/>
#pragma warning disable 1591
namespace DogKeepers.Client.Pages.Dogs
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\borre\Desktop\DogKeepers\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\borre\Desktop\DogKeepers\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\borre\Desktop\DogKeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\borre\Desktop\DogKeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\borre\Desktop\DogKeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\borre\Desktop\DogKeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\borre\Desktop\DogKeepers\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\borre\Desktop\DogKeepers\Client\_Imports.razor"
using DogKeepers.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\borre\Desktop\DogKeepers\Client\_Imports.razor"
using DogKeepers.Client.Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\borre\Desktop\DogKeepers\Client\_Imports.razor"
using DogKeepers.Client.Components.Loading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\borre\Desktop\DogKeepers\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\borre\Desktop\DogKeepers\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
using DogKeepers.Client.Components.DogCard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
using DogKeepers.Client.Components.Pagination;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
using Shared.DTOs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dogs")]
    public partial class Dogs : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid dogs-page p-5");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, @"<div id=""section-title"" class=""row p-2 mb-4"">
        <div class=""col-12"">
            <h2>
                Mascotas en adopción
            </h2>
            <span class=""text-muted"">
                No dejes pasar la oportunidad de hacer feliz a un perrito
            </span>
        </div>
    </div>
    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row mb-5");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-12");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "nav");
            __builder.AddAttribute(11, "class", "navbar navbar-light bg-light p-3");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "input-group input-group-lg");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenTextBox>(16);
            __builder.AddAttribute(17, "Placeholder", "Nombre");
            __builder.AddAttribute(18, "class", "form-control form-control-lg");
            __builder.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
                                     Filters.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Filters.Name = __value, Filters.Name))));
            __builder.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Filters.Name));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenDropDown<int>>(23);
            __builder.AddAttribute(24, "AllowClear", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
                                    true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 29 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
                              Sizes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "ValueProperty", "Id");
            __builder.AddAttribute(27, "TextProperty", "Name");
            __builder.AddAttribute(28, "Placeholder", "Talla");
            __builder.AddAttribute(29, "Name", "SizeId");
            __builder.AddAttribute(30, "class", "form-control form-control-lg");
            __builder.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 36 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
                                     Filters.SizeId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Filters.SizeId = __value, Filters.SizeId))));
            __builder.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<int>>>(() => Filters.SizeId));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenDropDown<int>>(35);
            __builder.AddAttribute(36, "AllowClear", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
                                    true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 40 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
                              Races

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "ValueProperty", "Id");
            __builder.AddAttribute(39, "TextProperty", "Name");
            __builder.AddAttribute(40, "Placeholder", "Raza");
            __builder.AddAttribute(41, "Name", "RaceId");
            __builder.AddAttribute(42, "class", "form-control form-control-lg");
            __builder.AddAttribute(43, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 47 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
                                        true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 48 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
                                               FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "FilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.StringFilterOperator>(
#nullable restore
#line 49 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
                                        StringFilterOperator.Contains

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 50 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
                                     Filters.RaceId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Filters.RaceId = __value, Filters.RaceId))));
            __builder.AddAttribute(48, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<int>>>(() => Filters.RaceId));
            __builder.CloseComponent();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "input-group-prepend");
            __builder.AddMarkupContent(52, "\r\n                        ");
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "class", "btn btn-primary btn-lg");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
                                                                          OnSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(56, "\r\n                            Buscar\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "text-center col-12 p-3");
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.OpenElement(63, "span");
            __builder.AddAttribute(64, "class", "text-muted");
            __builder.AddMarkupContent(65, "\r\n                        Se encontraron ");
            __builder.AddContent(66, 
#nullable restore
#line 60 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
                                        TotalDogs

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(67, " perritos\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n    ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "row");
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "col-12");
            __builder.AddMarkupContent(78, "\r\n            ");
            __builder.OpenComponent<DogKeepers.Client.Components.Loading.Loading>(79);
            __builder.AddAttribute(80, "IsLoading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 68 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
                                 IsLoadingDogsList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(82, "\r\n");
#nullable restore
#line 69 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
                 if(DogsList?.Count() != 0){

#line default
#line hidden
#nullable disable
                __builder2.AddContent(83, "                    ");
                __builder2.OpenComponent<DogKeepers.Client.Components.Pagination.Pagination>(84);
                __builder2.AddAttribute(85, "PaginationData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DogKeepers.Shared.Metadata.PaginationMetadata>(
#nullable restore
#line 70 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
                                                 PaginationData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 70 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
                                                                                OnSelectedPage

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\r\n                    ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "row");
                __builder2.AddMarkupContent(90, "\r\n");
#nullable restore
#line 72 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
                         foreach (DogDto dog in DogsList)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(91, "                            ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "col-12 col-sm-6 col-md-4 col-xl-3 mb-3");
                __builder2.AddMarkupContent(94, "\r\n                                ");
                __builder2.OpenComponent<DogKeepers.Client.Components.DogCard.DogCard>(95);
                __builder2.AddAttribute(96, "Dog", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DogKeepers.Shared.DTOs.DogDto>(
#nullable restore
#line 75 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
                                               dog

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(97, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n");
#nullable restore
#line 77 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(99, "                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n                    ");
                __builder2.OpenComponent<DogKeepers.Client.Components.Pagination.Pagination>(101);
                __builder2.AddAttribute(102, "PaginationData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DogKeepers.Shared.Metadata.PaginationMetadata>(
#nullable restore
#line 79 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
                                                 PaginationData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(103, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 79 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
                                                                                OnSelectedPage

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(104, "\r\n");
#nullable restore
#line 80 "C:\Users\borre\Desktop\DogKeepers\Client\Pages\Dogs\Dogs.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(105, "            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(106, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
