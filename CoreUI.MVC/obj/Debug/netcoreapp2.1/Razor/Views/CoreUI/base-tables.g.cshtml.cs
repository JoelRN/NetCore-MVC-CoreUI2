#pragma checksum "D:\GitHub\NetCore-MVC-CoreUI2\CoreUI.MVC\Views\CoreUI\base-tables.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffdb375b8f0360934973a73c9adf32053ab1060a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CoreUI_base_tables), @"mvc.1.0.view", @"/Views/CoreUI/base-tables.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CoreUI/base-tables.cshtml", typeof(AspNetCore.Views_CoreUI_base_tables))]
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
#line 1 "D:\GitHub\NetCore-MVC-CoreUI2\CoreUI.MVC\Views\_ViewImports.cshtml"
using CoreUI.MVC;

#line default
#line hidden
#line 2 "D:\GitHub\NetCore-MVC-CoreUI2\CoreUI.MVC\Views\_ViewImports.cshtml"
using CoreUI.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffdb375b8f0360934973a73c9adf32053ab1060a", @"/Views/CoreUI/base-tables.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0446120a3c9768b04ff461bd5d5d2c67627e18d9", @"/Views/_ViewImports.cshtml")]
    public class Views_CoreUI_base_tables : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 12572, true);
            WriteLiteral(@"<div class=""row"">
  <div class=""col-lg-6"">
    <div class=""card"">
      <div class=""card-header"">
        <i class=""fa fa-align-justify""></i> Simple Table
      </div>
      <div class=""card-body"">
        <table class=""table table-responsive-sm"">
          <thead>
            <tr>
              <th>Username</th>
              <th>Date registered</th>
              <th>Role</th>
              <th>Status</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td>Samppa Nori</td>
              <td>2012/01/01</td>
              <td>Member</td>
              <td>
                <span class=""badge badge-success"">Active</span>
              </td>
            </tr>
            <tr>
              <td>Estavan Lykos</td>
              <td>2012/02/01</td>
              <td>Staff</td>
              <td>
                <span class=""badge badge-danger"">Banned</span>
              </td>
            </tr>
            <tr>
              <td>Chetan Mohamed");
            WriteLiteral(@"</td>
              <td>2012/02/01</td>
              <td>Admin</td>
              <td>
                <span class=""badge badge-secondary"">Inactive</span>
              </td>
            </tr>
            <tr>
              <td>Derick Maximinus</td>
              <td>2012/03/01</td>
              <td>Member</td>
              <td>
                <span class=""badge badge-warning"">Pending</span>
              </td>
            </tr>
            <tr>
              <td>Friderik Dávid</td>
              <td>2012/01/21</td>
              <td>Staff</td>
              <td>
                <span class=""badge badge-success"">Active</span>
              </td>
            </tr>
          </tbody>
        </table>
        <ul class=""pagination"">
          <li class=""page-item"">
            <a class=""page-link"" href=""#"">Prev</a>
          </li>
          <li class=""page-item active"">
            <a class=""page-link"" href=""#"">1</a>
          </li>
          <li class=""page-item"">
          ");
            WriteLiteral(@"  <a class=""page-link"" href=""#"">2</a>
          </li>
          <li class=""page-item"">
            <a class=""page-link"" href=""#"">3</a>
          </li>
          <li class=""page-item"">
            <a class=""page-link"" href=""#"">4</a>
          </li>
          <li class=""page-item"">
            <a class=""page-link"" href=""#"">Next</a>
          </li>
        </ul>
      </div>
    </div>
  </div>
  <!--/.col-->

  <div class=""col-lg-6"">
    <div class=""card"">
      <div class=""card-header"">
        <i class=""fa fa-align-justify""></i> Striped Table
      </div>
      <div class=""card-body"">
        <table class=""table table-responsive-sm table-striped"">
          <thead>
            <tr>
              <th>Username</th>
              <th>Date registered</th>
              <th>Role</th>
              <th>Status</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td>Yiorgos Avraamu</td>
              <td>2012/01/01</td>
              <td>Membe");
            WriteLiteral(@"r</td>
              <td>
                <span class=""badge badge-success"">Active</span>
              </td>
            </tr>
            <tr>
              <td>Avram Tarasios</td>
              <td>2012/02/01</td>
              <td>Staff</td>
              <td>
                <span class=""badge badge-danger"">Banned</span>
              </td>
            </tr>
            <tr>
              <td>Quintin Ed</td>
              <td>2012/02/01</td>
              <td>Admin</td>
              <td>
                <span class=""badge badge-secondary"">Inactive</span>
              </td>
            </tr>
            <tr>
              <td>Enéas Kwadwo</td>
              <td>2012/03/01</td>
              <td>Member</td>
              <td>
                <span class=""badge badge-warning"">Pending</span>
              </td>
            </tr>
            <tr>
              <td>Agapetus Tadeáš</td>
              <td>2012/01/21</td>
              <td>Staff</td>
              <td>
        ");
            WriteLiteral(@"        <span class=""badge badge-success"">Active</span>
              </td>
            </tr>
          </tbody>
        </table>
        <ul class=""pagination"">
          <li class=""page-item"">
            <a class=""page-link"" href=""#"">Prev</a>
          </li>
          <li class=""page-item active"">
            <a class=""page-link"" href=""#"">1</a>
          </li>
          <li class=""page-item"">
            <a class=""page-link"" href=""#"">2</a>
          </li>
          <li class=""page-item"">
            <a class=""page-link"" href=""#"">3</a>
          </li>
          <li class=""page-item"">
            <a class=""page-link"" href=""#"">4</a>
          </li>
          <li class=""page-item"">
            <a class=""page-link"" href=""#"">Next</a>
          </li>
        </ul>
      </div>
    </div>
  </div>
  <!--/.col-->
</div>
<!--/.row-->

<div class=""row"">

  <div class=""col-lg-6"">
    <div class=""card"">
      <div class=""card-header"">
        <i class=""fa fa-align-justify""></i> Cond");
            WriteLiteral(@"ensed Table
      </div>
      <div class=""card-body"">
        <table class=""table table-responsive-sm table-sm"">
          <thead>
            <tr>
              <th>Username</th>
              <th>Date registered</th>
              <th>Role</th>
              <th>Status</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td>Carwyn Fachtna</td>
              <td>2012/01/01</td>
              <td>Member</td>
              <td>
                <span class=""badge badge-success"">Active</span>
              </td>
            </tr>
            <tr>
              <td>Nehemiah Tatius</td>
              <td>2012/02/01</td>
              <td>Staff</td>
              <td>
                <span class=""badge badge-danger"">Banned</span>
              </td>
            </tr>
            <tr>
              <td>Ebbe Gemariah</td>
              <td>2012/02/01</td>
              <td>Admin</td>
              <td>
                <span class=""badge badge-s");
            WriteLiteral(@"econdary"">Inactive</span>
              </td>
            </tr>
            <tr>
              <td>Eustorgios Amulius</td>
              <td>2012/03/01</td>
              <td>Member</td>
              <td>
                <span class=""badge badge-warning"">Pending</span>
              </td>
            </tr>
            <tr>
              <td>Leopold Gáspár</td>
              <td>2012/01/21</td>
              <td>Staff</td>
              <td>
                <span class=""badge badge-success"">Active</span>
              </td>
            </tr>
          </tbody>
        </table>
        <ul class=""pagination"">
          <li class=""page-item"">
            <a class=""page-link"" href=""#"">Prev</a>
          </li>
          <li class=""page-item active"">
            <a class=""page-link"" href=""#"">1</a>
          </li>
          <li class=""page-item"">
            <a class=""page-link"" href=""#"">2</a>
          </li>
          <li class=""page-item"">
            <a class=""page-link"" href=""#"">");
            WriteLiteral(@"3</a>
          </li>
          <li class=""page-item"">
            <a class=""page-link"" href=""#"">4</a>
          </li>
          <li class=""page-item"">
            <a class=""page-link"" href=""#"">Next</a>
          </li>
        </ul>
      </div>
    </div>
  </div>
  <!--/.col-->

  <div class=""col-lg-6"">
    <div class=""card"">
      <div class=""card-header"">
        <i class=""fa fa-align-justify""></i> Bordered Table
      </div>
      <div class=""card-body"">
        <table class=""table table-responsive-sm table-bordered"">
          <thead>
            <tr>
              <th>Username</th>
              <th>Date registered</th>
              <th>Role</th>
              <th>Status</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td>Pompeius René</td>
              <td>2012/01/01</td>
              <td>Member</td>
              <td>
                <span class=""badge badge-success"">Active</span>
              </td>
            </tr>");
            WriteLiteral(@"
            <tr>
              <td>Paĉjo Jadon</td>
              <td>2012/02/01</td>
              <td>Staff</td>
              <td>
                <span class=""badge badge-danger"">Banned</span>
              </td>
            </tr>
            <tr>
              <td>Micheal Mercurius</td>
              <td>2012/02/01</td>
              <td>Admin</td>
              <td>
                <span class=""badge badge-secondary"">Inactive</span>
              </td>
            </tr>
            <tr>
              <td>Ganesha Dubhghall</td>
              <td>2012/03/01</td>
              <td>Member</td>
              <td>
                <span class=""badge badge-warning"">Pending</span>
              </td>
            </tr>
            <tr>
              <td>Hiroto Šimun</td>
              <td>2012/01/21</td>
              <td>Staff</td>
              <td>
                <span class=""badge badge-success"">Active</span>
              </td>
            </tr>
          </tbody>
        <");
            WriteLiteral(@"/table>
        <ul class=""pagination"">
          <li class=""page-item"">
            <a class=""page-link"" href=""#"">Prev</a>
          </li>
          <li class=""page-item active"">
            <a class=""page-link"" href=""#"">1</a>
          </li>
          <li class=""page-item"">
            <a class=""page-link"" href=""#"">2</a>
          </li>
          <li class=""page-item"">
            <a class=""page-link"" href=""#"">3</a>
          </li>
          <li class=""page-item"">
            <a class=""page-link"" href=""#"">4</a>
          </li>
          <li class=""page-item"">
            <a class=""page-link"" href=""#"">Next</a>
          </li>
        </ul>
      </div>
    </div>
  </div>
  <!--/.col-->

</div>
<!--/.row-->

<div class=""row"">
  <div class=""col-lg-12"">
    <div class=""card"">
      <div class=""card-header"">
        <i class=""fa fa-align-justify""></i> Combined All Table
      </div>
      <div class=""card-body"">
        <table class=""table table-responsive-sm table-bordered t");
            WriteLiteral(@"able-striped table-sm"">
          <thead>
            <tr>
              <th>Username</th>
              <th>Date registered</th>
              <th>Role</th>
              <th>Status</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td>Vishnu Serghei</td>
              <td>2012/01/01</td>
              <td>Member</td>
              <td>
                <span class=""badge badge-success"">Active</span>
              </td>
            </tr>
            <tr>
              <td>Zbyněk Phoibos</td>
              <td>2012/02/01</td>
              <td>Staff</td>
              <td>
                <span class=""badge badge-danger"">Banned</span>
              </td>
            </tr>
            <tr>
              <td>Einar Randall</td>
              <td>2012/02/01</td>
              <td>Admin</td>
              <td>
                <span class=""badge badge-secondary"">Inactive</span>
              </td>
            </tr>
            <tr>
         ");
            WriteLiteral(@"     <td>Félix Troels</td>
              <td>2012/03/01</td>
              <td>Member</td>
              <td>
                <span class=""badge badge-warning"">Pending</span>
              </td>
            </tr>
            <tr>
              <td>Aulus Agmundr</td>
              <td>2012/01/21</td>
              <td>Staff</td>
              <td>
                <span class=""badge badge-success"">Active</span>
              </td>
            </tr>
          </tbody>
        </table>
        <nav>
          <ul class=""pagination"">
            <li class=""page-item"">
              <a class=""page-link"" href=""#"">Prev</a>
            </li>
            <li class=""page-item active"">
              <a class=""page-link"" href=""#"">1</a>
            </li>
            <li class=""page-item"">
              <a class=""page-link"" href=""#"">2</a>
            </li>
            <li class=""page-item"">
              <a class=""page-link"" href=""#"">3</a>
            </li>
            <li class=""page-item"">
");
            WriteLiteral(@"              <a class=""page-link"" href=""#"">4</a>
            </li>
            <li class=""page-item"">
              <a class=""page-link"" href=""#"">Next</a>
            </li>
          </ul>
        </nav>
      </div>
    </div>
  </div>
  <!--/.col-->
</div>
<!--/.row-->");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
