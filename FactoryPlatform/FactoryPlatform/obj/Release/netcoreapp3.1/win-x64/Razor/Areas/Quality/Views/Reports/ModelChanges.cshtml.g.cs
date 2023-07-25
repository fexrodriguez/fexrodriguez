#pragma checksum "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\Quality\Views\Reports\ModelChanges.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be0b9269617a616408dbc574f10a207b445410f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Quality_Views_Reports_ModelChanges), @"mvc.1.0.view", @"/Areas/Quality/Views/Reports/ModelChanges.cshtml")]
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
#line 1 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\Quality\Views\_ViewImports.cshtml"
using FactoryPlatform.Areas.Quality.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\Quality\Views\_ViewImports.cshtml"
using FactoryPlatform.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\Quality\Views\_ViewImports.cshtml"
using FactoryPlatform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\Quality\Views\_ViewImports.cshtml"
using FactoryPlatform.Areas.ServiceNow.Models.ServiceMenu.CorrectiveAction;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\Quality\Views\Reports\ModelChanges.cshtml"
using FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelChanges;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be0b9269617a616408dbc574f10a207b445410f6", @"/Areas/Quality/Views/Reports/ModelChanges.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"989b4164f24ce87c91035728cf9a62fabf57d814", @"/Areas/Quality/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Quality_Views_Reports_ModelChanges : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<R_ModelChangesViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\Quality\Views\Reports\ModelChanges.cshtml"
  
    ViewData["Title"] = ViewData["Titulo"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .dt-buttons, .dataTables_filter {
        display: none;
    }
</style>
<div class=""post d-flex flex-column-fluid border"" id=""kt_post"">
    <div id=""kt_content_container"" class=""container-fluid"">
        <div id=""BlockPantalla"">
            <div class=""card mb-5"">
                <div class=""card-body p-5 mb-0"">
                    <div class=""row"">
                        <div class=""col-lg-3 fv-row mb-5"">
                            <div class=""position-relative d-flex align-items-center fv-row"">
                                <span class=""svg-icon svg-icon-2 position-absolute mx-4""><i class=""fas fa-calendar-alt fs-3""></i></span>
                                <input id=""DateRanges"" name=""DateRanges"" class=""form-control p-3 fs-7 ps-15"" placeholder=""Pick date rage"" />
                            </div>
                        </div>
                        <div class=""col-lg-3 fv-row  me-0"">
                            <button type=""button"" onclick=""SendFormCombos()"" id=""Searc");
            WriteLiteral(@"h"" class=""btn btn-primary p-3 fs-8 me-3""><i class=""fas fa-search""></i>Search</button>
                        </div>
                    </div>

                </div>
            </div>
            <div class=""card mb-5 d-none"" id=""Resultado"">
                <div class=""card-body p-5 mb-0 d-none"" id=""Tabla"">
                    <div class=""card-header align-items-center py-5 gap-2 gap-md-5"">
                        <div class=""card-title"">
                            <div class=""d-flex align-items-center position-relative my-1"">
                                <span class=""svg-icon svg-icon-1 position-absolute ms-4""><i class=""fas fa-search""></i></span>
                                <input type=""text"" data-kt-filter=""searchMFList"" class=""form-control form-control-solid w-250px ps-13"" placeholder=""Search Report"" />
                            </div>
                            <div id=""TablaModelChanges_export"" class=""d-none""></div>
                        </div>
                        <div");
            WriteLiteral(@" class=""card-toolbar flex-row-fluid justify-content-end gap-5"">
                            <button type=""button"" class=""btn btn-light-primary"" data-kt-menu-trigger=""click"" data-kt-menu-placement=""bottom-end"">
                                <span class=""svg-icon svg-icon-1 position-absolute ms-4""></span>
                                Export Report
                            </button>
                            <div id=""TablaModelChanges_export_menu"" class=""menu menu-sub menu-sub-dropdown menu-column menu-rounded menu-gray-600 menu-state-bg-light-primary fw-semibold fs-7 w-200px py-4"" data-kt-menu=""true"">
                                <div class=""menu-item px-3"">
                                    <a href=""#"" class=""menu-link px-3"" data-kt-exportMFList=""excel"">
                                        Export as excel &nbsp;&nbsp; <i class=""fas fa-file-excel text-success fs-3""></i>
                                    </a>
                                </div>
                                <");
            WriteLiteral(@"div class=""menu-item px-3"">
                                    <a href=""#"" class=""menu-link px-3"" data-kt-exportMFList=""csv"">
                                        Export as csv &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i class=""fas fa-file-csv text-info fs-3""></i>
                                    </a>
                                </div>
                                <div class=""menu-item px-3"">
                                    <a href=""#"" class=""menu-link px-3"" data-kt-exportMFList=""pdf"">
                                        Export as pdf &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i class=""fas fa-file-pdf text-danger fs-3""></i>
                                    </a>
                                </div>
                            </div>
                            <div id=""TablaModelChanges_buttons"" class=""d-none""></div>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <table id=""TablaModelChanges"" class=""table border-g");
            WriteLiteral(@"ray-400 table-hover table-row-bordered gy-4 gs-7"" style=""width:100%"">
                            <thead>
                                <tr class=""fw-bold fs-6 text-gray-800 text-uppercase bg-gray-300 border-top"">
                                    <th class=""min-w-50px  align-middle border-end text-center""></th>
                                    <th class=""min-w-50px  align-middle border-end text-center"">Serie</th>
                                    <th class=""min-w-50px  align-middle border-end text-center"">Previous Model</th>
                                    <th class=""min-w-50px  align-middle border-end text-center"">New Model</th>
                                    <th class=""min-w-100px align-middle border-end text-center"">Record date</th>
                                    <th class=""min-w-100px align-middle border-end text-center"">Record User</th>
                                </tr>
                            </thead>
                            <tbody>
                       ");
            WriteLiteral(@"     </tbody>
                        </table>
                    </div>
                </div>
                <div class=""card-body p-5 mb-0 d-none"" id=""NoInfo"">
                    <div class=""alert alert-warning d-flex align-items-center p-5"" id=""AlertWarning"">
                        <span class=""svg-icon svg-icon-2x svg-icon-light me-4"">
                            <i class=""fas fa-exclamation-triangle fs-2x text-warning""></i>
                        </span>
                        <div class=""d-flex flex-column"">
                            <h6 class=""text-warning"">-- There are no records --</h6>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"    <script>
        var button = document.querySelector(""#Search"");
        var target = document.querySelector(""#BlockPantalla"");

        var BlockPantalla = new KTBlockUI(target, {
            message: '<div class=""blockui-message""><span class=""spinner-border text-primary""></span> Loading...</div>',
        });
    </script>
");
                WriteLiteral(@"    <script>
        var start = moment().subtract(10, ""years"");
        var end = moment();

        function cb(start, end) {
            $(""#DateRanges"").html(start.format(""MMMM D, YYYY"") + "" - "" + end.format(""MMMM D, YYYY""));
        }

        $(""#DateRanges"").daterangepicker({
            showDropdowns: true,
            startDate: start,
            endDate: end,
            ranges: {
                ""All Dates"": [moment().subtract(10, ""years""), moment()],
                ""Today"": [moment(), moment()],
                ""Yesterday"": [moment().subtract(1, ""days""), moment().subtract(1, ""days"")],
                ""Last 7 Days"": [moment().subtract(6, ""days""), moment()],
                ""Last 30 Days"": [moment().subtract(29, ""days""), moment()],
                ""This Month"": [moment().startOf(""month""), moment().endOf(""month"")],
                ""Last Month"": [moment().subtract(1, ""month"").startOf(""month""), moment().subtract(1, ""month"").endOf(""month"")]
            }
        }, cb);

       ");
                WriteLiteral(@" cb(start, end);
    </script>
    <script>
        function SendFormCombos() {
            BlockPantalla.block();

            $(""#Resultado"").addClass(""d-none"");
            $(""#Tabla"").addClass(""d-none"");
            $(""#NoInfo"").addClass(""d-none"");

            var DateRange = $(""#DateRanges"").val();

            $.ajax({
                url: """);
#nullable restore
#line 145 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\Quality\Views\Reports\ModelChanges.cshtml"
                 Write(Url.Action("SearchInfo","R_ModelChanges"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                data: {
                    DateRange: DateRange,
                },
                type: ""POST"",
                beforeSend: function (xhr) {
                    xhr.setRequestHeader(""XSRF-TOKEN"",
                        $('input:hidden[name=""__RequestVerificationToken""]').val());
                },
            }).done(function (result) {
                if (result != null) {
                    if (result == 'Error') {
                        BlockPantalla.release();
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
                    else {
                        var obj = JSON.parse(result);

               ");
                WriteLiteral(@"         if (obj.length > 0) {
                            $(""#Resultado"").removeClass(""d-none"");
                            $(""#Tabla"").removeClass(""d-none"");
                            var t = $('#TablaModelChanges').DataTable({
                                destroy: true,
                                dom: 'Bfrtip',
                                ""pageLength"": 100,
                                ""columnDefs"": [
                                    { ""className"": ""dt-center"", ""targets"": ""_all"" }
                                ]
                            });
                            t.clear().draw();

                            for (var i = 0; i < obj.length; i++) {
                                t.row.add(
                                    [
                                        i + 1,
                                        obj[i].Serie,
                                        obj[i].PreviousModel,
                                        obj[i].NewModel,
             ");
                WriteLiteral(@"                           obj[i].RecordDate,
                                        obj[i].RecordUser

                                    ]).draw(false);
                            }

                            //Export datable ajax
                            const exportButtons = document.querySelectorAll('#TablaModelChanges_export_menu [data-kt-exportMFList]');
                            exportButtons.forEach(exportButton => {
                                exportButton.addEventListener('click', e => {

                                    e.preventDefault();

                                    var exportValue = e.target.getAttribute('data-kt-exportmflist');
                                    var target = document.querySelector('div[id=""TablaModelChanges_buttons""]');
                                    target = document.querySelector('.buttons-' + exportValue);
                                    target.click();
                                });
                            });
");
                WriteLiteral(@"                            //Search in datable ajax
                            const filterSearch = document.querySelector('[data-kt-filter=""searchMFList""]');
                            filterSearch.addEventListener('keyup', function (e) {
                                t.search(e.target.value).draw();
                            });

                            BlockPantalla.release();
                        } else {

                            $(""#Resultado"").removeClass(""d-none"");
                            $(""#NoInfo"").removeClass(""d-none"");
                            BlockPantalla.release();
                        }
                        //$(""#kt_body"").attr(""data-kt-aside-minimize"", ""on"");

                    }

                }
                else {
                    SystemServerError()
                }
            }).fail(function (error) {
                swalErrorServer()
            });
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<R_ModelChangesViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591