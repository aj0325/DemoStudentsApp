using Demo.DemoCBIA.ViewModels;
using Microsoft.Maui.Controls.Maps;
using DevExpress.Maui.Controls;

namespace Demo.DemoCBIA.Pages;

public partial class MapPage : ContentPage
{
	public MapPage()
	{
		InitializeComponent();
	}

    private void Map_Clicked(object sender, Microsoft.Maui.Controls.Maps.MapClickedEventArgs e)
    {

    }
    private void Pin_MarkerClicked(object sender, Microsoft.Maui.Controls.Maps.PinClickedEventArgs e)
    {
        ((MapViewModel)this.BindingContext).SelectedCity = (CityItem)((Pin)sender).BindingContext;
        bottomSheet.State = DevExpress.Maui.Controls.BottomSheetState.HalfExpanded;
        bottomSheet.HalfExpandedRatio = 0.6;

    }
}