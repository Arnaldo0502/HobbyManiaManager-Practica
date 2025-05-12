namespace HobbyManiaManager.Forms
{
    partial class ImdbIdForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webViewImdbId = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webViewImdbId)).BeginInit();
            this.SuspendLayout();
            // 
            // webViewImdbId
            // 
            this.webViewImdbId.AllowExternalDrop = true;
            this.webViewImdbId.CreationProperties = null;
            this.webViewImdbId.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewImdbId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webViewImdbId.Location = new System.Drawing.Point(0, 0);
            this.webViewImdbId.Name = "webViewImdbId";
            this.webViewImdbId.Size = new System.Drawing.Size(800, 450);
            this.webViewImdbId.TabIndex = 0;
            this.webViewImdbId.ZoomFactor = 1D;
            this.webViewImdbId.Click += new System.EventHandler(this.webViewImdbId_Click);
            // 
            // ImdbIdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webViewImdbId);
            this.Name = "ImdbIdForm";
            this.Text = "ImdbIdForm";
            this.Load += new System.EventHandler(this.ImdbIdForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webViewImdbId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webViewImdbId;
    }
}