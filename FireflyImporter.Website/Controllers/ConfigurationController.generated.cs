// <auto-generated />
// This file was generated by R4Mvc.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the r4mvc.json file (i.e. the settings file), save it and run the generator tool again.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo.Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
#pragma warning disable 1591, 3008, 3009, 0108
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;
using R4Mvc;

namespace FireflyImporter.Website.Controllers
{
    public partial class ConfigurationController
    {
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected ConfigurationController(Dummy d)
        {
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(IActionResult result)
        {
            var callInfo = result.GetR4ActionResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<IActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(IActionResult result)
        {
            var callInfo = result.GetR4ActionResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<IActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToPage(IActionResult result)
        {
            var callInfo = result.GetR4ActionResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToPage(Task<IActionResult> taskResult)
        {
            return RedirectToPage(taskResult.Result);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToPagePermanent(IActionResult result)
        {
            var callInfo = result.GetR4ActionResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToPagePermanent(Task<IActionResult> taskResult)
        {
            return RedirectToPagePermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult AddBank()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.AddBank);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult DeleteBank()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.DeleteBank);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public ConfigurationController Actions => MVC.Configuration;
        [GeneratedCode("R4Mvc", "1.0")]
        public readonly string Area = "";
        [GeneratedCode("R4Mvc", "1.0")]
        public readonly string Name = "Configuration";
        [GeneratedCode("R4Mvc", "1.0")]
        public const string NameConst = "Configuration";
        [GeneratedCode("R4Mvc", "1.0")]
        static readonly ActionNamesClass s_ActionNames = new ActionNamesClass();
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames => s_ActionNames;
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string AddBank = "AddBank";
            public readonly string DeleteBank = "DeleteBank";
            public readonly string Index = "Index";
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string AddBank = "AddBank";
            public const string DeleteBank = "DeleteBank";
            public const string Index = "Index";
        }

        [GeneratedCode("R4Mvc", "1.0")]
        static readonly ActionParamsClass_AddBank s_AddBankParams = new ActionParamsClass_AddBank();
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public ActionParamsClass_AddBank AddBankParams => s_AddBankParams;
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ActionParamsClass_AddBank
        {
            public readonly string formModel = "formModel";
        }

        [GeneratedCode("R4Mvc", "1.0")]
        static readonly ActionParamsClass_DeleteBank s_DeleteBankParams = new ActionParamsClass_DeleteBank();
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public ActionParamsClass_DeleteBank DeleteBankParams => s_DeleteBankParams;
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DeleteBank
        {
            public readonly string requisitionId = "requisitionId";
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames => s_ViewNames;
            public class _ViewNamesClass
            {
                public readonly string Index = "Index";
            }

            public readonly string Index = "~/Views/Configuration/Index.cshtml";
        }

        [GeneratedCode("R4Mvc", "1.0")]
        static readonly ViewsClass s_Views = new ViewsClass();
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public ViewsClass Views => s_Views;
    }

    [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
    public partial class R4MVC_ConfigurationController : FireflyImporter.Website.Controllers.ConfigurationController
    {
        public R4MVC_ConfigurationController(): base(Dummy.Instance)
        {
        }

        [NonAction]
        partial void AddBankOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, FireflyImporter.Website.Models.Configuration.FormModels.ConfigurationAddBankFormModel formModel);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult> AddBank(FireflyImporter.Website.Models.Configuration.FormModels.ConfigurationAddBankFormModel formModel)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.AddBank);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "formModel", formModel);
            AddBankOverride(callInfo, formModel);
            return System.Threading.Tasks.Task.FromResult<Microsoft.AspNetCore.Mvc.ActionResult>(callInfo);
        }

        [NonAction]
        partial void DeleteBankOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, string requisitionId);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult> DeleteBank(string requisitionId)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.DeleteBank);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "requisitionId", requisitionId);
            DeleteBankOverride(callInfo, requisitionId);
            return System.Threading.Tasks.Task.FromResult<Microsoft.AspNetCore.Mvc.ActionResult>(callInfo);
        }

        [NonAction]
        partial void IndexOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult> Index()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult<Microsoft.AspNetCore.Mvc.ActionResult>(callInfo);
        }
    }
}
#pragma warning restore 1591, 3008, 3009, 0108
