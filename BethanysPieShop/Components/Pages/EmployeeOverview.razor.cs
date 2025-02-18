using BethanysPieShop.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.Components.Pages;

public partial class EmployeeOverview : ComponentBase
{
    private IList<Employee> Employees { get; set; } = default!;
    
    protected override void OnInitialized()
    {
        Employees = MockDataService.Employees;
    }
}