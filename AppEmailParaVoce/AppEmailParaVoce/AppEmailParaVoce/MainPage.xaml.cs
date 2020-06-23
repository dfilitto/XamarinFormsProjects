using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppEmailParaVoce
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<String> mensagens;
        String msg;
        public MainPage()
        {
            InitializeComponent();
            CriaMensagens();
            msg = SelecionaMensagem();
            lbMsg.Text = msg;
        }
        private String SelecionaMensagem()
        {
            String texto="";
            Random r = new Random();
            int i = r.Next(0, mensagens.Count-1);
            texto = mensagens[i];
            return texto;
        }
        private void CriaMensagens()
        {
            mensagens = new List<string>();
            mensagens.Add("Que seu dia seja especial");
            mensagens.Add("Que ilumine a sua vida");
            mensagens.Add("Visite o site www.dfilitto.com.br e aprenda muito sobre programação");
            mensagens.Add("Visite o site www.makeindiegames.com.br e aprenda muito sobre programação de jogos");
        }

        private async void btEnviar_Clicked(object sender, EventArgs e)
        {
            try
            {
                EmailMessage mensagem = new EmailMessage();
                mensagem.Subject = "Mensagem para você";
                mensagem.Body = msg;
                List<String> destinatarios = new List<string>();
                destinatarios.Add(etEmail.Text);
                mensagem.To = destinatarios;
                var fn = "foto.jpg";
                var file = Path.Combine(FileSystem.CacheDirectory, fn);
                if (File.Exists(file))
                {
                    File.WriteAllText(file, "Hello World");
                    mensagem.Attachments.Add(new EmailAttachment(file));
                }
                await Email.ComposeAsync(mensagem);
            }
            catch (FeatureNotSupportedException fbsEx)
            {
                DisplayAlert("Error", fbsEx.Message, "OK");
            }
            catch (Exception ex)
            {
               DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
