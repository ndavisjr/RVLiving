#pragma checksum "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00780984ea51b17341ac4bc2506e3a5e03e7f2b2"
// <auto-generated/>
#pragma warning disable 1591
namespace RVLiving.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using RVLiving;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using RVLiving.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
using RVLiving.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
using RVLiving.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
using RVLiving.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/budgeting")]
    public partial class Budgeting : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .infodiv {
        padding: 2rem;
        width: 100%;
    }

    .add-expense {
        padding-top: 2rem;
        left: 0;
    }

    .expenses {
        margin-top: 20px;
    }

    .app-fab--absolute {
        position: fixed;
        bottom: 1rem;
        right: 1rem;
    }

    .app-fab--absolute2 {
        position: fixed;
        bottom: 1rem;
        right: 5rem;
        background-color: #DB4437;
    }
</style>

");
            __builder.OpenComponent<MatBlazor.MatH4>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(3, "Expenses");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenComponent<MatBlazor.MatFAB>(5);
            __builder.AddAttribute(6, "Class", "app-fab--absolute2");
            __builder.AddAttribute(7, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
                                          MatIconNames.Add

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
                                                                      OpenAddExpenseDialog

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenComponent<MatBlazor.MatFAB>(10);
            __builder.AddAttribute(11, "Class", "app-fab--absolute");
            __builder.AddAttribute(12, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
                                         MatIconNames.Edit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
                                                                      NavigateToEditPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "add-expense");
            __builder.OpenComponent<MatBlazor.MatDialog>(17);
            __builder.AddAttribute(18, "IsOpen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 46 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
                              dialogIsOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "IsOpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dialogIsOpen = __value, dialogIsOpen))));
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(21);
                __builder2.AddAttribute(22, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 47 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
                          newExpense

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 47 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
                                                      InsertExpense

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(25);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(27);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(28, "\r\n\r\n            ");
                    __builder3.OpenComponent<MatBlazor.MatDialogTitle>(29);
                    __builder3.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(31, "Add New Expense");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\r\n            ");
                    __builder3.OpenComponent<MatBlazor.MatDialogContent>(33);
                    __builder3.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(35, "p");
                        __Blazor.RVLiving.Pages.Budgeting.TypeInference.CreateMatTextField_0(__builder4, 36, 37, "expenseName", 38, "Expense", 39, "label", 40, 
#nullable restore
#line 54 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
                                                                newExpense.ExpenseName

#line default
#line hidden
#nullable disable
                        , 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newExpense.ExpenseName = __value, newExpense.ExpenseName)), 42, () => newExpense.ExpenseName);
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(43, "\r\n                ");
                        __builder4.OpenElement(44, "p");
                        __Blazor.RVLiving.Pages.Budgeting.TypeInference.CreateMatTextField_1(__builder4, 45, 46, "amount", 47, "Cost", 48, "monetization_on", 49, 
#nullable restore
#line 57 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
                                                           newExpense.Amount

#line default
#line hidden
#nullable disable
                        , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newExpense.Amount = __value, newExpense.Amount)), 51, () => newExpense.Amount);
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(52, "\r\n                ");
                        __builder4.OpenElement(53, "p");
                        __Blazor.RVLiving.Pages.Budgeting.TypeInference.CreateMatTextField_2(__builder4, 54, 55, "category", 56, "Category", 57, "category", 58, 
#nullable restore
#line 60 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
                                                             newExpense.Category

#line default
#line hidden
#nullable disable
                        , 59, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newExpense.Category = __value, newExpense.Category)), 60, () => newExpense.Category);
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(61, "\r\n                ");
                        __builder4.OpenElement(62, "p");
                        __Blazor.RVLiving.Pages.Budgeting.TypeInference.CreateMatTextField_3(__builder4, 63, 64, "notes", 65, "Notes", 66, "notes", 67, 
#nullable restore
#line 63 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
                                                          newExpense.Notes

#line default
#line hidden
#nullable disable
                        , 68, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newExpense.Notes = __value, newExpense.Notes)), 69, () => newExpense.Notes);
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\r\n            ");
                    __builder3.OpenComponent<MatBlazor.MatDialogActions>(71);
                    __builder3.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MatBlazor.MatButton>(73);
                        __builder4.AddAttribute(74, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
                                      e => { dialogIsOpen = false; }

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(76, "Cancel");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(77, "\r\n                ");
                        __builder4.OpenComponent<MatBlazor.MatButton>(78);
                        __builder4.AddAttribute(79, "Type", "submit");
                        __builder4.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(81, "Add");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "expenses");
#nullable restore
#line 75 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
     if (expenses is null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MatBlazor.MatProgressCircle>(85);
            __builder.AddAttribute(86, "Closed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 77 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 78 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MatBlazor.MatPaper>(87);
            __builder.AddAttribute(88, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 81 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
                             2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "infodiv");
                __builder2.OpenElement(92, "table");
                __builder2.AddAttribute(93, "class", "table table-sm table-responsive");
                __builder2.AddMarkupContent(94, "<thead><tr><th>Expense</th>\r\n                            <th>Price ($)</th>\r\n                            <th>Category</th>\r\n                            <th>Notes</th></tr></thead>\r\n                    ");
                __builder2.OpenElement(95, "tbody");
#nullable restore
#line 93 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
                         foreach (var expense in expenses)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(96, "tr");
                __builder2.OpenElement(97, "td");
                __builder2.AddContent(98, 
#nullable restore
#line 96 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
                                     expense.ExpenseName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n                                ");
                __builder2.OpenElement(100, "td");
                __builder2.AddContent(101, 
#nullable restore
#line 97 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
                                     expense.Amount

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n                                ");
                __builder2.OpenElement(103, "td");
                __builder2.AddContent(104, 
#nullable restore
#line 98 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
                                     expense.Category

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n                                ");
                __builder2.OpenElement(106, "td");
                __builder2.AddContent(107, 
#nullable restore
#line 99 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
                                     expense.Notes

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 101 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 106 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 109 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Budgeting.razor"
       
    private bool dialogIsOpen = false;
    private void OpenAddExpenseDialog()
    {
        dialogIsOpen = true;
    }

    private void NavigateToEditPage()
    {
        NavigationManager.NavigateTo("admin/editbudget");
    }

    private List<ExpenseModel> expenses;
    private DisplayExpenseModel newExpense = new DisplayExpenseModel();

    protected override async Task OnInitializedAsync()
    {
        expenses = await _expenseDb.GetExpenses();
    }

    private async Task InsertExpense()
    {
        dialogIsOpen = false;

        // create new Item from the form values
        ExpenseModel e = new ExpenseModel
        {
            ExpenseName = newExpense.ExpenseName,
            Amount = newExpense.Amount,
            Category = newExpense.Category,
            Notes = newExpense.Notes
        };

        // insert item into the db
        await _expenseDb.InsertExpense(e);

        // display newly created without doing another call to the db
        expenses.Add(e);

        // clear the new item so it's ready for use again
        newExpense = new DisplayExpenseModel();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IExpenseData _expenseDb { get; set; }
    }
}
namespace __Blazor.RVLiving.Pages.Budgeting
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTextField_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Icon", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Icon", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Icon", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Icon", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591