namespace Calculator;

public partial class CorrectAnswerPage : ContentPage
{
	public CorrectAnswerPage()
	{
		InitializeComponent();
	}

    public async void navigateToNextQuestion(object sender, EventArgs e)
    {
        var int_num = PageNumber.pageNum + 1;
        PageNumber.setPage(int_num);
        await Navigation.PushAsync(new Questions());
    }
}