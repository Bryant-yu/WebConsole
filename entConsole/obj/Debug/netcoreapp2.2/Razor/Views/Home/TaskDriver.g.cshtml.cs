#pragma checksum "E:\Project\临时测试\entConsole20190402\entConsole\entConsole\Views\Home\TaskDriver.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a248c30354ff074c9445a97b420bbdd0adacce4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TaskDriver), @"mvc.1.0.view", @"/Views/Home/TaskDriver.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/TaskDriver.cshtml", typeof(AspNetCore.Views_Home_TaskDriver))]
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
#line 1 "E:\Project\临时测试\entConsole20190402\entConsole\entConsole\Views\_ViewImports.cshtml"
using entConsole;

#line default
#line hidden
#line 2 "E:\Project\临时测试\entConsole20190402\entConsole\entConsole\Views\_ViewImports.cshtml"
using entConsole.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a248c30354ff074c9445a97b420bbdd0adacce4", @"/Views/Home/TaskDriver.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c9164e484d31f91b34ab6f3764ea77a9d636b65", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TaskDriver : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<entConsole.Models.TaskDriverViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TaskDriver", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 353, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a248c30354ff074c9445a97b420bbdd0adacce44623", async() => {
                BeginContext(118, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(406, 757, true);
            WriteLiteral(@"

<div class=""panel panel-default"">
    <div class=""panel-heading""></div>
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    任务ID
                </th>
                <th>
                    用户
                </th>
                <th>
                    任务名
                </th>
                <th>
                    表名
                </th>
                <th>
                    任务状态
                </th>
                <th>
                    时间戳
                </th>
                <th>
                    是否初始化
                </th>
                <th>
                    操作
                </th>
            </tr>
        </thead>

        <tbody>
");
            EndContext();
#line 48 "E:\Project\临时测试\entConsole20190402\entConsole\entConsole\Views\Home\TaskDriver.cshtml"
              
                try
                {
                    foreach (var item in Model.dataList)
                    {


#line default
#line hidden
            BeginContext(1302, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1399, 41, false);
#line 56 "E:\Project\临时测试\entConsole20190402\entConsole\entConsole\Views\Home\TaskDriver.cshtml"
                           Write(Html.DisplayFor(modelItem => item.taskId));

#line default
#line hidden
            EndContext();
            BeginContext(1440, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1544, 43, false);
#line 59 "E:\Project\临时测试\entConsole20190402\entConsole\entConsole\Views\Home\TaskDriver.cshtml"
                           Write(Html.DisplayFor(modelItem => item.userName));

#line default
#line hidden
            EndContext();
            BeginContext(1587, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1691, 43, false);
#line 62 "E:\Project\临时测试\entConsole20190402\entConsole\entConsole\Views\Home\TaskDriver.cshtml"
                           Write(Html.DisplayFor(modelItem => item.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(1734, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1838, 41, false);
#line 65 "E:\Project\临时测试\entConsole20190402\entConsole\entConsole\Views\Home\TaskDriver.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Tables));

#line default
#line hidden
            EndContext();
            BeginContext(1879, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1983, 45, false);
#line 68 "E:\Project\临时测试\entConsole20190402\entConsole\entConsole\Views\Home\TaskDriver.cshtml"
                           Write(Html.DisplayFor(modelItem => item.taskStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2028, 71, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
            EndContext();
            BeginContext(2168, 69, true);
            WriteLiteral("                            </td>\r\n                            <td>\r\n");
            EndContext();
            BeginContext(2305, 101, true);
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2406, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a248c30354ff074c9445a97b420bbdd0adacce410705", async() => {
                BeginContext(2456, 2, true);
                WriteLiteral("提交");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "E:\Project\临时测试\entConsole20190402\entConsole\entConsole\Views\Home\TaskDriver.cshtml"
                                                        WriteLiteral(item.taskId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2462, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2540, 66, true);
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 81 "E:\Project\临时测试\entConsole20190402\entConsole\entConsole\Views\Home\TaskDriver.cshtml"
                    }
                }
                catch (Exception e)
                {
                    

#line default
#line hidden
            BeginContext(2725, 75, false);
#line 85 "E:\Project\临时测试\entConsole20190402\entConsole\entConsole\Views\Home\TaskDriver.cshtml"
               Write(Html.ActionLink("点击查看详细错误信息", "Index", "Error", new { Msg = e.ToString() }));

#line default
#line hidden
            EndContext();
#line 85 "E:\Project\临时测试\entConsole20190402\entConsole\entConsole\Views\Home\TaskDriver.cshtml"
                                                                                                
                }
            

#line default
#line hidden
            BeginContext(2836, 42, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(2891, 204, false);
#line 93 "E:\Project\临时测试\entConsole20190402\entConsole\entConsole\Views\Home\TaskDriver.cshtml"
Write(CommonMethod.PaginationPager(Convert.ToInt32(Model.paraDic["clickpagenow"]), Convert.ToInt32(Model.paraDic["PageNum"]), Convert.ToInt32(Model.paraDic["allowPageNum"]), "Home", "TaskDriver", Model.paraDic));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<entConsole.Models.TaskDriverViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
