#pragma checksum "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\Quality\Views\PhotoCenter\PhotoCenterRackPinion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08362ce064cc36aa742f45cf1fdb1014c96753d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Quality_Views_PhotoCenter_PhotoCenterRackPinion), @"mvc.1.0.view", @"/Areas/Quality/Views/PhotoCenter/PhotoCenterRackPinion.cshtml")]
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
#line 1 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\Quality\Views\PhotoCenter\PhotoCenterRackPinion.cshtml"
using FactoryPlatform.Areas.Quality.Models.PhotoCenter;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08362ce064cc36aa742f45cf1fdb1014c96753d0", @"/Areas/Quality/Views/PhotoCenter/PhotoCenterRackPinion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"989b4164f24ce87c91035728cf9a62fabf57d814", @"/Areas/Quality/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Quality_Views_PhotoCenter_PhotoCenterRackPinion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PhotocenterViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("itForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\Quality\Views\PhotoCenter\PhotoCenterRackPinion.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\Quality\Views\PhotoCenter\PhotoCenterRackPinion.cshtml"
  
	ViewData["Title"] = ViewData["Titulo"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""post d-flex flex-column-fluid"" id=""kt_post"">
	<div id=""kt_content_container"" class=""container-fluid"">
		<div id=""kt_block_ModelFeacture"">
			<div class=""card mb-7"">
				<div class=""card-body p-5"" id=""kt_block_PhotoCenter"">
					<input type=""hidden"" name=""Station"" id=""Station""");
            BeginWriteAttribute("value", " value=\"", 454, "\"", 476, 1);
#nullable restore
#line 12 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\Quality\Views\PhotoCenter\PhotoCenterRackPinion.cshtml"
WriteAttributeValue("", 462, Model.Station, 462, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t\t<input type=\"hidden\" name=\"SeccionId\" id=\"IdSeccion\"");
            BeginWriteAttribute("value", " value=\"", 539, "\"", 563, 1);
#nullable restore
#line 13 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\Quality\Views\PhotoCenter\PhotoCenterRackPinion.cshtml"
WriteAttributeValue("", 547, Model.IdSeccion, 547, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t\t<input type=\"hidden\" name=\"Tipo\" id=\"Tipo\"");
            BeginWriteAttribute("value", " value=\"", 616, "\"", 635, 1);
#nullable restore
#line 14 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\Quality\Views\PhotoCenter\PhotoCenterRackPinion.cshtml"
WriteAttributeValue("", 624, Model.Tipo, 624, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
					<div class=""row"">
						<div class=""col-lg-2 fv-row mb-4"">
							<label class=""fs-6 form-label fw-bolder text-dark"">Serie</label>
							<input name=""Serie"" id=""Serie"" onChange=""Validar(this.value); myDropzone.removeAllFiles(true); $('.dropzone-start').css('display','none'); document.getElementById('attachFile').disabled = true;document.getElementById('archivos').disabled = true;"" placeholder=""Serie"" type=""text"" class=""form-control ps-3 p-3 fs-8"" autocomplete=""off"" />
						</div>
						<div class=""col-lg-2 fv-row mb-4"">
							<label class=""fs-6 form-label fw-bolder text-dark"">Modelo</label>
							<input name=""Modelo"" id=""Modelo"" type=""text"" class=""form-control ps-3 p-3 fs-8"" placeholder=""Modelo"" disabled />
						</div>

						<div class=""border border-gray-100 p-0 mb-0""></div>

						<div class=""card-body p-3"">
							");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08362ce064cc36aa742f45cf1fdb1014c96753d08550", async() => {
                WriteLiteral(@"
								<div class=""col-lg-10 p-0"">
									<!--begin::Dropzone-->
									<div class=""dropzone dropzone-queue mb-2"" id=""kt_dropzonejs_RackPinion"">
										<div class=""dropzone-panel mb-lg-0 mb-2"">
											<button type=""button"" class=""dropzone-select btn btn-sm btn-primary me-2"" id=""attachFile"" disabled=""disabled"">Add files</button>
											<button type=""button"" class=""dropzone-upload btn btn-sm btn-primary me-2"" onclick=""$('#itForm').submit();"" id=""archivos"" disabled=""disabled"">Upload All</button>
											<button type=""button"" class=""dropzone-remove-all btn btn-sm btn-danger"">Remove All</button>
										</div>
										<div class=""dropzone-items wm-200px"">
											<div class=""dropzone-item"" style=""display:none"">
												<div class=""dropzone-file"">
													<div class=""dropzone-filename"" title=""some_image_file_name.jpg"">
														<span data-dz-name>some_image_file_name.jpg</span>
														<strong>(<span data-dz-size>340kb</span>)</strong>
													</div");
                WriteLiteral(@">
													<div class=""dropzone-success text-success"" data-dz-successmessage></div>
													<div class=""dropzone-error"" data-dz-errormessage></div>
												</div>
												<div class=""dropzone-progress"">
													<div class=""progress"">
														<div class=""progress-bar bg-primary""
															 role=""progressbar"" aria-valuemin=""0"" aria-valuemax=""100"" aria-valuenow=""0"" data-dz-uploadprogress>
														</div>
													</div>
												</div>
												<div class=""dropzone-toolbar"">
													<span class=""dropzone-start""><i class=""bi bi-play-fill fs-3""></i></span>
													<span class=""dropzone-cancel"" data-dz-remove style=""display: none;""><i class=""bi bi-x fs-3""></i></span>
													<span class=""dropzone-delete"" data-dz-remove><i class=""bi bi-x fs-1""></i></span>
												</div>
											</div>
										</div>
									</div>
									<!--end::Dropzone-->
								</div>
							");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n<script>\r\n\tfunction Validar() {\r\n\t\tvar station = $(\"#Station\").val();\r\n\t\tvar serie = $(\"#Serie\").val();\r\n\t\tvar idSeccion = $(\'#IdSeccion\').val();\r\n\r\n\t\tif (serie != \'\') {\r\n\r\n\t\t\t$.ajax({\r\n\t\t\t\t\turl: \"");
#nullable restore
#line 83 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\Quality\Views\PhotoCenter\PhotoCenterRackPinion.cshtml"
                     Write(Url.Action("ValidateModel","PhotoCenter"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
				data: {
					serie: serie,
					station: station,
					idSeccion: idSeccion
				},
				type: ""POST"",
				beforeSend: function (xhr) {
					xhr.setRequestHeader(""XSRF-TOKEN"",
						$('input:hidden[name=""__RequestVerificationToken""]').val());
				},
			}).done(function (result) {

				if (result != null) {
					if (result == 'Error') {
						SystemServerError()
						BlockPantalla.release();
						document.getElementById('archivos').disabled = true;
						document.getElementById('attachFile').disabled = true;
					}
					if (result == 'noSession') {
						swalExpired()
						BlockPantalla.release();
					}
					else if (result == 'Sorry') {
						swalNoAuthorized()
						BlockPantalla.release();
					}
					else if (result == 'NoPage') {
						swalNoAuthorized()
						BlockPantalla.release();
					}
					else {

						var obj = JSON.parse(result);                        
						let Result = obj.Result;
						let Model = obj.Modelo;
						let MensajeAlert = obj.MensajeA");
                WriteLiteral(@"lerta;

						if (Result == 'NoExiste') {
							toastr.error(""The series is not registered in Motor features!"");
							$('#Modelo').val("""");
						}
						else if (Result == 'Pasa') {
							document.getElementById('Modelo').value = Model;
							document.getElementById('attachFile').disabled = false;
							document.getElementById('archivos').disabled = false;

						}
						else if (Result == 'NoPasa') {
							$('#Modelo').val(Model);
							document.getElementById('archivos').disabled = true;
							document.getElementById('attachFile').disabled = true;
							Swal.fire({
								title: '<h1>The next model:</h1> <br> <p class=""text-danger"">' + Model + '</p><p> Is Stop for: </p><p class=""text-danger"">' + MensajeAlert + '</p>',
								icon: ""warning"",
								width: '450px',
								showCancelButton: false,
								buttonsStyling: false,
								allowOutsideClick: false,
								allowEscapeKey: false,
								confirmButtonText: ""Ok"",
								customClass: {
									confirmButton");
                WriteLiteral(@": ""btn btn-primary""
								}
							}).then((result) => {
								if (result.isConfirmed) {
									$('#Serie').val("""");
									$('#Modelo').val("""");
								}
							})

						}

					}
				}
				else {
					BlockPantalla.release();
					document.getElementById('archivos').disabled = true;
					document.getElementById('attachFile').disabled = true;
				}

			}).fail(function (error) {
				swalErrorServer()
			});

		} else {
			$('#Modelo').val("""");
		}

	}

	//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	// set the dropzone container id
	var id = ""#kt_dropzonejs_RackPinion"";
	var dropzone = document.querySelector(id);

	// set the preview element template
	var previewNode = dropzone.querySelector("".dropzone-item"");
	previewNode.id = """";
	var previewTemplate = previewNode.parentNode.innerHTML;
	previewNod");
                WriteLiteral("e.parentNode.removeChild(previewNode);\r\n\r\n\tvar myDropzone = new Dropzone(id, { // Make the whole body a dropzone\r\n\t\turl: \"");
#nullable restore
#line 188 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Areas\Quality\Views\PhotoCenter\PhotoCenterRackPinion.cshtml"
         Write(Url.Action("FTPUpload","PhotoCenter"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
		parallelUploads: 1,
		acceptedFiles: '.jpg,.jpeg',
		previewTemplate: previewTemplate,
		maxFilesize: 30, // Max filesize in MB
		autoQueue: false, // Make sure the files aren't queued until manually added
		previewsContainer: id + "" .dropzone-items"", // Define the container to display the previews
		clickable: id + "" .dropzone-select"", // Define the element that should be used as click trigger to select files.
		init: function () {
			this.on(""success"", function (file, responseText) {
				if (responseText != null) {
					if (responseText == 'Error') {
						SystemServerError()
						BlockPantalla.release();
						document.getElementById('archivos').disabled = true;
						document.getElementById('attachFile').disabled = true;
					}
					if (responseText == 'noSession') {
						swalExpired()
						BlockPantalla.release();
					}
					else if (responseText == 'Sorry') {
						swalNoAuthorized()
						BlockPantalla.release();
					}
					else if (responseText == 'NoPage') {
						");
                WriteLiteral(@"swalNoAuthorized()
						BlockPantalla.release();
					}
					else {
						if (responseText == ""success"") {
							file.previewElement.querySelector('[data-dz-successmessage]').textContent = ""success"";
						}
						else {
							Swal.fire({
								title: '<h1>The next file can not Upload:</h1> <br> <p class=""text-danger"">' + file.name,
								icon: ""danger"",
								width: '450px',
								showCancelButton: false,
								buttonsStyling: false,
								allowOutsideClick: false,
								allowEscapeKey: false,
								confirmButtonText: ""Ok"",
								customClass: {
									confirmButton: ""btn btn-danger""
								}
							})
						}
					}
				}
			});
		}

	});

	myDropzone.on(""addedfile"", function (file) {
		// Hookup the start button
		file.previewElement.querySelector(id + "" .dropzone-start"").onclick = function () { myDropzone.enqueueFile(file) };
		const dropzoneItems = dropzone.querySelectorAll('.dropzone-item');
		dropzoneItems.forEach(dropzoneItem => {
			dropzoneIte");
                WriteLiteral(@"m.style.display = '';
		});
		dropzone.querySelector('.dropzone-upload').style.display = ""inline-block"";
		dropzone.querySelector('.dropzone-remove-all').style.display = ""inline-block"";
	});

	// Update the total progress bar
	myDropzone.on(""totaluploadprogress"", function (progress) {
		const progressBars = dropzone.querySelectorAll('.progress-bar');
		progressBars.forEach(progressBar => {
			progressBar.style.width = progress + ""%"";
		});
	});

	myDropzone.on(""sending"", function (file, xhr, data) {
		// Show the total progress bar when upload starts
		const progressBars = dropzone.querySelectorAll('.progress-bar');
		progressBars.forEach(progressBar => {
			progressBar.style.opacity = ""1"";
		});
		// And disable the start button
		file.previewElement.querySelector(id + "" .dropzone-start"").setAttribute(""disabled"", ""disabled"");
		data.set(""Serie"", $(""#Serie"").val());
		data.set(""Station"", $(""#Station"").val());
		data.set(""Modelo"", $(""#Modelo"").val());
		data.set(""IdSeccion"", $(""#IdSecc");
                WriteLiteral(@"ion"").val());
		data.set(""__RequestVerificationToken"", $('input:hidden[name=""__RequestVerificationToken""]').val());
	});

	// Hide the total progress bar when nothing's uploading anymore
	myDropzone.on(""complete"", function (progress) {
		const progressBars = dropzone.querySelectorAll('.dz-complete');
		setTimeout(function () {
			progressBars.forEach(progressBar => {
				progressBar.querySelector('.progress-bar').style.opacity = ""0"";
				progressBar.querySelector('.progress').style.opacity = ""0"";
				progressBar.querySelector('.dropzone-start').style.opacity = ""0"";
			});
		}, 300);
	});

	// Setup the buttons for all transfers
	dropzone.querySelector("".dropzone-upload"").addEventListener('click', function () {
		myDropzone.enqueueFiles(myDropzone.getFilesWithStatus(Dropzone.ADDED));
	});

	// Setup the button for remove all files
	dropzone.querySelector("".dropzone-remove-all"").addEventListener('click', function () {
		dropzone.querySelector('.dropzone-upload').style.display = ""none"";
	");
                WriteLiteral(@"	dropzone.querySelector('.dropzone-remove-all').style.display = ""none"";
		myDropzone.removeAllFiles(true);
	});

	// On all files completed upload
	myDropzone.on(""queuecomplete"", function (progress) {
		const uploadIcons = dropzone.querySelectorAll('.dropzone-upload');
		uploadIcons.forEach(uploadIcon => {
			uploadIcon.style.display = ""none"";
		});
	});

	// On all files removed
	myDropzone.on(""removedfile"", function (file) {
		if (myDropzone.files.length < 1) {
			dropzone.querySelector('.dropzone-upload').style.display = ""none"";
			dropzone.querySelector('.dropzone-remove-all').style.display = ""none"";
		}
	});
				//show the modal with it

				//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PhotocenterViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
