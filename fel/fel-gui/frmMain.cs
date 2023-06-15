using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using fel;
using Newtonsoft.Json;
using static System.Windows.Forms.Design.AxImporter;

namespace fel_gui
{
    public partial class frmMain : Form
    {
        public Carts Cart;

        public Food Soup = new(7.0, "Soupe de poisson", 2.0, new List<string> { "Brochet", "palée", "perche", "truite", "vengerons", "Céleri", "Beurre", "carrotes", "poireau", "fenouil", "oignon", "ail", "pomme-de-terre", "persil", "cerfeuil", "livèche", "aneth", "piment d'espelette", "Laurier", "Thym", "Clou de girofle", "Poiveron", "huile d'olive" }, 0);
        public Food Salade = new(8.0, "Salade de brochet", 2.0, new List<string> { "Brochet", "Huile", "Vinaigre", "Moutarde", "Sauce Chilli", "Ketchup", "Persil", "Échalotes" }, 0);
        public Food Frying = new(15, "Friture de sandre", 2.0, new List<string> { "Sandre" }, 0);
        //public Food SmokedFish = new(15, "Bondelle fumée", 4.0, new List<string> { "Bondelle" }, 0);
        public Drinks Wine = new(18.0, "Vin(Blanc, rouge, rosé)", 0, 0);
        public Drinks Minerals = new(4.0, "Minérales(Pepsi, thé froid, eau)", 0, 0);
        public Drinks Beer = new(4.0, "Bière(Boxer)", 0, 0);
        public Drinks Coffee = new(2, "Café, thé", 0, 0);
        public Drinks WineGlass = new(4, "Ballon de vin(Blanc, rouge, rosé)", 2, 0);
        public Items Glass = new(2, "Verre", 0, 0);
        public Food Plate = new(-2, "Consigne", 0, new List<string> { "2.- les verres et les plats standard\n4.- pour les plats de Bondelle (appuyer 2x)" }, 0);

        public static string Filename = @"./json/allTransactions.json";
        public static string JsonDirectory = @"./json";

