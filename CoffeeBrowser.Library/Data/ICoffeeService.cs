namespace CoffeeBrowser.Library.Data
{
    internal interface ICoffeeService
    {
        Task<IEnumerable<Coffee>?> LoadCofeesAsync();
    }
}
