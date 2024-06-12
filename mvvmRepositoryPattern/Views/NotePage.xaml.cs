using mvvmRepositoryPattern.ViewModels;

namespace mvvmRepositoryPattern.Views;

public partial class NotePage : ContentPage
{
	public NotePage(NoteViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;

    }
}