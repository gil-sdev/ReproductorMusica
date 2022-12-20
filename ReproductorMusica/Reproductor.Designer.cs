namespace ReproductorMusica
{
    partial class Reproductor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reproductor));
            this.WinMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.AbrirMp3 = new System.Windows.Forms.OpenFileDialog();
            this.btnCargar = new System.Windows.Forms.Button();
            this.Historial = new System.Windows.Forms.RichTextBox();
            this.btnCrearLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WinMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // WinMediaPlayer
            // 
            this.WinMediaPlayer.AllowDrop = true;
            this.WinMediaPlayer.Enabled = true;
            this.WinMediaPlayer.Location = new System.Drawing.Point(12, 0);
            this.WinMediaPlayer.Name = "WinMediaPlayer";
            this.WinMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WinMediaPlayer.OcxState")));
            this.WinMediaPlayer.Size = new System.Drawing.Size(413, 248);
            this.WinMediaPlayer.TabIndex = 0;
            this.WinMediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.WinMediaPlayer_PlayStateChange);
            // 
            // AbrirMp3
            // 
            this.AbrirMp3.FileName = "openFileDialog1";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(350, 182);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // Historial
            // 
            this.Historial.Location = new System.Drawing.Point(12, 254);
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(413, 157);
            this.Historial.TabIndex = 2;
            this.Historial.Text = "";
            // 
            // btnCrearLista
            // 
            this.btnCrearLista.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCrearLista.Location = new System.Drawing.Point(724, 125);
            this.btnCrearLista.Name = "btnCrearLista";
            this.btnCrearLista.Size = new System.Drawing.Size(75, 23);
            this.btnCrearLista.TabIndex = 3;
            this.btnCrearLista.Text = "Crear Lista";
            this.btnCrearLista.UseVisualStyleBackColor = false;
            this.btnCrearLista.Click += new System.EventHandler(this.btnCrearLista_Click);
            // 
            // Reproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 504);
            this.Controls.Add(this.btnCrearLista);
            this.Controls.Add(this.Historial);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.WinMediaPlayer);
            this.Name = "Reproductor";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.WinMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WinMediaPlayer;
        private System.Windows.Forms.OpenFileDialog AbrirMp3;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.RichTextBox Historial;
        private System.Windows.Forms.Button btnCrearLista;
    }
}

