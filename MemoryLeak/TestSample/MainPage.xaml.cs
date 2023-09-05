namespace TestSample;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnInvalidateClicked(object sender, EventArgs e)
	{
		this.view1.Invalidate();
		this.view2.Invalidate();
		this.view3.Invalidate();

		this.header1.Invalidate();
		this.header2.Invalidate();
		this.header3.Invalidate();
	}
}

