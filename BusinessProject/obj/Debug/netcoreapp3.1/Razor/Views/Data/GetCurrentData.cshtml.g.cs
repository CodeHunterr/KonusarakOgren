#pragma checksum "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fcec523f47ef0007ff60fbba329194e441e7a97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Data_GetCurrentData), @"mvc.1.0.view", @"/Views/Data/GetCurrentData.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fcec523f47ef0007ff60fbba329194e441e7a97", @"/Views/Data/GetCurrentData.cshtml")]
    public class Views_Data_GetCurrentData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusinessProject.Models.DataModels>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
  
    ViewData["Title"] = "GetCurrentData";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"panel panel-green\">\r\n\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
         using (Html.BeginForm("GetCurrentData", "Data", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"panel-body\" style=\"padding-left: 15px\">\r\n                <div class=\"row\" style=\"padding-left: 400px\">\r\n                    <div class=\"form-group col-md-6\">                        \r\n                        ");
#nullable restore
#line 19 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                   Write(Html.DropDownListFor(m => m.title.id, Model.titleSelectList, new { @id = "drpTitles", @class = "form-control", style = "width:570px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 20 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                   Write(Html.ValidationMessageFor(m => m.title.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\" style=\"padding-left: 400px\">\r\n                    <div class=\"form-group col-md-6\">\r\n\r\n\r\n                        ");
#nullable restore
#line 27 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                   Write(Html.TextAreaFor(m => m.content.content, 10, 80, new { htmlAttributes = new { @id = "txtDescription", @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n                        ");
#nullable restore
#line 32 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                   Write(Html.ValidationMessageFor(m => m.content.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div style=\"padding-left: 400px\">\r\n\r\n                    <div class=\"row\">\r\n                        <div class=\"form-group col-md-6\">\r\n                            ");
#nullable restore
#line 39 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.TextBoxFor(m => m.question1.question, new { style = "width:600px; height:35px; margin-right:auto;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 40 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.ValidationMessageFor(m => m.question1.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"form-group col-md-3\">\r\n                            ");
#nullable restore
#line 45 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.TextBoxFor(m => m.question1.aChoise, new { style = "width:275px; height:35px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 46 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.ValidationMessageFor(m => m.question1.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n\r\n                        <div class=\"form-group col-md-3\" style=\"padding-left: 152px\">\r\n                            ");
#nullable restore
#line 51 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.TextBoxFor(m => m.question1.bChoise, new { style = "width:275px; height:35px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 52 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.ValidationMessageFor(m => m.question1.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"form-group col-md-3\">\r\n                            ");
#nullable restore
#line 57 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.TextBoxFor(m => m.question1.cChoise, new { style = "width:275px; height:35px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 58 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.ValidationMessageFor(m => m.question1.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n\r\n                        <div class=\"form-group col-md-3\" style=\"padding-left: 152px\">\r\n                            ");
#nullable restore
#line 63 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.TextBoxFor(m => m.question1.dChoise, new { style = "width:275px; height:35px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 64 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.ValidationMessageFor(m => m.question1.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\" style=\"padding-left: 225px\">\r\n                        <div class=\"form-group col-md-6\">\r\n\r\n                            ");
#nullable restore
#line 70 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.DropDownListFor(m => m.question1.trueAnswer1, new List<SelectListItem>
                                {
                                new SelectListItem { Text = "A", Value = "1" },
                                new SelectListItem { Text = "B", Value = "2" },
                                new SelectListItem { Text = "C", Value = "3" },
                                new SelectListItem { Text = "D", Value = "4" },

                                }, "Doğru Cevap Seç"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 78 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.ValidationMessageFor(m => m.question1.trueAnswer1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <br />\r\n\r\n                    <div class=\"row\">\r\n                        <div class=\"form-group col-md-6\">\r\n                            ");
#nullable restore
#line 85 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.TextBoxFor(m => m.question2.question, new { style = "width:600px; height:35px; margin-right:auto;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 86 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.ValidationMessageFor(m => m.question2.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"form-group col-md-3\">\r\n                            ");
#nullable restore
#line 91 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.TextBoxFor(m => m.question2.aChoise, new { style = "width:275px; height:35px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 92 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.ValidationMessageFor(m => m.question2.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n\r\n                        <div class=\"form-group col-md-3\" style=\"padding-left: 152px\">\r\n                            ");
#nullable restore
#line 97 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.TextBoxFor(m => m.question2.bChoise, new { style = "width:275px; height:35px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 98 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.ValidationMessageFor(m => m.question2.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"form-group col-md-3\">\r\n                            ");
#nullable restore
#line 103 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.TextBoxFor(m => m.question2.cChoise, new { style = "width:275px; height:35px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 104 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.ValidationMessageFor(m => m.question2.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n\r\n                        <div class=\"form-group col-md-3\" style=\"padding-left: 152px\">\r\n                            ");
#nullable restore
#line 109 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.TextBoxFor(m => m.question2.dChoise, new { style = "width:275px; height:35px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 110 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.ValidationMessageFor(m => m.question2.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\" style=\"padding-left: 225px\">\r\n                        <div class=\"form-group col-md-6\">\r\n\r\n                            ");
#nullable restore
#line 116 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.DropDownListFor(m => m.question2.trueAnswer2, new List<SelectListItem>
                                {
                                new SelectListItem { Text = "A", Value = "1" },
                                new SelectListItem { Text = "B", Value = "2" },
                                new SelectListItem { Text = "C", Value = "3" },
                                new SelectListItem { Text = "D", Value = "4" },

                                }, "Doğru Cevap Seç"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 124 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.ValidationMessageFor(m => m.question2.trueAnswer2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <br />\r\n\r\n                    <div class=\"row\">\r\n                        <div class=\"form-group col-md-6\">\r\n                            ");
#nullable restore
#line 131 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.TextBoxFor(m => m.question3.question, new { style = "width:600px; height:35px; margin-right:auto;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 132 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.ValidationMessageFor(m => m.question3.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"form-group col-md-3\">\r\n                            ");
#nullable restore
#line 137 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.TextBoxFor(m => m.question3.aChoise, new { style = "width:275px; height:35px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 138 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.ValidationMessageFor(m => m.question3.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n\r\n                        <div class=\"form-group col-md-3\" style=\"padding-left: 152px\">\r\n                            ");
#nullable restore
#line 143 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.TextBoxFor(m => m.question3.bChoise, new { style = "width:275px; height:35px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 144 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.ValidationMessageFor(m => m.question3.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"form-group col-md-3\">\r\n                            ");
#nullable restore
#line 149 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.TextBoxFor(m => m.question3.cChoise, new { style = "width:275px; height:35px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 150 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.ValidationMessageFor(m => m.question3.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n\r\n                        <div class=\"form-group col-md-3\" style=\"padding-left: 152px\">\r\n                            ");
#nullable restore
#line 155 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.TextBoxFor(m => m.question3.dChoise, new { style = "width:275px; height:35px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 156 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.ValidationMessageFor(m => m.question3.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\" style=\"padding-left: 225px\">\r\n                        <div class=\"form-group col-md-6\">\r\n\r\n                            ");
#nullable restore
#line 162 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.DropDownListFor(m => m.question3.trueAnswer3, new List<SelectListItem>
                                {
                                new SelectListItem { Text = "A", Value = "1" },
                                new SelectListItem { Text = "B", Value = "2" },
                                new SelectListItem { Text = "C", Value = "3" },
                                new SelectListItem { Text = "D", Value = "4" },

                                }, "Doğru Cevap Seç"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 170 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.ValidationMessageFor(m => m.question3.trueAnswer3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <br />\r\n\r\n                    <div class=\"row\">\r\n                        <div class=\"form-group col-md-6\">\r\n                            ");
#nullable restore
#line 177 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.TextBoxFor(m => m.question4.question, new { style = "width:600px; height:35px; margin-right:auto;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 178 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.ValidationMessageFor(m => m.question4.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"form-group col-md-3\">\r\n                            ");
#nullable restore
#line 183 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.TextBoxFor(m => m.question4.aChoise, new { style = "width:275px; height:35px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 184 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.ValidationMessageFor(m => m.question4.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n\r\n                        <div class=\"form-group col-md-3\" style=\"padding-left: 152px\">\r\n                            ");
#nullable restore
#line 189 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.TextBoxFor(m => m.question4.bChoise, new { style = "width:275px; height:35px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 190 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.ValidationMessageFor(m => m.question4.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"form-group col-md-3\">\r\n                            ");
#nullable restore
#line 195 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.TextBoxFor(m => m.question4.cChoise, new { style = "width:275px; height:35px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 196 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.ValidationMessageFor(m => m.question4.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n\r\n                        <div class=\"form-group col-md-3\" style=\"padding-left: 152px\">\r\n                            ");
#nullable restore
#line 201 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.TextBoxFor(m => m.question4.dChoise, new { style = "width:275px; height:35px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 202 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.ValidationMessageFor(m => m.question4.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\" style=\"padding-left: 225px\">\r\n                        <div class=\"form-group col-md-6\">\r\n\r\n                            ");
#nullable restore
#line 208 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.DropDownListFor(m => m.question4.trueAnswer4, new List<SelectListItem>
                                {
                                new SelectListItem { Text = "A", Value = "1" },
                                new SelectListItem { Text = "B", Value = "2" },
                                new SelectListItem { Text = "C", Value = "3" },
                                new SelectListItem { Text = "D", Value = "4" },

                                }, "Doğru Cevap Seç"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 216 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
                       Write(Html.ValidationMessageFor(m => m.question4.trueAnswer4));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <br />

                </div>

                <div class=""row"" style=""padding-left:630px;"">
                    <button type=""submit"" style=""background-color: green;border: none;color: white;padding: 15px 32px;text-align: center;text-decoration: none;display: inline-block;font-size: 16px;margin: 4px 2px;cursor: pointer;border-radius: 10px;"">Sınavı Oluştur</button>
                </div>
            </div>
");
#nullable restore
#line 227 "C:\Users\Atakan\source\repos\BusinessProject\BusinessProject\Views\Data\GetCurrentData.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    </div>
</div>

<script>
    $(document).ready(function () {

        $(""#drpTitles"").change(function () {

            var drpTitlesId = $(""#drpTitles option:selected"").val();
            console.log(drpTitlesId);
            $.ajax({
                url: ""/Data/GetDescription"",
                data: { 'titleId': drpTitlesId },
                method: ""POST"",
                success: function (response) {

                }
            });

        });

    });
</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusinessProject.Models.DataModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
