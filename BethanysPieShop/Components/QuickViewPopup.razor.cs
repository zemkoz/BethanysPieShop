using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.Components;

public partial class QuickViewPopup : ComponentBase
{
    [Parameter]
    public Employee? Employee { get; set; }

    private Employee? _employee;

    protected override void OnParametersSet()
    {
        _employee = Employee;
    }

    private void Close()
    {
        _employee = null;
    }
}