        public frmMain()
        {
            Cart = new(new List<Items> { Soup, Salade, Frying, Wine, WineGlass, Minerals, Beer, Coffee, Glass, Plate });
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

        public void UpdateJson()
        {
            string json = File.ReadAllText(Filename);
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            for (int i = 0; i < 10; i++)
            {
                jsonObj[i]["Quantity"] += Cart.Cart[i].Quantity;

            }
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(Filename, output);
        }

        public static void PrettyWrite(List<Items> items)
        {
            if (!Directory.Exists(JsonDirectory))
            {
                Directory.CreateDirectory(JsonDirectory);
            }
            using (StreamWriter file = File.CreateText(Filename))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, items);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(!File.Exists(Filename))
            {
                PrettyWrite(Cart.Cart);
            }
            else
            {
                UpdateJson();
            }
            foreach (Items items in Cart.Cart)
            {
                items.Quantity = 0;
            }
            lstResume.Items.Clear();
            txtTotal.Clear();
            this.ActiveControl = null;
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
            mouseDownHandler(e, WineGlass);
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
        private void btnWineGlass_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownHandler(e, WineGlass);
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control || e.Modifiers == Keys.Alt)
            {
                switch (e.KeyCode)
                {
                    case Keys.NumPad1 or Keys.D1:
                        btnSoup_MouseDown(sender, new(MouseButtons.Right, 1, 0, 0, 0));
                        break;
                    case Keys.NumPad2 or Keys.D2:
                        btnSalade_MouseDown(sender, new(MouseButtons.Right, 1, 0, 0, 0));
                        break;
                    case Keys.NumPad3 or Keys.D3:
                        btnFrying_MouseDown(sender, new(MouseButtons.Right, 1, 0, 0, 0));
                        break;
                    case Keys.NumPad4 or Keys.D4:
                        btnWineGlass_MouseDown(sender, new(MouseButtons.Right, 1, 0, 0, 0));
                        break;
                    case Keys.NumPad5 or Keys.D5:
                        btnWine_MouseDown(sender, new(MouseButtons.Right, 1, 0, 0, 0));
                        break;
                    case Keys.NumPad6 or Keys.D6:
                        btnBeer_MouseDown(sender, new(MouseButtons.Right, 1, 0, 0, 0));
                        break;
                    case Keys.NumPad7 or Keys.D7:
                        btnMineral_MouseDown(sender, new(MouseButtons.Right, 1, 0, 0, 0));
                        break;
                    case Keys.NumPad8 or Keys.D8:
                        btnCoffee_MouseDown(sender, new(MouseButtons.Right, 1, 0, 0, 0));
                        break;
                    case Keys.NumPad9 or Keys.D9:
                        btnGlass_MouseDown(sender, new(MouseButtons.Right, 1, 0, 0, 0));
                        break;
                    case Keys.NumPad0 or Keys.D0:
                        btnReturn_MouseDown(sender, new(MouseButtons.Right, 1, 0, 0, 0));
                        break;
                    case Keys.Space:
                        btnWineGlass_MouseDown(sender, new(MouseButtons.Right, 1, 0, 0, 0));
                        break;
                    case Keys.Enter:
                        btnReset.PerformClick();
                        break;
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.NumPad1 or Keys.D1:
                        btnSoup_MouseDown(sender, new(MouseButtons.Left, 1, 0, 0, 0));
                        break;
                    case Keys.NumPad2 or Keys.D2:
                        btnSalade_MouseDown(sender, new(MouseButtons.Left, 1, 0, 0, 0));
                        break;
                    case Keys.NumPad3 or Keys.D3:
                        btnFrying_MouseDown(sender, new(MouseButtons.Left, 1, 0, 0, 0));
                        break;
                    case Keys.NumPad4 or Keys.D4:
                        btnWineGlass_MouseDown(sender, new(MouseButtons.Left, 1, 0, 0, 0));
                        break;
                    case Keys.NumPad5 or Keys.D5:
                        btnWine_MouseDown(sender, new(MouseButtons.Left, 1, 0, 0, 0));
                        break;
                    case Keys.NumPad6 or Keys.D6:
                        btnBeer_MouseDown(sender, new(MouseButtons.Left, 1, 0, 0, 0));
                        break;
                    case Keys.NumPad7 or Keys.D7:
                        btnMineral_MouseDown(sender, new(MouseButtons.Left, 1, 0, 0, 0));
                        break;
                    case Keys.NumPad8 or Keys.D8:
                        btnCoffee_MouseDown(sender, new(MouseButtons.Left, 1, 0, 0, 0));
                        break;
                    case Keys.NumPad9 or Keys.D9:
                        btnGlass_MouseDown(sender, new(MouseButtons.Left, 1, 0, 0, 0));
                        break;
                    case Keys.NumPad0 or Keys.D0:
                        btnReturn_MouseDown(sender, new(MouseButtons.Left, 1, 0, 0, 0));
                        break;
                    case Keys.Space:
                        btnWineGlass_MouseDown(sender, new(MouseButtons.Left, 1, 0, 0, 0));
                        break;
                    case Keys.Enter:
                        btnReset.PerformClick();
                        break;
                }
            }
        }

        private void frmMain_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            double total = 0;
            double returnTotal = 0;

            List<Items> items = new List<Items>();

            if (!File.Exists(Filename))
            {
                PrettyWrite(Cart.Cart);
            }

            string json = File.ReadAllText(Filename);
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

            foreach (dynamic obj in jsonObj)
            {
                total += (int)obj["Quantity"] * (int)obj["Price"];
                returnTotal += (int)obj["Quantity"] * (int)obj["Deposit"];
                Items item = new((double)obj["Price"], (string)obj["Name"], (double)obj["Deposit"], (int)obj["Quantity"]);
                items.Add(item);
            }

            MessageBox.Show("Le chiffre d'affaire est de: " + total +
                "\nLes sorties dû aux consignes est de: " + returnTotal +
                "\nLe nombre de soupes de poisson vendues est de: " + items[0].Quantity +
                "\nLe nombre de salade de brochet vendues est de: " + items[1].Quantity +
                "\nLe nombre de friture de sandre vendues est de: " + items[2].Quantity +
                "\nLe nombre de bouteille de vin vendues est de: " + items[3].Quantity +
                "\nLe nombre de verre de vin vendus est de: " + items[4].Quantity +
                "\nLe nombre de bière vendues est de: " + items[5].Quantity +
                "\nLe nombre de minérales vendues est de: " + items[6].Quantity +
                "\nLe nombre de cafés/thés vendu est de: " + items[7].Quantity, "Total chiffre d'affaire", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
