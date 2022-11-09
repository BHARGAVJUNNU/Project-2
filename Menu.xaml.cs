namespace Calculator;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

	private void OnLightTheme(object sender, EventArgs e)
	{
        ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        if (mergedDictionaries != null)
        {
            mergedDictionaries.Clear();
            mergedDictionaries.Add(new LightTheme());
        }
    }

	private void OnDarkTheme(object sender, EventArgs e)
	{
        ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        if (mergedDictionaries != null)
        {
            mergedDictionaries.Clear();
            mergedDictionaries.Add(new DarkTheme());
        }
    }

	private void OnGreenTheme(object sender, EventArgs e)
	{
        ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        if (mergedDictionaries != null)
        {
            mergedDictionaries.Clear();
            mergedDictionaries.Add(new GreenTheme());
        }
    }

	private void OnPinkTheme(object sender, EventArgs e)
	{
        ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        if (mergedDictionaries != null)
        {
            mergedDictionaries.Clear();
            mergedDictionaries.Add(new PinkTheme());

        }
    }
}