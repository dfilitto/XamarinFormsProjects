using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace appSearchBar
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<String> estados = new List<String>
      {
          "Acre (AC)","Alagoas (AL)","Amapá (AP)","Amazonas (AM)",
          "Bahia (BA)","Ceará (CE)","Distrito Federal (DF)",
          "Espírito Santo (ES)","Goiás (GO)","Maranhão (MA)",
          "Mato Grosso (MT)","Mato Grosso do Sul(MS)","Minas Gerais(MG)",
          "Pará(PA)","Paraíba(PB)","Paraná(PR)","Pernambuco(PE)",
          "Piauí(PI)","Rio de Janeiro(RJ)","Rio Grande do Norte(RN)",
          "Rio Grande do Sul(RS)","Rondônia(RO)","Roraima(RR)",
          "Santa Catarina(SC)","São Paulo(SP)","Sergipe(SE)",
          "Tocantins(TO)"
      };

        public MainPage()
        {
            InitializeComponent();
            EstadosListView.ItemsSource = estados;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var texto = EstadoSearchBar.Text;
            EstadosListView.ItemsSource = estados.Where(
                  x => x.ToLower().Contains(texto.ToLower()));
        }
    }
}
