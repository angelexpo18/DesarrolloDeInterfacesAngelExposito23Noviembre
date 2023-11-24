using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace Notes2;

public partial class MainPage : ContentPage
{
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

    Editor editor;

    public MainPage()
    {
        InitializeComponent();

        editor = new Editor() { Placeholder = "Ingresa tu nota", HeightRequest = 100 };

        if (File.Exists(_fileName))
        {
            editor.Text = File.ReadAllText(_fileName);
        }

        var notesHeading = new Label() { Text = "Notas", HorizontalOptions = LayoutOptions.Center, FontAttributes = FontAttributes.Bold };

        var buttonsGrid = new Grid() { HeightRequest = 40.0 };
        buttonsGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1.0, GridUnitType.Auto) });
        buttonsGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(30.0, GridUnitType.Absolute) });
        buttonsGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1.0, GridUnitType.Auto) });

        var saveButton = new Button() { WidthRequest = 100, Text = "Guardar" };
        saveButton.Clicked += OnSaveButtonClicked;
        Grid.SetColumn(saveButton, 0);
        buttonsGrid.Children.Add(saveButton);

        var deleteButton = new Button() { WidthRequest = 100, Text = "Eliminar" };
        deleteButton.Clicked += OnDeleteButtonClicked;
        Grid.SetColumn(deleteButton, 2);
        buttonsGrid.Children.Add(deleteButton);

        var stackLayout = new VerticalStackLayout
        {
            Padding = new Thickness(30, 60, 30, 30),
            Children = { notesHeading, editor, buttonsGrid }
        };

        this.Content = stackLayout;
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    void OnSaveButtonClicked(object sender, EventArgs e)
    {
        File.WriteAllText(_fileName, editor.Text);
    }

    void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        if (File.Exists(_fileName))
        {
            File.Delete(_fileName);
        }
        editor.Text = string.Empty;
    }
}

