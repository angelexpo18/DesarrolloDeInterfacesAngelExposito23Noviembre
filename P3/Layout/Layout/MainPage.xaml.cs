namespace Layout
{
    public partial class MainPage : ContentPage
    {
        VerticalStackLayout stack;

        public MainPage()
        {
            InitializeComponent();

            stack = new VerticalStackLayout
            {
                Padding = new Thickness(30, 60, 30, 30)
            };

            var a = new BoxView { Color = Colors.Silver, HeightRequest = 40 };
            var b = new BoxView { Color = Colors.Blue, HeightRequest = 40 };
            var c = new BoxView { Color = Colors.Gray, HeightRequest = 40 };

            stack.Children.Add(a);
            stack.Children.Add(b);
            stack.Children.Add(c);

            this.Content = stack;
        }
    }
}
