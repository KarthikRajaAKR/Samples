namespace ImageBindingSample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

  
}

internal class ImageViewModel
{
    public ImageSource ImageSource { get; set; }

    public ImageViewModel()
    {
        var byteArray = File.ReadAllBytes(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dotnet_bot.png"));
        this.ImageSource = ImageSource.FromStream(() => new MemoryStream(byteArray));
    }
}