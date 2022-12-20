using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ReproductorMusica
{
    public partial class Reproductor : Form
    {
        string[] paylist;
        int numPista=0;
        public Reproductor()
        {
            InitializeComponent();
            WinMediaPlayer.URL = @"%HOME%\Disc 1\01.Thunderstruck.mp3";
            WinMediaPlayer.enableContextMenu = false;
            
           
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            
         
            AbrirMp3.Multiselect = true;
            AbrirMp3.Filter = "Archivos de Audio(*.mp3;*.wpl;*.wma)|*.mp3;*.wpl;*.wma";
            AbrirMp3.CheckFileExists = true;
            AbrirMp3.Title = "Abrir Archivo";
            AbrirMp3.ShowDialog(this);
            try
            {
                AbrirMp3.OpenFile();
                paylist = AbrirMp3.FileNames;
                WinMediaPlayer.URL = paylist[numPista];
                foreach(string archivos in paylist)
                {
                    Historial.Text += archivos + "\n";
                }
            }
            catch { }
          

            
        }

        private void WinMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            
            Historial.Text+=(WinMediaPlayer.playState.ToString())+"\n";
            try
            {
                if ((WinMediaPlayer.playState.ToString()).Equals("wmppsMediaEnded") && paylist.Length > 0 && numPista <= paylist.Length)
                {
                    numPista++;
                    WinMediaPlayer.URL = paylist[numPista];
                    Historial.Text += paylist[numPista] + "\n";
                    
                }
                if ((WinMediaPlayer.playState.ToString()).Equals("wmppsReady"))
                {
                    WinMediaPlayer.Ctlcontrols.play();
                }
            }
            catch { }
        }

        private void axVLCPlugin21_Enter(object sender, EventArgs e)
        {

        }

        private void btnCrearLista_Click(object sender, EventArgs e)
        {
            XmlTextWriter writer;
            writer = new XmlTextWriter("Lista.wpl", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();
            writer.WriteStartElement("smil");
            writer.WriteElementString("nodo1", "texto del nodo1");
            writer.WriteElementString("nodo2", "texto del nodo2");

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
        }
    }
}
