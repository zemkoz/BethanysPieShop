using BethanysPieShop.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.Components.Pages;

public partial class EmployeeOverview : ComponentBase
{
    private IList<Employee> Employees { get; set; } = default!;
    private Employee? _selectedEmployee;
    
    protected async override Task OnInitializedAsync()
    {
        await Task.Delay(500);
        Employees = MockDataService.Employees;
    }
    
    private void ShowQuickViewPopup(Employee employee)
    {
        _selectedEmployee = employee;
    }
}