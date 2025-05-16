namespace HobbyManiaManager.Forms.Ticket
{
    partial class TicketForm
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
            this.lblIdCustomer = new System.Windows.Forms.Label();
            this.lblNomCustomer = new System.Windows.Forms.Label();
            this.lblIdMovie = new System.Windows.Forms.Label();
            this.lblNomMovie = new System.Windows.Forms.Label();
            this.lblDataInici = new System.Windows.Forms.Label();
            this.lblDataFi = new System.Windows.Forms.Label();
            this.lblPreu = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdCustomer
            // 
            this.lblIdCustomer.AutoSize = true;
            this.lblIdCustomer.Location = new System.Drawing.Point(176, 50);
            this.lblIdCustomer.Name = "lblIdCustomer";
            this.lblIdCustomer.Size = new System.Drawing.Size(35, 13);
            this.lblIdCustomer.TabIndex = 0;
            this.lblIdCustomer.Text = "label1";
            // 
            // lblNomCustomer
            // 
            this.lblNomCustomer.AutoSize = true;
            this.lblNomCustomer.Location = new System.Drawing.Point(176, 91);
            this.lblNomCustomer.Name = "lblNomCustomer";
            this.lblNomCustomer.Size = new System.Drawing.Size(35, 13);
            this.lblNomCustomer.TabIndex = 1;
            this.lblNomCustomer.Text = "label2";
            // 
            // lblIdMovie
            // 
            this.lblIdMovie.AutoSize = true;
            this.lblIdMovie.Location = new System.Drawing.Point(176, 137);
            this.lblIdMovie.Name = "lblIdMovie";
            this.lblIdMovie.Size = new System.Drawing.Size(35, 13);
            this.lblIdMovie.TabIndex = 2;
            this.lblIdMovie.Text = "label3";
            // 
            // lblNomMovie
            // 
            this.lblNomMovie.AutoSize = true;
            this.lblNomMovie.Location = new System.Drawing.Point(176, 191);
            this.lblNomMovie.Name = "lblNomMovie";
            this.lblNomMovie.Size = new System.Drawing.Size(35, 13);
            this.lblNomMovie.TabIndex = 3;
            this.lblNomMovie.Text = "label4";
            // 
            // lblDataInici
            // 
            this.lblDataInici.AutoSize = true;
            this.lblDataInici.Location = new System.Drawing.Point(176, 234);
            this.lblDataInici.Name = "lblDataInici";
            this.lblDataInici.Size = new System.Drawing.Size(35, 13);
            this.lblDataInici.TabIndex = 4;
            this.lblDataInici.Text = "label5";
            // 
            // lblDataFi
            // 
            this.lblDataFi.AutoSize = true;
            this.lblDataFi.Location = new System.Drawing.Point(176, 289);
            this.lblDataFi.Name = "lblDataFi";
            this.lblDataFi.Size = new System.Drawing.Size(35, 13);
            this.lblDataFi.TabIndex = 5;
            this.lblDataFi.Text = "label6";
            // 
            // lblPreu
            // 
            this.lblPreu.AutoSize = true;
            this.lblPreu.Location = new System.Drawing.Point(176, 349);
            this.lblPreu.Name = "lblPreu";
            this.lblPreu.Size = new System.Drawing.Size(35, 13);
            this.lblPreu.TabIndex = 6;
            this.lblPreu.Text = "label7";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(284, 394);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 429);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPreu);
            this.Controls.Add(this.lblDataFi);
            this.Controls.Add(this.lblDataInici);
            this.Controls.Add(this.lblNomMovie);
            this.Controls.Add(this.lblIdMovie);
            this.Controls.Add(this.lblNomCustomer);
            this.Controls.Add(this.lblIdCustomer);
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdCustomer;
        private System.Windows.Forms.Label lblNomCustomer;
        private System.Windows.Forms.Label lblIdMovie;
        private System.Windows.Forms.Label lblNomMovie;
        private System.Windows.Forms.Label lblDataInici;
        private System.Windows.Forms.Label lblDataFi;
        private System.Windows.Forms.Label lblPreu;
        private System.Windows.Forms.Button btnExit;
    }
}