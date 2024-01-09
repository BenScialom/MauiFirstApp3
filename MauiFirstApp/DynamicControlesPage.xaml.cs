using MauiApp2;
using Xamarin.Google.Crypto.Tink.Monitoring;
using static System.Net.Mime.MediaTypeNames;

namespace MauiFirstApp;

public partial class DynamicControlesPage : ContentPage
{
    public List<Monkey> monkeys;
    int count = 0;
	public DynamicControlesPage()
	{
		InitializeComponent();
        monkeys= Monkey.GetMonkeys();
        AddLayout();
        AddButtons();
    }
    private void AddLayout()
    {
        StackLayout stk = new StackLayout()
        {
            BackgroundColor = Color.FromHex("#c95338")
        };
        this.Content = stk;
    }
    private void AddButtons()
    {
        Button up = new Button()
        {
            Text = "up",
            Margin = new Thickness(7),
            CornerRadius = 300,
            WidthRequest = 80,
            HeightRequest = 75,
        };
        up.Clicked += Button_ClickedUp; 
        ((StackLayout)this.Content).Children.Insert(0,up);
    }
   private void Button_ClickedUp(object sender, EventArgs e)
    {
        if (count <monkeys.Count-1)
        {
            count++;
        }
        ((Image)(StackLayout)this.Content).Children[1]).Source=monkeys[count].Image;
    }
   }
