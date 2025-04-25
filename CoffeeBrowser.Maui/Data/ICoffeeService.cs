namespace CoffeeBrowser.Maui.Data
{
    internal interface ICoffeeService
    {
        Task<IEnumerable<Coffee>> LoadCofeesAsync();
    }
}
