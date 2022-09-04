
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
            this.txtTotalSoup = new System.Windows.Forms.TextBox();
            this.txtTotalSalade = new System.Windows.Forms.TextBox();
            this.txtTotalWine = new System.Windows.Forms.TextBox();
            this.TxtTotalBeer = new System.Windows.Forms.TextBox();
            this.txtTotalFrying = new System.Windows.Forms.TextBox();
            this.txtSmokedFish = new System.Windows.Forms.TextBox();
            this.TxtMineral = new System.Windows.Forms.TextBox();
            this.txtCoffee = new System.Windows.Forms.TextBox();
            this.txtGlass = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtResume = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSoup
            // 
            this.btnSoup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSoup.Location = new System.Drawing.Point(38, 43);
            this.btnSoup.Name = "btnSoup";
            this.btnSoup.Size = new System.Drawing.Size(150, 150);
            this.btnSoup.TabIndex = 0;
            this.btnSoup.Text = "Soupe de poisson";
            this.btnSoup.UseVisualStyleBackColor = false;
            this.btnSoup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSoup_MouseClick);
            // 
            // btnSalade
            // 
            this.btnSalade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalade.Location = new System.Drawing.Point(256, 43);
            this.btnSalade.Name = "btnSalade";
            this.btnSalade.Size = new System.Drawing.Size(150, 150);
            this.btnSalade.TabIndex = 1;
            this.btnSalade.Text = "Salade de brochet";
            this.btnSalade.UseVisualStyleBackColor = false;
            this.btnSalade.Click += new System.EventHandler(this.btnSalade_Click);
            // 
            // btnWine
            // 
            this.btnWine.BackColor = System.Drawing.Color.Red;
            this.btnWine.Location = new System.Drawing.Point(476, 43);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(150, 150);
            this.btnWine.TabIndex = 2;
            this.btnWine.Text = "Vin (Blanc, rouge, rosé)";
            this.btnWine.UseVisualStyleBackColor = false;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // btnBeer
            // 
            this.btnBeer.BackColor = System.Drawing.Color.Orange;
            this.btnBeer.Location = new System.Drawing.Point(696, 43);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(150, 150);
            this.btnBeer.TabIndex = 3;
            this.btnBeer.Text = "Bière (Boxer)";
            this.btnBeer.UseVisualStyleBackColor = false;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // btnFrying
            // 
            this.btnFrying.BackColor = System.Drawing.Color.Yellow;
            this.btnFrying.Location = new System.Drawing.Point(38, 244);
            this.btnFrying.Name = "btnFrying";
            this.btnFrying.Size = new System.Drawing.Size(150, 150);
            this.btnFrying.TabIndex = 4;
            this.btnFrying.Text = "Friture de sandre";
            this.btnFrying.UseVisualStyleBackColor = false;
            this.btnFrying.Click += new System.EventHandler(this.btnFrying_Click);
            // 
            // btnSmokedFish
            // 
            this.btnSmokedFish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSmokedFish.Location = new System.Drawing.Point(256, 244);
            this.btnSmokedFish.Name = "btnSmokedFish";
            this.btnSmokedFish.Size = new System.Drawing.Size(150, 150);
            this.btnSmokedFish.TabIndex = 5;
            this.btnSmokedFish.Text = "Bondelle fumée";
            this.btnSmokedFish.UseVisualStyleBackColor = false;
            this.btnSmokedFish.Click += new System.EventHandler(this.btnSmokedFish_Click);
            // 
            // btnMineral
            // 
            this.btnMineral.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMineral.Location = new System.Drawing.Point(476, 244);
            this.btnMineral.Name = "btnMineral";
            this.btnMineral.Size = new System.Drawing.Size(150, 150);
            this.btnMineral.TabIndex = 6;
            this.btnMineral.Text = "Minérale (Pepsi, Thé froid, Eau)";
            this.btnMineral.UseVisualStyleBackColor = false;
            this.btnMineral.Click += new System.EventHandler(this.btnMineral_Click);
            // 
            // btnCoffee
            // 
            this.btnCoffee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCoffee.Location = new System.Drawing.Point(696, 244);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(150, 150);
            this.btnCoffee.TabIndex = 7;
            this.btnCoffee.Text = "Café, thé";
            this.btnCoffee.UseVisualStyleBackColor = false;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            // 
            // btnGlass
            // 
            this.btnGlass.Location = new System.Drawing.Point(38, 447);
            this.btnGlass.Name = "btnGlass";
            this.btnGlass.Size = new System.Drawing.Size(150, 150);
            this.btnGlass.TabIndex = 8;
            this.btnGlass.Text = "Verre";
            this.btnGlass.UseVisualStyleBackColor = true;
            this.btnGlass.Click += new System.EventHandler(this.btnGlass_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(696, 522);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(150, 23);
            this.txtTotal.TabIndex = 10;
            // 
            // txtTotalSoup
            // 
            this.txtTotalSoup.Location = new System.Drawing.Point(38, 199);
            this.txtTotalSoup.Name = "txtTotalSoup";
            this.txtTotalSoup.Size = new System.Drawing.Size(150, 23);
            this.txtTotalSoup.TabIndex = 11;
            // 
            // txtTotalSalade
            // 
            this.txtTotalSalade.Location = new System.Drawing.Point(256, 199);
            this.txtTotalSalade.Name = "txtTotalSalade";
            this.txtTotalSalade.Size = new System.Drawing.Size(150, 23);
            this.txtTotalSalade.TabIndex = 12;
            // 
            // txtTotalWine
            // 
            this.txtTotalWine.Location = new System.Drawing.Point(476, 199);
            this.txtTotalWine.Name = "txtTotalWine";
            this.txtTotalWine.Size = new System.Drawing.Size(150, 23);
            this.txtTotalWine.TabIndex = 13;
            // 
            // TxtTotalBeer
            // 
            this.TxtTotalBeer.Location = new System.Drawing.Point(696, 199);
            this.TxtTotalBeer.Name = "TxtTotalBeer";
            this.TxtTotalBeer.Size = new System.Drawing.Size(150, 23);
            this.TxtTotalBeer.TabIndex = 14;
            // 
            // txtTotalFrying
            // 
            this.txtTotalFrying.Location = new System.Drawing.Point(38, 400);
            this.txtTotalFrying.Name = "txtTotalFrying";
            this.txtTotalFrying.Size = new System.Drawing.Size(150, 23);
            this.txtTotalFrying.TabIndex = 15;
            // 
            // txtSmokedFish
            // 
            this.txtSmokedFish.Location = new System.Drawing.Point(256, 400);
            this.txtSmokedFish.Name = "txtSmokedFish";
            this.txtSmokedFish.Size = new System.Drawing.Size(150, 23);
            this.txtSmokedFish.TabIndex = 16;
            // 
            // TxtMineral
            // 
            this.TxtMineral.Location = new System.Drawing.Point(476, 400);
            this.TxtMineral.Name = "TxtMineral";
            this.TxtMineral.Size = new System.Drawing.Size(150, 23);
            this.TxtMineral.TabIndex = 17;
            // 
            // txtCoffee
            // 
            this.txtCoffee.Location = new System.Drawing.Point(696, 400);
            this.txtCoffee.Name = "txtCoffee";
            this.txtCoffee.Size = new System.Drawing.Size(150, 23);
            this.txtCoffee.TabIndex = 18;
            // 
            // txtGlass
            // 
            this.txtGlass.Location = new System.Drawing.Point(38, 603);
            this.txtGlass.Name = "txtGlass";
            this.txtGlass.Size = new System.Drawing.Size(150, 23);
            this.txtGlass.TabIndex = 19;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(696, 571);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 55);
            this.btnReset.TabIndex = 20;
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
            // txtResume
            // 
            this.txtResume.Location = new System.Drawing.Point(256, 447);
            this.txtResume.Multiline = true;
            this.txtResume.Name = "txtResume";
            this.txtResume.Size = new System.Drawing.Size(370, 179);
            this.txtResume.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 671);
            this.Controls.Add(this.txtResume);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtGlass);
            this.Controls.Add(this.txtCoffee);
            this.Controls.Add(this.TxtMineral);
            this.Controls.Add(this.txtSmokedFish);
            this.Controls.Add(this.txtTotalFrying);
            this.Controls.Add(this.TxtTotalBeer);
            this.Controls.Add(this.txtTotalWine);
            this.Controls.Add(this.txtTotalSalade);
            this.Controls.Add(this.txtTotalSoup);
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
            this.Name = "Form1";
            this.Text = "frmMain";
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
        private System.Windows.Forms.TextBox txtTotalSoup;
        private System.Windows.Forms.TextBox txtTotalSalade;
        private System.Windows.Forms.TextBox txtTotalWine;
        private System.Windows.Forms.TextBox TxtTotalBeer;
        private System.Windows.Forms.TextBox txtTotalFrying;
        private System.Windows.Forms.TextBox txtSmokedFish;
        private System.Windows.Forms.TextBox TxtMineral;
        private System.Windows.Forms.TextBox txtCoffee;
        private System.Windows.Forms.TextBox txtGlass;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtResume;
    }
}

