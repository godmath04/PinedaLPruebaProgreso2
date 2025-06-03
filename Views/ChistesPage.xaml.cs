using PinedaLPruebaProgreso2.Services;
using System.Diagnostics;

namespace PinedaLPruebaProgreso2;

public partial class ChistesPage : ContentPage
{
    private readonly ChisteService _chisteService;
	public ChistesPage()
	{
		InitializeComponent();
        _chisteService = new ChisteService();
        Chistes();
	}
    

    private async void Chistes()
    {
        try
        {
            var chiste = await _chisteService.GetChisteAsync();
            lblChiste.Text = chiste.ToString(); 
            
        }
        catch (Exception ex)
        {
            lblChiste.Text = $"No carga el chiste: {ex.Message}";
        }
    }


    private void OnNuevoChisteClicked(object sender, EventArgs e)
	{
        Chistes();
        Debug.WriteLine("Si funciona el booton");
	}


}