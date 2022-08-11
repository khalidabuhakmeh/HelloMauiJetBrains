using HelloLatest.Data;

namespace HelloLatest;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }

    private async void LearnMore(object sender, EventArgs e)
    {
        if (sender is Button { BindingContext: string url })
        {
            await Browser.OpenAsync(url);
        }
    }
}

public class MainPageViewModel
{
    public MainPageViewModel()
    {
        Products = Product.All;
    }
    
    public int TotalProductsCount => Products.Count;
    public IReadOnlyList<Product> Products { get; set; }
}