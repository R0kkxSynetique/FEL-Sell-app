using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fel;

namespace fel_gui
{
    public partial class frmMain : Form
    {
        public Carts Cart = new();

        public Items Soup = new(7.0,"Soupe de poisson",2.0);
        public Items Salade = new(7.0, "Salade de brochet", 2.0);
        public Items Frying = new(15, "Friture de sandre", 2.0);
        public Items SmokedFish = new(15, "Bondelle fumée", 4.0);
        public Items Wine = new(15.0, "Vin(Blanc, rouge, rosé)", 0);
        public Items Minerals = new(3.0, "Minérales(Pepsi, thé froid, eau)", 0);
        public Items Beer = new(4.0, "Bière(Boxer)", 0);
        public Items Coffee = new(2, "Café, thé", 0);
        public Items Glass = new(2, "Verre", 0);

        public frmMain()
        {
            InitializeComponent();
        }

        public void UpdateResume()
        {
            txtResume.Text = String.Join(Environment.NewLine, Cart.Cart);
        }

        private void btnSoup_MouseClick(object sender, MouseEventArgs e)
        {
            switch (MouseButtons)
            {
                case MouseButtons.Left:
                    Cart.AddToCart(Soup);
                    break;
                case MouseButtons.Right:
                    Cart.RemoveFromCart(Soup);
                    break;
            }
            UpdateResume();
        }

        private void btnSalade_Click(object sender, EventArgs e)
        {
            switch (MouseButtons)
            {
                case MouseButtons.Left:
                    Cart.AddToCart(Salade);
                    break;
                case MouseButtons.Right:
                    Cart.RemoveFromCart(Salade);
                    break;
            }
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            switch (MouseButtons)
            {
                case MouseButtons.Left:
                    Cart.AddToCart(Wine);
                    break;
                case MouseButtons.Right:
                    Cart.RemoveFromCart(Wine);
                    break;
            }
        }

        private void btnBeer_Click(object sender, EventArgs e)
        {
            switch (MouseButtons)
            {
                case MouseButtons.Left:
                    Cart.AddToCart(Beer);
                    break;
                case MouseButtons.Right:
                    Cart.RemoveFromCart(Beer);
                    break;
            }
        }

        private void btnFrying_Click(object sender, EventArgs e)
        {
            switch (MouseButtons)
            {
                case MouseButtons.Left:
                    Cart.AddToCart(Frying);
                    break;
                case MouseButtons.Right:
                    Cart.RemoveFromCart(Frying);
                    break;
            }
        }

        private void btnSmokedFish_Click(object sender, EventArgs e)
        {
            switch (MouseButtons)
            {
                case MouseButtons.Left:
                    Cart.AddToCart(SmokedFish);
                    break;
                case MouseButtons.Right:
                    Cart.RemoveFromCart(SmokedFish);
                    break;
            }
        }

        private void btnMineral_Click(object sender, EventArgs e)
        {
            switch (MouseButtons)
            {
                case MouseButtons.Left:
                    Cart.AddToCart(Minerals);
                    break;
                case MouseButtons.Right:
                    Cart.RemoveFromCart(Minerals);
                    break;
            }
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            switch (MouseButtons)
            {
                case MouseButtons.Left:
                    Cart.AddToCart(Coffee);
                    break;
                case MouseButtons.Right:
                    Cart.RemoveFromCart(Coffee);
                    break;
            }
        }

        private void btnGlass_Click(object sender, EventArgs e)
        {
            switch (MouseButtons)
            {
                case MouseButtons.Left:
                    Cart.AddToCart(Glass);
                    break;
                case MouseButtons.Right:
                    Cart.RemoveFromCart(Glass);
                    break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Cart.CleanCart();
        }
    }
}
