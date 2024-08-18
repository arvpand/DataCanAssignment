using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DataCanAssignment.Models;


namespace DataCanAssignment.Pages;

public class IndexModel : PageModel
{
    private static BankAccount _bankAccount = new BankAccount(1000.00m);

    public decimal Balance => _bankAccount.Balance;

    [BindProperty] public decimal Amount { get; set; }
    [BindProperty] public string CurrencyType { get; set; } = string.Empty;
    public void OnGet()
    {
    }


    public IActionResult OnPostDeposit()
    {
        CurrencyType currencyType = GetCurrencyType(CurrencyType);
        _bankAccount.Deposit(Amount, currencyType);
        return Page();
    }

    public IActionResult OnPostWithdraw()
    {
        CurrencyType currencyType = GetCurrencyType(CurrencyType);
        _bankAccount.Withdraw(Amount, currencyType);
        return Page();
    }

    private CurrencyType GetCurrencyType(string currencyType)
    {
        return currencyType switch
        {
            "CAD" => new Cad(),
            "USD" => new Usd(),
            "MXN" => new Mxn(),
            "EUR" => new Eur()
        };
    }
}

