#pragma checksum "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Views\Profile\MyProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3871c0639b2ce6fe0ac471a56a7b3c72e66ae8ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_MyProfile), @"mvc.1.0.view", @"/Views/Profile/MyProfile.cshtml")]
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
#line 1 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Views\_ViewImports.cshtml"
using FactoryPlatform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Views\_ViewImports.cshtml"
using FactoryPlatform.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3871c0639b2ce6fe0ac471a56a7b3c72e66ae8ca", @"/Views/Profile/MyProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92eed42c8c60a96099311cfba92bc50cf1c31e4d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Profile_MyProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserProfile>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("kt_account_profile_details_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditPicture", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("kt_signin_change_password"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdatePass", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Views\Profile\MyProfile.cshtml"
  
    ViewData["Title"] = "MyProfile";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""post d-flex flex-column-fluid"" id=""kt_post"">
    <div id=""kt_content_container"" class=""container-fluid"">
        <div class=""card mb-5 mb-xl-10"">
            <div class=""card-header border-0 cursor-pointer"" role=""button"" data-bs-toggle=""collapse"" data-bs-target=""#kt_account_profile_details"" aria-expanded=""true"" aria-controls=""kt_account_profile_details"">
                <div class=""card-title m-0"">
                    <h3 class=""fw-bolder m-0"">Profile Details</h3>
                </div>
            </div>
            <div id=""kt_account_profile_details"" class=""collapse show"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3871c0639b2ce6fe0ac471a56a7b3c72e66ae8ca6775", async() => {
                WriteLiteral(@"
                    <div class=""card-body border-top p-9"">
                        <div class=""row mb-6"">
                            <label class=""col-lg-3 col-form-label fw-bold fs-6"">Avatar</label>
                            <div class=""col-lg-9"">
                                <div class=""image-input image-input-outline"" data-kt-image-input=""true"" style=""background-image: url(~/assets/media/avatars/blank.png)"">
                                    <div class=""image-input-wrapper w-125px h-125px""");
                BeginWriteAttribute("style", " style=\"", 1319, "\"", 1402, 4);
                WriteAttributeValue("", 1327, "background-image:", 1327, 17, true);
                WriteAttributeValue(" ", 1344, "url(/FactoryPlatform/Images/ProfilePictures/", 1345, 45, true);
#nullable restore
#line 21 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 1389, Model.Image, 1389, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1401, ")", 1401, 1, true);
                EndWriteAttribute();
                WriteLiteral(@"></div>
                                    <label class=""btn btn-icon btn-circle btn-active-color-primary w-25px h-25px bg-body shadow"" data-kt-image-input-action=""change"" data-bs-toggle=""tooltip"" title=""Change avatar"">
                                        <i class=""bi bi-pencil-fill fs-7""></i>
                                        <input type=""file"" id=""fileUpload"" name=""fileUpload"" accept="".png, .jpg, .jpeg"" />
                                    </label>
                                </div>
                                <div class=""form-text"">Allowed file types: png, jpg, jpeg.</div>
                            </div>
                        </div>
                        <div class=""row mb-6"">
                            <label class=""col-lg-3 col-form-label required fw-bold fs-6"">User</label>
                            <div class=""col-lg-9 fv-row"">
                                <input type=""text"" name=""User"" class=""form-control form-control-lg form-control-solid""");
                BeginWriteAttribute("value", " value=\"", 2410, "\"", 2432, 1);
#nullable restore
#line 33 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 2418, Model.Usuario, 2418, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled />
                            </div>
                        </div>
                        <div class=""row mb-6"">
                            <label class=""col-lg-3 col-form-label required fw-bold fs-6"">Full Name</label>
                            <div class=""col-lg-9"">
                                <div class=""row"">
                                    <div class=""col-lg-6 fv-row"">
                                        <input type=""text"" name=""fname"" class=""form-control form-control-lg form-control-solid mb-3 mb-lg-0""");
                BeginWriteAttribute("value", " value=\"", 2981, "\"", 3003, 1);
#nullable restore
#line 41 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 2989, Model.Nombres, 2989, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled />\r\n                                    </div>\r\n                                    <div class=\"col-lg-6 fv-row\">\r\n                                        <input type=\"text\" name=\"lname\" class=\"form-control form-control-lg form-control-solid\"");
                BeginWriteAttribute("value", " value=\"", 3256, "\"", 3309, 2);
#nullable restore
#line 44 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 3264, Model.ApellidoPaterno, 3264, 22, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Views\Profile\MyProfile.cshtml"
WriteAttributeValue(" ", 3286, Model.ApellidoMaterno, 3287, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""row mb-6"">
                            <label class=""col-lg-3 col-form-label required fw-bold fs-6"">Mail</label>
                            <div class=""col-lg-9 fv-row"">
                                <input type=""text"" name=""Mail"" class=""form-control form-control-lg form-control-solid""");
                BeginWriteAttribute("value", " value=\"", 3804, "\"", 3825, 1);
#nullable restore
#line 52 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 3812, Model.Correo, 3812, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled />
                            </div>
                        </div>
                        <div class=""row mb-6"">
                            <label class=""col-lg-3 col-form-label required fw-bold fs-6"">Job</label>
                            <div class=""col-lg-9 fv-row"">
                                <input type=""text"" name=""Job"" class=""form-control form-control-lg form-control-solid""");
                BeginWriteAttribute("value", " value=\"", 4234, "\"", 4255, 1);
#nullable restore
#line 58 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 4242, Model.Puesto, 4242, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled />\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 65 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Views\Profile\MyProfile.cshtml"
         if (!User.Identity.Name.Contains("@"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""card mb-5 mb-xl-10"">
                <div class=""card-header border-0 cursor-pointer"" role=""button"" data-bs-toggle=""collapse"" data-bs-target=""#kt_account_signin_method"">
                    <div class=""card-title m-0"">
                        <h3 class=""fw-bolder m-0"">Update Password</h3>
                    </div>
                </div>
                <div id=""kt_account_signin_method"" class=""collapse show"">
                    <div class=""card-body border-top p-9"">
                        <div class=""d-flex flex-wrap align-items-center mb-10"">
                            <div id=""kt_signin_password"">
                                <div class=""fs-6 fw-bolder mb-1"">Password</div>
                                <div class=""fw-bold text-gray-600"">************</div>
                            </div>
                            <div id=""kt_signin_password_edit"" class=""flex-row-fluid d-none"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3871c0639b2ce6fe0ac471a56a7b3c72e66ae8ca16296", async() => {
                WriteLiteral(@"
                                    <div class=""row mb-1"">
                                        <div class=""col-lg-3"">
                                            <div class=""fv-row mb-0"">
                                                <label for=""currentpassword"" class=""form-label fs-6 fw-bolder mb-3"">Current Password</label>
                                                <input type=""password"" class=""form-control form-control-lg form-control-solid"" name=""currentpassword"" id=""currentpassword"" minlength=""6"" />
                                            </div>
                                        </div>
                                        <div class=""col-lg-3"">
                                            <div class=""fv-row mb-0"">
                                                <label for=""newpassword"" class=""form-label fs-6 fw-bolder mb-3"">New Password</label>
                                                <input type=""password"" class=""form-control form-control-lg form-control-solid"" ");
                WriteLiteral(@"name=""newpassword"" id=""newpassword"" minlength=""6"" />
                                            </div>
                                        </div>
                                        <div class=""col-lg-3"">
                                            <div class=""fv-row mb-0"">
                                                <label for=""confirmpassword"" class=""form-label fs-6 fw-bolder mb-3"">Confirm New Password</label>
                                                <input type=""password"" class=""form-control form-control-lg form-control-solid"" name=""confirmpassword"" id=""confirmpassword"" />
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""form-text mb-5"">Password must be more than 8 characters long and contain symbols</div>
                                    <div class=""d-flex"">
                                        <button id=""kt_password_submit"" type");
                WriteLiteral(@"=""submit"" class=""btn btn-primary me-2 px-6"">Update Password</button>
                                        <button id=""kt_password_cancel"" type=""button"" class=""btn btn-color-gray-400 btn-active-light-primary px-6"" onclick=""buttonCancel()"">Cancel</button>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div id=""kt_signin_password_button"" class=""ms-auto"">
                                <button class=""btn btn-light btn-active-light-primary"" onclick=""buttonReset()"">Change Password</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 116 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Views\Profile\MyProfile.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>

        function buttonReset()
        {
            document.getElementById(""kt_signin_password_edit"").classList.remove(""d-none"");
            document.getElementById(""kt_signin_password"").classList.add(""d-none"");
            document.getElementById(""kt_signin_password_button"").classList.add(""d-none"");
            document.getElementById(""kt_signin_change_password"").reset();
            $( ""input"" ).removeClass( ""is-valid"" ).removeClass( ""is-invalid"" );
            $('[data-field]').remove();
        }

        function buttonCancel()
        {
            document.getElementById(""kt_signin_password_edit"").classList.add(""d-none"");
            document.getElementById(""kt_signin_password"").classList.remove(""d-none"");
            document.getElementById(""kt_signin_password_button"").classList.remove(""d-none"");
            document.getElementById(""kt_signin_change_password"").reset();
            $( ""input"" ).removeClass( ""is-valid"" ).removeClass( ""is-invalid"" );
            $('[data");
                WriteLiteral(@"-field]').remove();
        }


         //--------------------------------------------------------------------------------------------------------

        function updatePassword()
         {
            password = $(""#currentpassword"").val();
            newPassword = $(""#newpassword"").val();
            confirmPassword = $(""#confirmpassword"").val();

            if(currentpassword != """")
            {
                if(newPassword == confirmPassword)
                {
                    $.ajax({
                        url: """);
#nullable restore
#line 158 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Views\Profile\MyProfile.cshtml"
                         Write(Url.Action("UpdatePass","Profile"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                        data: {
                        currentpassword:password,
                        newpassword: newPassword,
                        },
                        type: 'POST',
                        beforeSend: function (xhr) {
                        xhr.setRequestHeader(""XSRF-TOKEN"",
                            $('input:hidden[name=""__RequestVerificationToken""]').val());
                        },
                        success: function(result) {
                            if(result == 'Correcto')
                            {
                               toastr.success('The Password was changed!');
                               document.getElementById(""currentpassword"").value = """";
                               document.getElementById(""newpassword"").value = """";
                               document.getElementById(""confirmpassword"").value = """";
                                $( ""input"" ).removeClass( ""is-valid"" ).removeClass( ""is-invalid"" );
             ");
                WriteLiteral(@"                   $('[data-field]').remove();
                            }
                            else if(result == 'passIncorrect')
                            {
                                $(""#currentpassword"").val("""");
                                $(""#currentpassword"").focus();
                                toastr.warning(""Actual password is incorrect!"");
                            }
                            else
                            {
                                toastr.error(result);
                            }
                        },
                        error: function() {
                              toastr.error(""An error occurred on the server, please try again later!"");
                        }
                    })
                }
                else
                {
                    toastr.error(""The new password are diferents please check that are correct.!"");
                }
            }else
            {
               ");
                WriteLiteral(@" toastr.error(""The Actual password is required !"");
            }

         }



            ""use strict"";

            // Class definition
            var KTAccountSettingsSigninMethods = function () {

                var handleChangePassword = function (e) {
                    var validation;

                    // form elements
                    var passwordForm = document.getElementById('kt_signin_change_password');

                    const strongPassword = function () {
                        return {
                            validate: function (input) {
                                const value = input.value;
                                if (value === '') {
                                    return {
                                        valid: true,
                                    };
                                }

                                // Check the password strength
                                if (value.length < 8) {
               ");
                WriteLiteral(@"                     return {
                                        valid: false,
                                        message: 'The password must be more than 8 characters long',
                                    };
                                }

                                // The password doesn't contain any uppercase character
                                if (value === value.toLowerCase()) {
                                    return {
                                        valid: false,
                                        message: 'The password must contain at least one upper case character',
                                    };
                                }

                                // The password doesn't contain any uppercase character
                                if (value === value.toUpperCase()) {
                                    return {
                                        valid: false,
                                        message: ");
                WriteLiteral(@"'The password must contain at least one lower case character',
                                    };
                                }

                                // The password doesn't contain any digit
                                if (value.search(/[0-9]/) < 0) {
                                    return {
                                        valid: false,
                                        message: 'The password must contain at least one digit',
                                    };
                                }

                                return {
                                    valid: true,
                                };
                            },
                        };
                    };

                    validation = FormValidation.formValidation(
                        passwordForm,
                        {
                            fields: {
                                currentpassword: {
                              ");
                WriteLiteral(@"      validators: {
                                        notEmpty: {
                                            message: 'Current Password is required'
                                        }
                                    }
                                },

                                newpassword: {
                                    validators: {
                                        notEmpty: {
                                            message: 'New Password is required'
                                        },
                                        checkPassword: {
                                            message: 'The password is too weak',
                                        }
                                    }
                                },

                                confirmpassword: {
                                    validators: {
                                        notEmpty: {
                                            message:");
                WriteLiteral(@" 'Confirm Password is required'
                                        },
                                        identical: {
                                            compare: function() {
                                                return passwordForm.querySelector('[name=""newpassword""]').value;
                                            },
                                            message: 'The password and its confirm are not the same'
                                        }
                                    }
                                },
                            },

                            plugins: { //Learn more: https://formvalidation.io/guide/plugins
                                trigger: new FormValidation.plugins.Trigger(),
                                bootstrap: new FormValidation.plugins.Bootstrap5({
                                    rowSelector: '.fv-row'
                                })
                            }
                        }");
                WriteLiteral(@"
                    ).registerValidator('checkPassword', strongPassword);

                    passwordForm.querySelector('#kt_password_submit').addEventListener('click', function (e) {
                        e.preventDefault();
                        console.log('click');

                        validation.validate().then(function (status) {

                            if (status == 'Valid') {
                                    updatePassword()
                                    validation.resetForm();
                            }
                            else
                            {
                                swal.fire({
                                    text: ""Sorry, looks like there are some errors detected, please try again."",
                                    icon: ""error"",
                                    buttonsStyling: false,
                                    confirmButtonText: ""Ok, got it!"",
                                    customClass: {
      ");
                WriteLiteral(@"                                  confirmButton: ""btn font-weight-bold btn-light-primary""
                                    }
                                });

                            }
                        });
                    });
                }

                // Public methods
                return {
                    init: function () {
                        handleChangePassword();
                    }
                }
            }();

            // On document ready
            KTUtil.onDOMContentLoaded(function() {
                KTAccountSettingsSigninMethods.init();
            });


        //--------------------------------------------------------------------------------

        function refresh(foto)
        {
            var num = Math.random();
            const img1 = document.getElementById(""Profile1"");
            img1.src = ""/FactoryPlatform/Images/ProfilePictures/""+foto+""?v=""+num;
            const img2 = document.getElementById(""Pr");
                WriteLiteral(@"ofile2"");
            img2.src = ""/FactoryPlatform/Images/ProfilePictures/""+foto+""?v=""+num;
        }


        //-----------------------------------------------------------------------------------------------------------

         $(""#fileUpload"").on('change', function () {

            var files = $('#fileUpload').prop(""files"");
            if($('#fileUpload').val() != """")
            {
                formData = new FormData();
                formData.append(""perfilPicture"", files[0]);
                jQuery.ajax({
                    type: 'POST',
                    url: """);
#nullable restore
#line 378 "C:\10-Ene-2023\FactoryPlatform\FactoryPlatform\Views\Profile\MyProfile.cshtml"
                     Write(Url.Action("EditPicture","Profile"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                    data: formData,
                    cache: false,
                    contentType: false,
                    processData: false,
                    beforeSend: function (xhr) {
                        xhr.setRequestHeader(""XSRF-TOKEN"",
                            $('input:hidden[name=""__RequestVerificationToken""]').val());
                    },
                    success: function (result) {

                        if(result != null)
                        {
                            const img1 = document.getElementById(""Profile1"");
                            img1.src = ""~/Images/ProfilePictures/blank.png"";
                            const img2 = document.getElementById(""Profile2"");
                            img2.src = ""~/Images/ProfilePictures/blank.png"";
                            formData = new FormData();

                            refresh(result);

                            toastr.success(""Picture was saved!"");
                        }
     ");
                WriteLiteral(@"                   else
                        {
                            toastr.warning(""Picture format not validate!"");
                        }
                    },
                    error: function() {
                        toastr.error(""An error occurred on the server, please try again later!"");
                    }
                });
            }

        });
    //---------------------------------------------------------------------------------------------------------------
</script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserProfile> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
