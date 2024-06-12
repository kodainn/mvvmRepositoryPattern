using mvvmRepositoryPattern.ViewModels;

namespace mvvmRepositoryPattern.Views;

public partial class AllNotesPage : ContentPage
{
	public AllNotesPage(NotesViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}