using System.Diagnostics;

namespace PinedaLPruebaProgreso2;

public partial class ChistesPage : ContentPage
{
	public ChistesPage()
	{
		InitializeComponent();
	}

	private void OnNuevoChisteClicked(object sender, EventArgs e)
	{
		Debug.WriteLine("Si funciona el booton");
	}


}