#pragma checksum "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebfa0f4fc9b732a53571ac8d4f4cac43baab39f1"
// <auto-generated/>
#pragma warning disable 1591
namespace RVLiving.Pages.Admin
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
#line 3 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
using RVLiving.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
using RVLiving.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
using RVLiving.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/editbudget")]
    public partial class EditBudget : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .infodiv {\r\n        padding: 2rem;\r\n        width: 100%;\r\n    }\r\n\r\n    .done {\r\n        padding-top: 2rem;\r\n        left: 0;\r\n    }\r\n\r\n    .expenses {\r\n        margin-top: 20px;\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenComponent<MatBlazor.MatH4>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(3, "Edit Expenses");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "done");
            __builder.OpenComponent<MatBlazor.MatButton>(7);
            __builder.AddAttribute(8, "Link", "budgeting");
            __builder.AddAttribute(9, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
                                        true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(11, "Done");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "expenses");
#nullable restore
#line 31 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
     if (expenses is null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MatBlazor.MatProgressCircle>(15);
            __builder.AddAttribute(16, "Closed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 33 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 34 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MatBlazor.MatPaper>(17);
            __builder.AddAttribute(18, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 37 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
                             2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "infodiv");
                __builder2.OpenElement(22, "table");
                __builder2.AddAttribute(23, "class", "table table-sm table-responsive");
                __builder2.AddMarkupContent(24, "<thead><tr><th></th>\r\n                            <th>Expense</th>\r\n                            <th>Price ($)</th>\r\n                            <th>Category</th>\r\n                            <th>Notes</th></tr></thead>\r\n                    ");
                __builder2.OpenElement(25, "tbody");
#nullable restore
#line 50 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
                         foreach (var expense in expenses)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(26, "tr");
                __builder2.OpenElement(27, "td");
                __builder2.OpenComponent<MatBlazor.MatButton>(28);
                __builder2.AddAttribute(29, "Outlined", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 54 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "Icon", "edit");
                __builder2.AddAttribute(31, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
                                                                                    () => OpenEditExpenseDialog(expense)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(33, "Edit\r\n                                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n\r\n                                    ");
                __builder2.OpenComponent<MatBlazor.MatDialog>(35);
                __builder2.AddAttribute(36, "IsOpen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 57 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
                                                              dialogIsOpen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "IsOpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dialogIsOpen = __value, dialogIsOpen))));
                __builder2.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatDialogTitle>(39);
                    __builder3.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(41, "Edit Expense");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\r\n                                        ");
                    __builder3.OpenComponent<MatBlazor.MatDialogContent>(43);
                    __builder3.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(45, "p");
                        __Blazor.RVLiving.Pages.Admin.EditBudget.TypeInference.CreateMatTextField_0(__builder4, 46, 47, "expenseName", 48, "Expense", 49, "label", 50, 
#nullable restore
#line 61 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
                                                                                            editExpense.ExpenseName

#line default
#line hidden
#nullable disable
                        , 51, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => editExpense.ExpenseName = __value, editExpense.ExpenseName)), 52, () => editExpense.ExpenseName);
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(53, "\r\n                                            ");
                        __builder4.OpenElement(54, "p");
                        __Blazor.RVLiving.Pages.Admin.EditBudget.TypeInference.CreateMatTextField_1(__builder4, 55, 56, "amount", 57, "Cost", 58, "monetization_on", 59, 
#nullable restore
#line 65 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
                                                                                       editExpense.Amount

#line default
#line hidden
#nullable disable
                        , 60, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => editExpense.Amount = __value, editExpense.Amount)), 61, () => editExpense.Amount);
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(62, "\r\n                                            ");
                        __builder4.OpenElement(63, "p");
                        __Blazor.RVLiving.Pages.Admin.EditBudget.TypeInference.CreateMatTextField_2(__builder4, 64, 65, "category", 66, "Category", 67, "category", 68, 
#nullable restore
#line 69 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
                                                                                         editExpense.Category

#line default
#line hidden
#nullable disable
                        , 69, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => editExpense.Category = __value, editExpense.Category)), 70, () => editExpense.Category);
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(71, "\r\n                                            ");
                        __builder4.OpenElement(72, "p");
                        __Blazor.RVLiving.Pages.Admin.EditBudget.TypeInference.CreateMatTextField_3(__builder4, 73, 74, "notes", 75, "Notes", 76, "notes", 77, 
#nullable restore
#line 73 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
                                                                                      editExpense.Notes

#line default
#line hidden
#nullable disable
                        , 78, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => editExpense.Notes = __value, editExpense.Notes)), 79, () => editExpense.Notes);
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(80, "\r\n                                        ");
                    __builder3.OpenComponent<MatBlazor.MatDialogActions>(81);
                    __builder3.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MatBlazor.MatButton>(83);
                        __builder4.AddAttribute(84, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
                                                                  e => { dialogIsOpen = false; }

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(86, "Cancel");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(87, "\r\n                                            ");
                        __builder4.OpenComponent<MatBlazor.MatButton>(88);
                        __builder4.AddAttribute(89, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 79 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
                                                                () => UpdateExpense(editExpense)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(91, "Update");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n\r\n                                    ");
                __builder2.OpenComponent<MatBlazor.MatButton>(93);
                __builder2.AddAttribute(94, "Unelevated", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 83 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
                                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(95, "Icon", "delete_outline");
                __builder2.AddAttribute(96, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
                                                                                                () => ConfirmDelete(expense)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(98, "\r\n                                        Delete");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(99, "\r\n\r\n                                    ");
                __builder2.OpenComponent<MatBlazor.MatDialog>(100);
                __builder2.AddAttribute(101, "IsOpen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 86 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
                                                              deleteDialogIsOpen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(102, "IsOpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => deleteDialogIsOpen = __value, deleteDialogIsOpen))));
                __builder2.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatDialogTitle>(104);
                    __builder3.AddAttribute(105, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(106, "Delete Expense");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(107, "\r\n                                        ");
                    __builder3.OpenComponent<MatBlazor.MatDialogContent>(108);
                    __builder3.AddAttribute(109, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MatBlazor.MatSubtitle1>(110);
                        __builder4.AddAttribute(111, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(112, "Are you sure you want to delete this Expense?");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(113, "\r\n                                        ");
                    __builder3.OpenComponent<MatBlazor.MatDialogActions>(114);
                    __builder3.AddAttribute(115, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MatBlazor.MatButton>(116);
                        __builder4.AddAttribute(117, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 92 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
                                                                  e => { deleteDialogIsOpen = false; }

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(118, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(119, "Cancel");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(120, "\r\n                                            ");
                        __builder4.OpenComponent<MatBlazor.MatButton>(121);
                        __builder4.AddAttribute(122, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
                                                                () => DeleteExpense(editExpense)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(123, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(124, "Delete");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(125, "\r\n\r\n                                ");
                __builder2.OpenElement(126, "td");
                __builder2.AddContent(127, 
#nullable restore
#line 98 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
                                     expense.ExpenseName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n                                ");
                __builder2.OpenElement(129, "td");
                __builder2.AddContent(130, 
#nullable restore
#line 99 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
                                     expense.Amount

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\r\n                                ");
                __builder2.OpenElement(132, "td");
                __builder2.AddContent(133, 
#nullable restore
#line 100 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
                                     expense.Category

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(134, "\r\n                                ");
                __builder2.OpenElement(135, "td");
                __builder2.AddContent(136, 
#nullable restore
#line 101 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
                                     expense.Notes

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 103 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
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
#line 108 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 113 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Admin\EditBudget.razor"
       
    private bool dialogIsOpen, deleteDialogIsOpen = false;
    private List<ExpenseModel> expenses;
    private ExpenseModel editExpense = new ExpenseModel();

    private void OpenEditExpenseDialog(ExpenseModel expense)
    {
        this.editExpense = expense;
        dialogIsOpen = true;
    }

    private void ConfirmDelete(ExpenseModel expense)
    {
        this.editExpense = expense;
        deleteDialogIsOpen = true;
    }

    protected override async Task OnInitializedAsync()
    {
        expenses = await _expenseDb.GetExpenses();
    }

    private async Task DeleteExpense(ExpenseModel expense)
    {
        // close dialog
        deleteDialogIsOpen = false;

        // delete expense from db
        await _expenseDb.DeleteExpense(expense);

        // display new list minus deleted item without doing another call to the db
        expenses.Remove(expense);
    }

    private async Task UpdateExpense(ExpenseModel expense)
    {
        // close dialog
        dialogIsOpen = false;

        // update expense in db
        await _expenseDb.UpdateExpense(expense);

        //update the view
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IExpenseData _expenseDb { get; set; }
    }
}
namespace __Blazor.RVLiving.Pages.Admin.EditBudget
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
