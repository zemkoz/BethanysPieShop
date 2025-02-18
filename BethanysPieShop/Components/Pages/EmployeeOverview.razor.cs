using BethanysPieShop.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.Components.Pages;

public partial class EmployeeOverview : ComponentBase
{
    private IList<Employee> Employees { get; set; } = default!;
    
    protected async override Task OnInitializedAsync()
    {
        await Task.Delay(2000);
        Employees = MockDataService.Employees;
    }
}