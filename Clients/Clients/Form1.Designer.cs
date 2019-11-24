namespace Clients
{
    partial class NewShore
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
            this.RtbClients = new System.Windows.Forms.RichTextBox();
            this.BtnLoadC = new System.Windows.Forms.Button();
            this.RtbLetters = new System.Windows.Forms.RichTextBox();
            this.BtnLoadL = new System.Windows.Forms.Button();
            this.BtnResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RtbClients
            // 
            this.RtbClients.Location = new System.Drawing.Point(223, 109);
            this.RtbClients.Name = "RtbClients";
            this.RtbClients.Size = new System.Drawing.Size(153, 182);
            this.RtbClients.TabIndex = 0;
            this.RtbClients.Text = "";
            // 
            // BtnLoadC
            // 
            this.BtnLoadC.Location = new System.Drawing.Point(93, 109);
            this.BtnLoadC.Name = "BtnLoadC";
            this.BtnLoadC.Size = new System.Drawing.Size(93, 40);
            this.BtnLoadC.TabIndex = 1;
            this.BtnLoadC.Text = "LoadClients";
            this.BtnLoadC.UseVisualStyleBackColor = true;
            this.BtnLoadC.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // RtbLetters
            // 
            this.RtbLetters.Location = new System.Drawing.Point(418, 109);
            this.RtbLetters.Name = "RtbLetters";
            this.RtbLetters.Size = new System.Drawing.Size(153, 182);
            this.RtbLetters.TabIndex = 2;
            this.RtbLetters.Text = "";
            // 
            // BtnLoadL
            // 
            this.BtnLoadL.Location = new System.Drawing.Point(93, 179);
            this.BtnLoadL.Name = "BtnLoadL";
            this.BtnLoadL.Size = new System.Drawing.Size(93, 38);
            this.BtnLoadL.TabIndex = 3;
            this.BtnLoadL.Text = "LoadLetters";
            this.BtnLoadL.UseVisualStyleBackColor = true;
            this.BtnLoadL.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BtnResults
            // 
            this.BtnResults.Location = new System.Drawing.Point(93, 253);
            this.BtnResults.Name = "BtnResults";
            this.BtnResults.Size = new System.Drawing.Size(93, 38);
            this.BtnResults.TabIndex = 6;
            this.BtnResults.Text = "Results";
            this.BtnResults.UseVisualStyleBackColor = true;
            this.BtnResults.Click += new System.EventHandler(this.BtnResults_Click);
            // 
            // NewShore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(649, 391);
            this.Controls.Add(this.BtnResults);
            this.Controls.Add(this.BtnLoadL);
            this.Controls.Add(this.RtbLetters);
            this.Controls.Add(this.BtnLoadC);
            this.Controls.Add(this.RtbClients);
            this.MaximizeBox = false;
            this.Name = "NewShore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients NewShore";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RtbClients;
        private System.Windows.Forms.Button BtnLoadC;
        private System.Windows.Forms.RichTextBox RtbLetters;
        private System.Windows.Forms.Button BtnLoadL;
        private System.Windows.Forms.Button BtnResults;
    }
}

