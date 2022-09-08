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
        public Carts Cart;

        public Food Soup = new(7.0, "Soupe de poisson", 2.0, new List<string> { "Brochet", "palée", "perche", "truite", "vengerons", "Céleri", "Beurre", "carrotes", "poireau", "fenouil", "oignon", "ail", "pomme-de-terre", "persil", "cerfeuil", "livèche", "aneth", "piment d'espelette", "Laurier", "Thym", "Clou de girofle", "Poiveron", "huile d'olive" }, 0);
        public Food Salade = new(7.0, "Salade de brochet", 2.0, new List<string> { "Brochet", "Huile", "Vinaigre", "Moutarde", "Sauce Chilli", "Ketchup", "Persil", "Échalotes" }, 0);
        public Food Frying = new(15, "Friture de sandre", 2.0, new List<string> { "Sandre" }, 0);
        public Food SmokedFish = new(15, "Bondelle fumée", 4.0, new List<string> { "Bondelle" }, 0);
        public Drinks Wine = new(15.0, "Vin(Blanc, rouge, rosé)", 0, 0);
        public Drinks Minerals = new(3.0, "Minérales(Pepsi, thé froid, eau)", 0, 0);
        public Drinks Beer = new(4.0, "Bière(Boxer)", 0, 0);
        public Drinks Coffee = new(2, "Café, thé", 0, 0);
        public Items Glass = new(2, "Verre", 0, 0);
        public Food Plate = new(-2, "Consigne", 0, new List<string> { "2.- les verres et les plats standard\n4.- pour les plats de Bondelle (appuyer 2x)" }, 0);

        public frmMain()
        {
            Cart = new(new List<Items> { Soup, Salade, Frying, SmokedFish, Wine, Minerals, Beer, Coffee, Glass, Plate });
            InitializeComponent();
        }

        public void AddToResume(Items item)
        {
            int index = lstResume.FindStringExact(item.Quantity + " " + item.Name);

            item.Quantity += 1;
            if (index != -1)
            {
                lstResume.Items.RemoveAt(index);
                lstResume.Items.Insert(index, item.Quantity + " " + item.Name);
            }
            else
            {
                lstResume.Items.Add(item.Quantity + " " + item.Name);
            }
            UpdateTotal();
        }

        public void RemoveFromResume(Items item)
        {
            int index = lstResume.FindStringExact(item.Quantity + " " + item.Name);

            if (index != -1)
            {
                item.Quantity -= 1;
                if (item.Quantity > 0)
                {
                    lstResume.Items.RemoveAt(index);
                    lstResume.Items.Insert(index, item.Quantity + " " + item.Name);
                }
                else
                {
                    lstResume.Items.RemoveAt(index);
                }
            }
            UpdateTotal();

        }

        public void UpdateTotal()
        {
            txtTotal.Text = Cart.CalculateTotal().ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Items items in Cart.Cart)
            {
                items.Quantity = 0;
            }
            lstResume.Items.Clear();
        }

        private void mouseDownHandler(MouseEventArgs e, Items item)
        {
            this.ActiveControl = null;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    AddToResume(item);
                    break;
                case MouseButtons.Right:
                    RemoveFromResume(item);
                    break;
                case MouseButtons.Middle:
                    string search = item.Name;
                    try
                    {
                        Food food = (Food)Cart.Cart.Single(s => s.Name == search);
                        MessageBox.Show(createFullstring(food), "Liste des ingrédients: " + item.Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Cet article ne possède pas de liste d'ingrédients", "Aucun ingrédient répertorié", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    break;
            }
        }

        private string createFullstring(Food food)
        {
            string fullstring = "";
            foreach (string ingredient in food.Ingredients)
            {
                if (!ingredient.Equals(food.Ingredients.Last()))
                {
                    fullstring += ingredient + ", ";
                }
                else
                {
                    fullstring += ingredient;
                }
            }
            return fullstring;
        }

        private void btnSoup_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownHandler(e, Soup);
        }

        private void btnSalade_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownHandler(e, Salade);
        }

        private void btnWine_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownHandler(e, Wine);
        }

        private void btnBeer_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownHandler(e, Beer);
        }

        private void btnFrying_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownHandler(e, Frying);
        }

        private void btnSmokedFish_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownHandler(e, SmokedFish);
        }

        private void btnMineral_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownHandler(e, Minerals);
        }

        private void btnCoffee_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownHandler(e, Coffee);
        }

        private void btnGlass_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownHandler(e, Glass);
        }

        private void btnReturn_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownHandler(e, Plate);
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1 or Keys.D1:
                    btnSoup_MouseDown(sender, );
                    break;
                case Keys.NumPad2 or Keys.D2:
                    btnSalade.PerformClick();
                    break;
                case Keys.NumPad3 or Keys.D3:
                    btnFrying.PerformClick();
                    break;
                case Keys.NumPad4 or Keys.D4:
                    btnSmokedFish.PerformClick();
                    break;
                case Keys.NumPad5 or Keys.D5:
                    btnWine.PerformClick();
                    break;
                case Keys.NumPad6 or Keys.D6:
                    btnBeer.PerformClick();
                    break;
                case Keys.NumPad7 or Keys.D7:
                    btnMineral.PerformClick();
                    break;
                case Keys.NumPad8 or Keys.D8:
                    btnCoffee.PerformClick();
                    break;
                case Keys.NumPad9 or Keys.D9:
                    btnGlass.PerformClick();
                    break;
                case Keys.NumPad0 or Keys.D0:
                    btnReturn.PerformClick();
                    break;
                case Keys.Enter:
                    btnReset.PerformClick();
                    break;

            }
        }
    }
}
