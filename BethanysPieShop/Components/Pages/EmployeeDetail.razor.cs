using BethanysPieShop.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.Components.Pages;

public partial class EmployeeDetail : ComponentBase
{
    [Parameter]
    public int EmployeeId { get; set; }

    public Employee Employee { get; set; } = new();

    protected override void OnInitialized()
    {
        Employee = MockDataService.Employees
            .Single(e => e.EmployeeId == EmployeeId);
    }
}