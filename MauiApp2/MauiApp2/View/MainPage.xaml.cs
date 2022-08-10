using MauiApp2.Model;

namespace MauiApp2.View;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		var users = new List<User>(){
			new User("Rafael Bortolozo", "email1@gmail.com", 21),
			new User("Gabriel Bortolozo", "email2@gmail.com", 35),
			new User("Flavio Bortolozo", "email3@gmail.com", 17),
			new User("Eduardo Bortolozo", "email4@gmail.com", 40)
		};

        this.BindingContext = users;



    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		CounterBtn.Text = $"Clicked {count} Times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

