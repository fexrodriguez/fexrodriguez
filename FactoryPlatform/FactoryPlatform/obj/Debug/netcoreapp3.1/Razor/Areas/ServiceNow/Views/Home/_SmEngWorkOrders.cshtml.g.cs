#pragma checksum "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\ServiceNow\Views\Home\_SmEngWorkOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a0dc15b7baff466899a066412872e0edb54d0a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ServiceNow_Views_Home__SmEngWorkOrders), @"mvc.1.0.view", @"/Areas/ServiceNow/Views/Home/_SmEngWorkOrders.cshtml")]
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
#line 1 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\ServiceNow\Views\_ViewImports.cshtml"
using FactoryPlatform.Areas.ServiceNow.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\ServiceNow\Views\_ViewImports.cshtml"
using FactoryPlatform.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\ServiceNow\Views\_ViewImports.cshtml"
using FactoryPlatform;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a0dc15b7baff466899a066412872e0edb54d0a5", @"/Areas/ServiceNow/Views/Home/_SmEngWorkOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f98b4b2c9dcb3bd4ccd31e043dedd47faf852ef", @"/Areas/ServiceNow/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_ServiceNow_Views_Home__SmEngWorkOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EngWorkOrdersModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("EngWorkordersForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "ServiceNow", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateWorkOrders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a0dc15b7baff466899a066412872e0edb54d0a55743", async() => {
                WriteLiteral(@"
            <div class=""card-body p-9"">
                <div class=""row mb-6"">
                    <label class=""col-lg-3 col-form-label required fw-bold fs-6"">Class: </label>
                    <div class=""col-lg-3 fv-row"">
                        <select id=""ClassEng"" name=""ClassEng"" onchange=""clearFormEng()"" class=""form-select form-select-sm form-select p-3 fs-8"" data-control=""select2"" data-placeholder=""-- Select an option --"" autofocus>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a0dc15b7baff466899a066412872e0edb54d0a56499", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\ServiceNow\Views\Home\_SmEngWorkOrders.cshtml"
                             foreach (var item in Model.Services_now_WorkOrders_Class)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a0dc15b7baff466899a066412872e0edb54d0a57834", async() => {
#nullable restore
#line 13 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\ServiceNow\Views\Home\_SmEngWorkOrders.cshtml"
                                                          Write(item.Clase);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\ServiceNow\Views\Home\_SmEngWorkOrders.cshtml"
                                   WriteLiteral(item.ID_Clase);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\ServiceNow\Views\Home\_SmEngWorkOrders.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </select>
                    </div>
                </div>
                <div class=""row mb-6"">
                    <label class=""col-lg-3 col-form-label required fw-bold fs-6"">Type</label>
                    <div class=""col-lg-3 fv-row"">
                        <select id=""TypeEng"" name=""TypeEng"" class=""form-select form-select-sm form-select p-3 fs-8"" data-control=""select2"" data-placeholder=""-- Select an option --"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a0dc15b7baff466899a066412872e0edb54d0a510511", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\ServiceNow\Views\Home\_SmEngWorkOrders.cshtml"
                             foreach (var item in Model.TypeWorkOrder)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a0dc15b7baff466899a066412872e0edb54d0a511831", async() => {
#nullable restore
#line 25 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\ServiceNow\Views\Home\_SmEngWorkOrders.cshtml"
                                                         Write(item.TipoOrdenTrabajo);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\ServiceNow\Views\Home\_SmEngWorkOrders.cshtml"
                                   WriteLiteral(item.ID_Tipo);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\ServiceNow\Views\Home\_SmEngWorkOrders.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </select>
                    </div>
                </div>
                <div class=""row mb-6"">
                    <label class=""col-lg-3 col-form-label required fw-bold fs-6"">WorkStation</label>
                    <div class=""col-lg-3 fv-row"">
                        <select id=""WorkStationEng"" name=""WorkStationEng""");
                BeginWriteAttribute("onchange", " onchange=\"", 2012, "\"", 2067, 3);
                WriteAttributeValue("", 2023, "readDataEng(this.value,", 2023, 23, true);
#nullable restore
#line 33 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\ServiceNow\Views\Home\_SmEngWorkOrders.cshtml"
WriteAttributeValue(" ", 2046, ViewData["MenuId"], 2047, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2066, ")", 2066, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-select form-select-sm form-select p-3 fs-8\" data-control=\"select2\" data-placeholder=\"-- Select an option --\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a0dc15b7baff466899a066412872e0edb54d0a515110", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\ServiceNow\Views\Home\_SmEngWorkOrders.cshtml"
                             foreach (var item in Model.Production_Stations)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a0dc15b7baff466899a066412872e0edb54d0a516436", async() => {
#nullable restore
#line 37 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\ServiceNow\Views\Home\_SmEngWorkOrders.cshtml"
                                                             Write(item.Descripcion);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\ServiceNow\Views\Home\_SmEngWorkOrders.cshtml"
                                   WriteLiteral(item.ID_Estacion);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\ServiceNow\Views\Home\_SmEngWorkOrders.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </select>
                    </div>
                </div>
                <div class=""row mb-6"">
                    <label class=""col-lg-3 col-form-label  fw-bold fs-6"">Department</label>
                    <div class=""col-lg-3 fv-row"">
                        <select id=""DepEng"" name=""DepEng"" class=""form-select form-select-sm form-select-solid p-3 fs-8"" data-control=""select2"" data-placeholder=""-"" disabled>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a0dc15b7baff466899a066412872e0edb54d0a519116", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </select>
                    </div>
                </div>
                <div class=""row mb-6"">
                    <label class=""col-lg-3 col-form-label fw-bold fs-6"">Plant</label>
                    <div class=""col-lg-3 fv-row"">
                        <select id=""PlantEng"" name=""PlantEng"" class=""form-select form-select-sm form-select-solid p-3 fs-8"" data-control=""select2"" data-placeholder=""-"" disabled>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a0dc15b7baff466899a066412872e0edb54d0a520573", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </select>
                    </div>
                </div>
                <div class=""row mb-6"">
                    <label class=""col-lg-3 col-form-label required fw-bold fs-6"">Comments: </label>
                    <div class=""col-lg-9 fv-row"">
                        <textarea id=""CommentEng"" name=""CommentEng"" class=""form-control"" rows=""4"" maxlength=""500"" data-kt-autosize=""true""></textarea>
                    </div>
                </div>
                <div class=""row mt-12"">
                    <div class=""col-md-9 offset-md-3"">
                    <button type=""button"" id=""Engbutton_submit"" class=""btn btn-primary p-3 fs-7 me-3"">
                        <span class=""indicator-label""><i class=""fas fa-save""></i>Save</span>
                        <span class=""indicator-progress"">
                            Please wait...
                            <span class=""spinner-border spinner-border-sm align-middle ms-2""></span>
                        </span>
       ");
                WriteLiteral("             </button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 78 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\ServiceNow\Views\Home\_SmEngWorkOrders.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    $('#CommentEng').maxlength({
        threshold: 500,
        warningClass: ""badge badge-danger"",
        limitReachedClass: ""badge badge-success"",
        separator: ' of ',
        preText: 'You have ',
        postText: ' chars remaining.',
        validate: true
    });

    //-----------------------------------------------------------------------------------------------------

    function readDataEng(station, IdMenuService) 
    {
        if (station != """") 
        {
            $.ajax({

            url: """);
#nullable restore
#line 99 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\ServiceNow\Views\Home\_SmEngWorkOrders.cshtml"
             Write(Url.Action("WorkOrderComboData","ServiceMenu"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                type: ""post"",
                data: { station: station, IdMenuService: IdMenuService },
                beforeSend: function(xhr) 
                {
                        xhr.setRequestHeader(""XSRF-TOKEN"",
                        $('input:hidden[name=""__RequestVerificationToken""]').val());
                },
            }).done(function(result) 
            {
                if (result != null) 
                {
                    if (result == 'Error') {
                        SystemServerError()
                    }
                    if (result == 'noSession') {
                        swalExpired()
                    }
                    else if (result == 'Sorry') {
                        swalNoAuthorized()
                    }
                    else if (result == 'NoPage') {
                        swalNoAuthorized()
                    }
                    else 
                    {
                        var obj = JSON.parse(result);

    ");
            WriteLiteral(@"                    var pd1 = obj.Production_Departments[0].ID_Departamento;
                        var pd2 = obj.Production_Departments[0].Descripcion;

                        $('#DepEng').empty().trigger(""change"");
                        var newDep = new Option(pd2, pd1, false, false);
                        $('#DepEng').append(newDep).val(pd1).trigger('change');

                        //----------------------------------------------------------

                        var sf1 = obj.Services_Factories[0].ID_Planta;
                        var sf2 = obj.Services_Factories[0].Descripcion;

                        $('#PlantEng').empty().trigger(""change"");
                        var newPlant = new Option(sf2, sf1, false, false);
                        $('#PlantEng').append(newPlant).val(sf1).trigger('change');
                    }
                }
                else 
                {
                        SystemServerError()
                }
            }).fail(function(xhr");
            WriteLiteral(@", status, error) 
            {
                    swalErrorServer()
            })
        }
    }

    //---------------------------------------------------------------------------------------------------------
    function clearFormEng() 
    {
        $('#TypeEng').val(null).trigger('change');
        $('#WorkStationEng').val(null).trigger('change');
        $('#DepEng').empty().trigger(""change"");
        $('#PlantEng').empty().trigger(""change"");
    }

    function sendFormEng() 
    {
        var classId = $('#ClassEng').val();
        var workStationId = $('#WorkStationEng').val();
        var departamentId = $('#DepEng').val();
        var typeId = $('#TypeEng').val();
        var plantId = $('#PlantEng').val();
        var commentStr = $('#CommentEng').val();
        var IdMenuService = '");
#nullable restore
#line 172 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\ServiceNow\Views\Home\_SmEngWorkOrders.cshtml"
                        Write(ViewData["MenuId"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n\r\n        $.ajax({\r\n\r\n        url: \"");
#nullable restore
#line 176 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\ServiceNow\Views\Home\_SmEngWorkOrders.cshtml"
         Write(Url.Action("CreateWorkOrders","ServiceMenu"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            type: ""post"",
            data:
            {
                classId: classId,
                workStationId: workStationId,
                departamentId: departamentId,
                plantId: plantId,
                typeId: typeId,
                commentStr: commentStr,
                IdMenuService: IdMenuService
            },
            beforeSend: function(xhr) {
                xhr.setRequestHeader(""XSRF-TOKEN"",
                    $('input:hidden[name=""__RequestVerificationToken""]').val());
            },
        }).done(function(result) 
        {
            if (result != null)
            {
                if (result == 'Error') {
                    SystemServerError()
                }
                if (result == 'noSession') {
                    swalExpired()
                }
                else if (result == 'Sorry') {
                    swalNoAuthorized()
                }
                else if (result == 'NoPage') {
                  ");
            WriteLiteral(@"  swalNoAuthorized()
                }
                if (result == ""correct"")
                {
                    Swal.fire({
                        text: ""Engineering Work Order has been successfully submitted!"",
                        icon: ""success"",
                        buttonsStyling: false,
                        confirmButtonText: ""Ok, got it!"",
                        customClass: {
                            confirmButton: ""btn btn-primary""
                        }
                    });

                    clearFormEng();
                    $('#ClassEng').val(null).trigger('change');
                    $('#CommentEng').val(null);
                }
                
            }
            else 
            {
                    SystemServerError()
            }
        }).fail(function(xhr, status, error) 
        {
                swalErrorServer()
        })
    }
</script>
");
            WriteLiteral(@" <script>
    const EngForm = document.getElementById('EngWorkordersForm');
    var validator = FormValidation.formValidation(
        EngForm,
                {
                    fields: {
                            ClassEng: {
                                validators: {
                                    notEmpty: {
                                        message: 'Class is required'
                                    }
                                }
                            },
                            TypeEng: {
                                validators: {
                                    notEmpty: {
                                        message: 'Type is required'
                                    }
                                }
                            },
                            WorkStationEng: {
                                validators: {
                                    notEmpty: {
                                        message: 'WorkStati");
            WriteLiteral(@"on is required'
                                    }
                                }
                            },
                            CommentEng: {
                                validators: {
                                    notEmpty: {
                                        message: 'Comment is required'
                                    }
                                }
                            },

                        },

                    plugins: { //Learn more: https://formvalidation.io/guide/plugins
                        trigger: new FormValidation.plugins.Trigger(),
                        bootstrap: new FormValidation.plugins.Bootstrap5({
                            rowSelector: '.fv-row',
                            eleInvalidClass: '',
                                eleValidClass: ''
                        })
                    }
                }
    );

    $(EngForm.querySelector('[name=""ClassEng""]')).on('change', function() {
       ");
            WriteLiteral(@" validator.revalidateField('ClassEng');
    }); 
    $(EngForm.querySelector('[name=""TypeEng""]')).on('change', function() {
        validator.revalidateField('TypeEng');
    }); 
    $(EngForm.querySelector('[name=""WorkStationEng""]')).on('change', function() {
        validator.revalidateField('WorkStationEng');
    }); 

    // Submit button handler
    const submitButton = document.getElementById('Engbutton_submit');
        
    submitButton.addEventListener('click', function(e) {
        // Prevent default button action
        e.preventDefault();

        // Validate form before submit
        if (validator) {
            validator.validate().then(function(status) {
                    if (status == 'Valid') {
                         
                        submitButton.setAttribute('data-kt-indicator', 'on');
                    submitButton.disabled = true;
                    setTimeout(function () {
                        submitButton.removeAttribute('data-kt-indicator');
");
            WriteLiteral(@"                        submitButton.disabled = false;
                        
                        sendFormEng()

                        }, 900);
                    }
                    else 
                    {
                    submitButton.setAttribute('data-kt-indicator', 'on');
                    submitButton.disabled = true;
                    setTimeout(function ()
                    {
                    submitButton.removeAttribute('data-kt-indicator');
                    submitButton.disabled = false;
                        
                        swal.fire({
                            text: ""Sorry, looks like there are some empty inputs detected, please try again."",
                            icon: ""error"",
                            buttonsStyling: false,
                            confirmButtonText: ""Ok, got it!"",
                            customClass: {
                                confirmButton: ""btn font-weight-bold btn-light-primary""
          ");
            WriteLiteral("                  }\r\n                        });\r\n\r\n                    }, 100);\r\n\r\n                    }\r\n            });\r\n        }\r\n    });\r\n</script>\r\n");
#nullable restore
#line 344 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\ServiceNow\Views\Home\_SmEngWorkOrders.cshtml"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EngWorkOrdersModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
