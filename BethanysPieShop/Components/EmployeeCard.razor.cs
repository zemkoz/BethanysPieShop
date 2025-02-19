using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.Components;

public partial class EmployeeCard : ComponentBase
{
    [Parameter]
    public Employee Employee { get; set; } = default!;
}