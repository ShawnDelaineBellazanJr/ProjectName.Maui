using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace Telerik.Theming.Telerik.Styles;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class CollectionView : ResourceDictionary
{
	public CollectionView()
	{
		InitializeComponent();
	}
}