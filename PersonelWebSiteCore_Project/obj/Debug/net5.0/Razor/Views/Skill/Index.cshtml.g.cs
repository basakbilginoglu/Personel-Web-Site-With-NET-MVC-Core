#pragma checksum "C:\Users\developer\source\repos\PersonelWebSiteCore_Project\PersonelWebSiteCore_Project\Views\Skill\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49f3818dc94c79f805e22e5f45a117ce47313a05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_Index), @"mvc.1.0.view", @"/Views/Skill/Index.cshtml")]
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
#line 1 "C:\Users\developer\source\repos\PersonelWebSiteCore_Project\PersonelWebSiteCore_Project\Views\_ViewImports.cshtml"
using PersonelWebSiteCore_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\developer\source\repos\PersonelWebSiteCore_Project\PersonelWebSiteCore_Project\Views\_ViewImports.cshtml"
using PersonelWebSiteCore_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49f3818dc94c79f805e22e5f45a117ce47313a05", @"/Views/Skill/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f61458568aa5194584055732b52b86bd9ade6dde", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Skill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\developer\source\repos\PersonelWebSiteCore_Project\PersonelWebSiteCore_Project\Views\Skill\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card-header border-0"">
              <h3 class=""mb-0"">Light table</h3>
            </div>
            <!-- Light table -->
            <div class=""table-responsive"">
              <table class=""table align-items-center table-flush"">
                <thead class=""thead-light"">
                  <tr>
                    <th scope=""col"" class=""sort"" data-sort=""name"">Project</th>
                    <th scope=""col"" class=""sort"" data-sort=""budget"">Budget</th>
                    <th scope=""col"" class=""sort"" data-sort=""status"">Status</th>
                    <th scope=""col"">Users</th>
                    <th scope=""col"" class=""sort"" data-sort=""completion"">Completion</th>
                    <th scope=""col""></th>
                  </tr>
                </thead>
                <tbody class=""list"">
                  <tr>
                    <th scope=""row"">
                      <div class=""media align-items-center"">
                        <a href=""#"" class=""avatar rounded-circle mr");
            WriteLiteral(@"-3"">
                          <img alt=""Image placeholder"" src=""../assets/img/theme/bootstrap.jpg"">
                        </a>
                        <div class=""media-body"">
                          <span class=""name mb-0 text-sm"">Argon Design System</span>
                        </div>
                      </div>
                    </th>
                    <td class=""budget"">
                      $2500 USD
                    </td>
                    <td>
                      <span class=""badge badge-dot mr-4"">
                        <i class=""bg-warning""></i>
                        <span class=""status"">pending</span>
                      </span>
                    </td>
                    <td>
                      <div class=""avatar-group"">
                        <a href=""#"" class=""avatar avatar-sm rounded-circle"" data-toggle=""tooltip"" data-original-title=""Ryan Tompson"">
                          <img alt=""Image placeholder"" src=""../assets/img/theme/team-1.jpg"">
    ");
            WriteLiteral(@"                    </a>
                        <a href=""#"" class=""avatar avatar-sm rounded-circle"" data-toggle=""tooltip"" data-original-title=""Romina Hadid"">
                          <img alt=""Image placeholder"" src=""../assets/img/theme/team-2.jpg"">
                        </a>
                        <a href=""#"" class=""avatar avatar-sm rounded-circle"" data-toggle=""tooltip"" data-original-title=""Alexander Smith"">
                          <img alt=""Image placeholder"" src=""../assets/img/theme/team-3.jpg"">
                        </a>
                        <a href=""#"" class=""avatar avatar-sm rounded-circle"" data-toggle=""tooltip"" data-original-title=""Jessica Doe"">
                          <img alt=""Image placeholder"" src=""../assets/img/theme/team-4.jpg"">
                        </a>
                      </div>
                    </td>
                    <td>
                      <div class=""d-flex align-items-center"">
                        <span class=""completion mr-2"">60%</span>
       ");
            WriteLiteral(@"                 <div>
                          <div class=""progress"">
                            <div class=""progress-bar bg-warning"" role=""progressbar"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 60%;""></div>
                          </div>
                        </div>
                      </div>
                    </td>
                    <td class=""text-right"">
                      <div class=""dropdown"">
                        <a class=""btn btn-sm btn-icon-only text-light"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                          <i class=""fas fa-ellipsis-v""></i>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right dropdown-menu-arrow"">
                          <a class=""dropdown-item"" href=""#"">Action</a>
                          <a class=""dropdown-item"" href=""#"">Another action</a>
                          <a class=""dropdown-item"" href=""#"">Something");
            WriteLiteral(@" else here</a>
                        </div>
                      </div>
                    </td>
                  </tr>
                  <tr>
                    <th scope=""row"">
                      <div class=""media align-items-center"">
                        <a href=""#"" class=""avatar rounded-circle mr-3"">
                          <img alt=""Image placeholder"" src=""../assets/img/theme/angular.jpg"">
                        </a>
                        <div class=""media-body"">
                          <span class=""name mb-0 text-sm"">Angular Now UI Kit PRO</span>
                        </div>
                      </div>
                    </th>
                    <td class=""budget"">
                      $1800 USD
                    </td>
                    <td>
                      <span class=""badge badge-dot mr-4"">
                        <i class=""bg-success""></i>
                        <span class=""status"">completed</span>
                      </span>
            ");
            WriteLiteral(@"        </td>
                    <td>
                      <div class=""avatar-group"">
                        <a href=""#"" class=""avatar avatar-sm rounded-circle"" data-toggle=""tooltip"" data-original-title=""Ryan Tompson"">
                          <img alt=""Image placeholder"" src=""../assets/img/theme/team-1.jpg"">
                        </a>
                        <a href=""#"" class=""avatar avatar-sm rounded-circle"" data-toggle=""tooltip"" data-original-title=""Romina Hadid"">
                          <img alt=""Image placeholder"" src=""../assets/img/theme/team-2.jpg"">
                        </a>
                        <a href=""#"" class=""avatar avatar-sm rounded-circle"" data-toggle=""tooltip"" data-original-title=""Alexander Smith"">
                          <img alt=""Image placeholder"" src=""../assets/img/theme/team-3.jpg"">
                        </a>
                        <a href=""#"" class=""avatar avatar-sm rounded-circle"" data-toggle=""tooltip"" data-original-title=""Jessica Doe"">
                   ");
            WriteLiteral(@"       <img alt=""Image placeholder"" src=""../assets/img/theme/team-4.jpg"">
                        </a>
                      </div>
                    </td>
                    <td>
                      <div class=""d-flex align-items-center"">
                        <span class=""completion mr-2"">100%</span>
                        <div>
                          <div class=""progress"">
                            <div class=""progress-bar bg-success"" role=""progressbar"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 100%;""></div>
                          </div>
                        </div>
                      </div>
                    </td>
                    <td class=""text-right"">
                      <div class=""dropdown"">
                        <a class=""btn btn-sm btn-icon-only text-light"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                          <i class=""fas fa-ellipsis-v""></i>
                 ");
            WriteLiteral(@"       </a>
                        <div class=""dropdown-menu dropdown-menu-right dropdown-menu-arrow"">
                          <a class=""dropdown-item"" href=""#"">Action</a>
                          <a class=""dropdown-item"" href=""#"">Another action</a>
                          <a class=""dropdown-item"" href=""#"">Something else here</a>
                        </div>
                      </div>
                    </td>
                  </tr>
                  <tr>
                    <th scope=""row"">
                      <div class=""media align-items-center"">
                        <a href=""#"" class=""avatar rounded-circle mr-3"">
                          <img alt=""Image placeholder"" src=""../assets/img/theme/sketch.jpg"">
                        </a>
                        <div class=""media-body"">
                          <span class=""name mb-0 text-sm"">Black Dashboard</span>
                        </div>
                      </div>
                    </th>
                    <td c");
            WriteLiteral(@"lass=""budget"">
                      $3150 USD
                    </td>
                    <td>
                      <span class=""badge badge-dot mr-4"">
                        <i class=""bg-danger""></i>
                        <span class=""status"">delayed</span>
                      </span>
                    </td>
                    <td>
                      <div class=""avatar-group"">
                        <a href=""#"" class=""avatar avatar-sm rounded-circle"" data-toggle=""tooltip"" data-original-title=""Ryan Tompson"">
                          <img alt=""Image placeholder"" src=""../assets/img/theme/team-1.jpg"">
                        </a>
                        <a href=""#"" class=""avatar avatar-sm rounded-circle"" data-toggle=""tooltip"" data-original-title=""Romina Hadid"">
                          <img alt=""Image placeholder"" src=""../assets/img/theme/team-2.jpg"">
                        </a>
                        <a href=""#"" class=""avatar avatar-sm rounded-circle"" data-toggle=""tooltip"" d");
            WriteLiteral(@"ata-original-title=""Alexander Smith"">
                          <img alt=""Image placeholder"" src=""../assets/img/theme/team-3.jpg"">
                        </a>
                        <a href=""#"" class=""avatar avatar-sm rounded-circle"" data-toggle=""tooltip"" data-original-title=""Jessica Doe"">
                          <img alt=""Image placeholder"" src=""../assets/img/theme/team-4.jpg"">
                        </a>
                      </div>
                    </td>
                    <td>
                      <div class=""d-flex align-items-center"">
                        <span class=""completion mr-2"">72%</span>
                        <div>
                          <div class=""progress"">
                            <div class=""progress-bar bg-danger"" role=""progressbar"" aria-valuenow=""72"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 72%;""></div>
                          </div>
                        </div>
                      </div>
                    </td>
                   ");
            WriteLiteral(@" <td class=""text-right"">
                      <div class=""dropdown"">
                        <a class=""btn btn-sm btn-icon-only text-light"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                          <i class=""fas fa-ellipsis-v""></i>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right dropdown-menu-arrow"">
                          <a class=""dropdown-item"" href=""#"">Action</a>
                          <a class=""dropdown-item"" href=""#"">Another action</a>
                          <a class=""dropdown-item"" href=""#"">Something else here</a>
                        </div>
                      </div>
                    </td>
                  </tr>
                  <tr>
                    <th scope=""row"">
                      <div class=""media align-items-center"">
                        <a href=""#"" class=""avatar rounded-circle mr-3"">
                          <img alt=""Image placeholder"" src");
            WriteLiteral(@"=""../assets/img/theme/react.jpg"">
                        </a>
                        <div class=""media-body"">
                          <span class=""name mb-0 text-sm"">React Material Dashboard</span>
                        </div>
                      </div>
                    </th>
                    <td class=""budget"">
                      $4400 USD
                    </td>
                    <td>
                      <span class=""badge badge-dot mr-4"">
                        <i class=""bg-info""></i>
                        <span class=""status"">on schedule</span>
                      </span>
                    </td>
                    <td>
                      <div class=""avatar-group"">
                        <a href=""#"" class=""avatar avatar-sm rounded-circle"" data-toggle=""tooltip"" data-original-title=""Ryan Tompson"">
                          <img alt=""Image placeholder"" src=""../assets/img/theme/team-1.jpg"">
                        </a>
                        <a href=""#"" ");
            WriteLiteral(@"class=""avatar avatar-sm rounded-circle"" data-toggle=""tooltip"" data-original-title=""Romina Hadid"">
                          <img alt=""Image placeholder"" src=""../assets/img/theme/team-2.jpg"">
                        </a>
                        <a href=""#"" class=""avatar avatar-sm rounded-circle"" data-toggle=""tooltip"" data-original-title=""Alexander Smith"">
                          <img alt=""Image placeholder"" src=""../assets/img/theme/team-3.jpg"">
                        </a>
                        <a href=""#"" class=""avatar avatar-sm rounded-circle"" data-toggle=""tooltip"" data-original-title=""Jessica Doe"">
                          <img alt=""Image placeholder"" src=""../assets/img/theme/team-4.jpg"">
                        </a>
                      </div>
                    </td>
                    <td>
                      <div class=""d-flex align-items-center"">
                        <span class=""completion mr-2"">90%</span>
                        <div>
                          <div class=""");
            WriteLiteral(@"progress"">
                            <div class=""progress-bar bg-info"" role=""progressbar"" aria-valuenow=""90"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 90%;""></div>
                          </div>
                        </div>
                      </div>
                    </td>
                    <td class=""text-right"">
                      <div class=""dropdown"">
                        <a class=""btn btn-sm btn-icon-only text-light"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                          <i class=""fas fa-ellipsis-v""></i>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right dropdown-menu-arrow"">
                          <a class=""dropdown-item"" href=""#"">Action</a>
                          <a class=""dropdown-item"" href=""#"">Another action</a>
                          <a class=""dropdown-item"" href=""#"">Something else here</a>
                        </div>
                 ");
            WriteLiteral(@"     </div>
                    </td>
                  </tr>
                  <tr>
                    <th scope=""row"">
                      <div class=""media align-items-center"">
                        <a href=""#"" class=""avatar rounded-circle mr-3"">
                          <img alt=""Image placeholder"" src=""../assets/img/theme/vue.jpg"">
                        </a>
                        <div class=""media-body"">
                          <span class=""name mb-0 text-sm"">Vue Paper UI Kit PRO</span>
                        </div>
                      </div>
                    </th>
                    <td class=""budget"">
                      $2200 USD
                    </td>
                    <td>
                      <span class=""badge badge-dot mr-4"">
                        <i class=""bg-success""></i>
                        <span class=""status"">completed</span>
                      </span>
                    </td>
                    <td>
                      <div cla");
            WriteLiteral(@"ss=""avatar-group"">
                        <a href=""#"" class=""avatar avatar-sm rounded-circle"" data-toggle=""tooltip"" data-original-title=""Ryan Tompson"">
                          <img alt=""Image placeholder"" src=""../assets/img/theme/team-1.jpg"">
                        </a>
                        <a href=""#"" class=""avatar avatar-sm rounded-circle"" data-toggle=""tooltip"" data-original-title=""Romina Hadid"">
                          <img alt=""Image placeholder"" src=""../assets/img/theme/team-2.jpg"">
                        </a>
                        <a href=""#"" class=""avatar avatar-sm rounded-circle"" data-toggle=""tooltip"" data-original-title=""Alexander Smith"">
                          <img alt=""Image placeholder"" src=""../assets/img/theme/team-3.jpg"">
                        </a>
                        <a href=""#"" class=""avatar avatar-sm rounded-circle"" data-toggle=""tooltip"" data-original-title=""Jessica Doe"">
                          <img alt=""Image placeholder"" src=""../assets/img/theme/team-4.jpg");
            WriteLiteral(@""">
                        </a>
                      </div>
                    </td>
                    <td>
                      <div class=""d-flex align-items-center"">
                        <span class=""completion mr-2"">100%</span>
                        <div>
                          <div class=""progress"">
                            <div class=""progress-bar bg-success"" role=""progressbar"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 100%;""></div>
                          </div>
                        </div>
                      </div>
                    </td>
                    <td class=""text-right"">
                      <div class=""dropdown"">
                        <a class=""btn btn-sm btn-icon-only text-light"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                          <i class=""fas fa-ellipsis-v""></i>
                        </a>
                        <div class=""dropdown-menu dropdown");
            WriteLiteral(@"-menu-right dropdown-menu-arrow"">
                          <a class=""dropdown-item"" href=""#"">Action</a>
                          <a class=""dropdown-item"" href=""#"">Another action</a>
                          <a class=""dropdown-item"" href=""#"">Something else here</a>
                        </div>
                      </div>
                    </td>
                  </tr>
                </tbody>
              </table>
            </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
