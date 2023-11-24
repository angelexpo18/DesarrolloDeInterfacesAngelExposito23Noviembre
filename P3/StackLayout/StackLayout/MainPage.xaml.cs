using Microsoft.Maui.Controls;
namespace StackLayout
{
    public partial class MainPage : ContentPage
    {
        Entry billInput;
        Label tipOutput;
        Label totalOutput;
        Label tipPercent;
        Slider tipPercentSlider;
        Button roundDown;
        Button roundUp;

        public MainPage()
        {
            InitializeComponent();

            // Inicializar los elementos
            billInput = new Entry { Placeholder = "Enter Amount", Keyboard = Keyboard.Numeric };
            tipOutput = new Label { Text = "0.00" };
            totalOutput = new Label { Text = "0.00" };
            tipPercent = new Label { Text = "15%" };
            tipPercentSlider = new Slider { Minimum = 0, Maximum = 100, Value = 15 };
            roundDown = new Button { Text = "Round Down", WidthRequest = 150, HorizontalOptions = LayoutOptions.Center };
            roundUp = new Button { Text = "Round Up", WidthRequest = 150, HorizontalOptions = LayoutOptions.Center };

            // Manejadores de eventos para los botones
            roundDown.Clicked += OnRoundDownClicked;
            roundUp.Clicked += OnRoundUpClicked;

            // Estructura de diseño
            VerticalStackLayout stackLayout = new VerticalStackLayout
            {
                Padding = new Thickness(40),
                Spacing = 10,
                Children =
                {
                    new HorizontalStackLayout
                    {
                        Spacing = 10,
                        Children =
                        {
                            new Label { Text = "Bill", WidthRequest = 100, VerticalOptions = LayoutOptions.Center },
                            billInput
                        }
                    },
                    new HorizontalStackLayout
                    {
                        Margin = new Thickness(0, 20, 0, 0),
                        Spacing = 10,
                        Children =
                        {
                            new Label { Text = "Tip", WidthRequest = 100 },
                            tipOutput
                        }
                    },
                    new HorizontalStackLayout
                    {
                        Spacing = 10,
                        Children =
                        {
                            new Label { Text = "Total", WidthRequest = 100 },
                            totalOutput
                        }
                    },
                    new HorizontalStackLayout
                    {
                        VerticalOptions = LayoutOptions.End,
                        Spacing = 10,
                        Children =
                        {
                            new Label { Text = "Tip Percentage", WidthRequest = 100 },
                            tipPercent
                        }
                    },
                    tipPercentSlider,
                    new HorizontalStackLayout
                    {
                        Margin = new Thickness(0, 20, 0, 0),
                        Spacing = 10,
                        Children =
                        {
                            
                        }
                    },
                    new HorizontalStackLayout
                    {
                        Margin = new Thickness(0, 20, 0, 0),
                        Spacing = 10,
                        Children =
                        {
                            roundDown,
                            roundUp
                        }
                    }
                }
            };

            // Asignar el contenido de la página
            this.Content = stackLayout;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        // Eventos de los botones
        void OnNormalTip(object sender, EventArgs e)
        {
            // Lógica para el botón "15%"
        }

        void OnGenerousTip(object sender, EventArgs e)
        {
            // Lógica para el botón "20%"
        }

        void OnRoundDownClicked(object sender, EventArgs e)
        {
            // Lógica para el botón "Round Down"
        }

        void OnRoundUpClicked(object sender, EventArgs e)
        {
            // Lógica para el botón "Round Up"
        }
    }
}