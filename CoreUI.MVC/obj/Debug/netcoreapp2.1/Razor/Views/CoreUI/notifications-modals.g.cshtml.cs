#pragma checksum "D:\GitHub\NetCore-MVC-CoreUI2\CoreUI.MVC\Views\CoreUI\notifications-modals.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc6250c44bfcd5a9441321bb7e036ceda15e4708"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CoreUI_notifications_modals), @"mvc.1.0.view", @"/Views/CoreUI/notifications-modals.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CoreUI/notifications-modals.cshtml", typeof(AspNetCore.Views_CoreUI_notifications_modals))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc6250c44bfcd5a9441321bb7e036ceda15e4708", @"/Views/CoreUI/notifications-modals.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0446120a3c9768b04ff461bd5d5d2c67627e18d9", @"/Views/_ViewImports.cshtml")]
    public class Views_CoreUI_notifications_modals : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 8515, true);
            WriteLiteral(@"<div class=""row"">
  <div class=""col-lg-12"">
    <div class=""card"">
      <div class=""card-header"">
        <i class=""fa fa-align-justify""></i> Bootstrap Modals
      </div>
      <div class=""card-body"">
        <!-- Button trigger modal -->
        <button type=""button"" class=""btn btn-secondary"" data-toggle=""modal"" data-target=""#myModal"">
          Launch demo modal
        </button>
        <button type=""button"" class=""btn btn-secondary"" data-toggle=""modal"" data-target=""#largeModal"">
          Launch large modal
        </button>
        <button type=""button"" class=""btn btn-secondary"" data-toggle=""modal"" data-target=""#smallModal"">
          Launch small modal
        </button>
        <hr>
        <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#primaryModal"">
          Primary modal
        </button>
        <button type=""button"" class=""btn btn-success"" data-toggle=""modal"" data-target=""#successModal"">
          Success modal
        </button>
        <b");
            WriteLiteral(@"utton type=""button"" class=""btn btn-warning"" data-toggle=""modal"" data-target=""#warningModal"">
          Warning modal
        </button>
        <button type=""button"" class=""btn btn-danger"" data-toggle=""modal"" data-target=""#dangerModal"">
          Danger modal
        </button>
        <button type=""button"" class=""btn btn-info"" data-toggle=""modal"" data-target=""#infoModal"">
          Info modal
        </button>
      </div>
    </div>
  </div>
  <!--/.col-->
</div>
<!--/.row-->
          </div>

<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h4 class=""modal-title"">Modal title</h4>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <p>One fine body&h");
            WriteLiteral(@"ellip;</p>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
        <button type=""button"" class=""btn btn-primary"">Save changes</button>
      </div>
    </div>
    <!-- /.modal-content -->
  </div>
  <!-- /.modal-dialog -->
</div>
<!-- /.modal -->

<div class=""modal fade"" id=""largeModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog modal-lg"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h4 class=""modal-title"">Modal title</h4>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <p>One fine body&hellip;</p>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
");
            WriteLiteral(@"        <button type=""button"" class=""btn btn-primary"">Save changes</button>
      </div>
    </div>
    <!-- /.modal-content -->
  </div>
  <!-- /.modal-dialog -->
</div>
<!-- /.modal -->

<div class=""modal fade"" id=""smallModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog modal-sm"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h4 class=""modal-title"">Modal title</h4>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <p>One fine body&hellip;</p>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
        <button type=""button"" class=""btn btn-primary"">Save changes</button>
      </div>
    </div>
    <!-- /.modal-content -->
  </div>
  <!-- /.m");
            WriteLiteral(@"odal-dialog -->
</div>
<!-- /.modal -->

<div class=""modal fade"" id=""primaryModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog modal-primary"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h4 class=""modal-title"">Modal title</h4>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <p>One fine body&hellip;</p>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
        <button type=""button"" class=""btn btn-primary"">Save changes</button>
      </div>
    </div>
    <!-- /.modal-content -->
  </div>
  <!-- /.modal-dialog -->
</div>
<!-- /.modal -->

<div class=""modal fade"" id=""successModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" ");
            WriteLiteral(@"aria-hidden=""true"">
  <div class=""modal-dialog modal-success"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h4 class=""modal-title"">Modal title</h4>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <p>One fine body&hellip;</p>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
        <button type=""button"" class=""btn btn-success"">Save changes</button>
      </div>
    </div>
    <!-- /.modal-content -->
  </div>
  <!-- /.modal-dialog -->
</div>
<!-- /.modal -->

<div class=""modal fade"" id=""warningModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog modal-warning"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">");
            WriteLiteral(@"
        <h4 class=""modal-title"">Modal title</h4>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <p>One fine body&hellip;</p>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
        <button type=""button"" class=""btn btn-warning"">Save changes</button>
      </div>
    </div>
    <!-- /.modal-content -->
  </div>
  <!-- /.modal-dialog -->
</div>
<!-- /.modal -->

<div class=""modal fade"" id=""dangerModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog modal-danger"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h4 class=""modal-title"">Modal title</h4>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          ");
            WriteLiteral(@"<span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <p>One fine body&hellip;</p>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
        <button type=""button"" class=""btn btn-danger"">Save changes</button>
      </div>
    </div>
    <!-- /.modal-content -->
  </div>
  <!-- /.modal-dialog -->
</div>
<!-- /.modal -->

<div class=""modal fade"" id=""infoModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog modal-info"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h4 class=""modal-title"">Modal title</h4>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <p>One fine body&hellip;</p>
      </d");
            WriteLiteral(@"iv>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
        <button type=""button"" class=""btn btn-info"">Save changes</button>
      </div>
    </div>
    <!-- /.modal-content -->
  </div>
  <!-- /.modal-dialog -->
</div>
<!-- /.modal -->");
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
