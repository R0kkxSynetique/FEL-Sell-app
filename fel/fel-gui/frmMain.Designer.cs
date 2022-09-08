
namespace fel_gui
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSoup = new System.Windows.Forms.Button();
            this.btnSalade = new System.Windows.Forms.Button();
            this.btnWine = new System.Windows.Forms.Button();
            this.btnBeer = new System.Windows.Forms.Button();
            this.btnFrying = new System.Windows.Forms.Button();
            this.btnSmokedFish = new System.Windows.Forms.Button();
            this.btnMineral = new System.Windows.Forms.Button();
            this.btnCoffee = new System.Windows.Forms.Button();
            this.btnGlass = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lstResume = new System.Windows.Forms.ListBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSoup
            // 
            this.btnSoup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSoup.Location = new System.Drawing.Point(38, 43);
            this.btnSoup.Name = "btnSoup";
            this.btnSoup.Size = new System.Drawing.Size(150, 150);
            this.btnSoup.TabIndex = 0;
            this.btnSoup.TabStop = false;
            this.btnSoup.Text = "Soupe de poisson";
            this.btnSoup.UseVisualStyleBackColor = false;
            this.btnSoup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSoup_MouseDown);
            // 
            // btnSalade
            // 
            this.btnSalade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalade.Location = new System.Drawing.Point(256, 43);
            this.btnSalade.Name = "btnSalade";
            this.btnSalade.Size = new System.Drawing.Size(150, 150);
            this.btnSalade.TabIndex = 1;
            this.btnSalade.TabStop = false;
            this.btnSalade.Text = "Salade de brochet";
            this.btnSalade.UseVisualStyleBackColor = false;
            this.btnSalade.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSalade_MouseDown);
            // 
            // btnWine
            // 
            this.btnWine.BackColor = System.Drawing.Color.Red;
            this.btnWine.Location = new System.Drawing.Point(476, 43);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(150, 150);
            this.btnWine.TabIndex = 2;
            this.btnWine.TabStop = false;
            this.btnWine.Text = "Vin (Blanc, rouge, rosé)";
            this.btnWine.UseVisualStyleBackColor = false;
            this.btnWine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnWine_MouseDown);
            // 
            // btnBeer
            // 
            this.btnBeer.BackColor = System.Drawing.Color.Orange;
            this.btnBeer.Location = new System.Drawing.Point(696, 43);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(150, 150);
            this.btnBeer.TabIndex = 3;
            this.btnBeer.TabStop = false;
            this.btnBeer.Text = "Bière (Boxer)";
            this.btnBeer.UseVisualStyleBackColor = false;
            this.btnBeer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBeer_MouseDown);
            // 
            // btnFrying
            // 
            this.btnFrying.BackColor = System.Drawing.Color.Yellow;
            this.btnFrying.Location = new System.Drawing.Point(38, 244);
            this.btnFrying.Name = "btnFrying";
            this.btnFrying.Size = new System.Drawing.Size(150, 150);
            this.btnFrying.TabIndex = 4;
            this.btnFrying.TabStop = false;
            this.btnFrying.Text = "Friture de sandre";
            this.btnFrying.UseVisualStyleBackColor = false;
            this.btnFrying.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFrying_MouseDown);
            // 
            // btnSmokedFish
            // 
            this.btnSmokedFish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSmokedFish.Location = new System.Drawing.Point(256, 244);
            this.btnSmokedFish.Name = "btnSmokedFish";
            this.btnSmokedFish.Size = new System.Drawing.Size(150, 150);
            this.btnSmokedFish.TabIndex = 5;
            this.btnSmokedFish.TabStop = false;
            this.btnSmokedFish.Text = "Bondelle fumée";
            this.btnSmokedFish.UseVisualStyleBackColor = false;
            this.btnSmokedFish.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSmokedFish_MouseDown);
            // 
            // btnMineral
            // 
            this.btnMineral.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMineral.Location = new System.Drawing.Point(476, 244);
            this.btnMineral.Name = "btnMineral";
            this.btnMineral.Size = new System.Drawing.Size(150, 150);
            this.btnMineral.TabIndex = 6;
            this.btnMineral.TabStop = false;
            this.btnMineral.Text = "Minérale (Pepsi, Thé froid, Eau)";
            this.btnMineral.UseVisualStyleBackColor = false;
            this.btnMineral.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMineral_MouseDown);
            // 
            // btnCoffee
            // 
            this.btnCoffee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCoffee.Location = new System.Drawing.Point(696, 244);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(150, 150);
            this.btnCoffee.TabIndex = 7;
            this.btnCoffee.TabStop = false;
            this.btnCoffee.Text = "Café, thé";
            this.btnCoffee.UseVisualStyleBackColor = false;
            this.btnCoffee.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCoffee_MouseDown);
            // 
            // btnGlass
            // 
            this.btnGlass.Location = new System.Drawing.Point(38, 447);
            this.btnGlass.Name = "btnGlass";
            this.btnGlass.Size = new System.Drawing.Size(150, 150);
            this.btnGlass.TabIndex = 8;
            this.btnGlass.TabStop = false;
            this.btnGlass.Text = "Verre";
            this.btnGlass.UseVisualStyleBackColor = true;
            this.btnGlass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGlass_MouseDown);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(696, 522);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(150, 23);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(696, 571);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 55);
            this.btnReset.TabIndex = 20;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Payer";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(655, 525);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 15);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total:";
            // 
            // lstResume
            // 
            this.lstResume.FormattingEnabled = true;
            this.lstResume.ItemHeight = 15;
            this.lstResume.Location = new System.Drawing.Point(256, 451);
            this.lstResume.Name = "lstResume";
            this.lstResume.Size = new System.Drawing.Size(370, 169);
            this.lstResume.TabIndex = 22;
            this.lstResume.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(696, 451);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(150, 55);
            this.btnReturn.TabIndex = 23;
            this.btnReturn.TabStop = false;
            this.btnReturn.Text = "Retour consigne";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnReturn_MouseDown);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 671);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lstResume);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnGlass);
            this.Controls.Add(this.btnCoffee);
            this.Controls.Add(this.btnMineral);
            this.Controls.Add(this.btnSmokedFish);
            this.Controls.Add(this.btnFrying);
            this.Controls.Add(this.btnBeer);
            this.Controls.Add(this.btnWine);
            this.Controls.Add(this.btnSalade);
            this.Controls.Add(this.btnSoup);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSoup;
        private System.Windows.Forms.Button btnSalade;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.Button btnFrying;
        private System.Windows.Forms.Button btnSmokedFish;
        private System.Windows.Forms.Button btnMineral;
        private System.Windows.Forms.Button btnCoffee;
        private System.Windows.Forms.Button btnGlass;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListBox lstResume;
        private System.Windows.Forms.Button btnReturn;
    }
}

