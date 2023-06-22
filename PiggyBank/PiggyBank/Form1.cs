using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiggyBank
{
    public partial class Form1 : Form
    {
        private decimal balance;

        public Form1()
        {
            InitializeComponent();
            balance = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void cekButon_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(amountTextBox.Text, out decimal amount) && amount > 0)
            {
                if (balance >= amount)
                {
                    balance -= amount;
                    balanceLabel.Text = $"Toplam: {balance:C}";
                    amountTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Bakiye yetersiz.", "Insufficient Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen tutar bilgisi giriniz.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ekleButon_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(amountTextBox.Text, out decimal amount) && amount > 0)
            {
                balance += amount;
                balanceLabel.Text = $"Toplam: {balance:C}";
                amountTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen tutar bilgisi giriniz.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void shakeButton_Click(object sender, EventArgs e)
        {
            if (balance > 0)
            {
                decimal totalCoins = Math.Floor(balance);
                decimal remainingBalance = balance - totalCoins;
                MessageBox.Show($"Shaking the piggy bank... {totalCoins} TL geldi!", "Shake Piggy Bank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                balance = remainingBalance;
                balanceLabel.Text = $"Balance: {balance:C}";
            }
            else
            {
                MessageBox.Show("Kumbarada henüz para yok :((", "Empty Piggy Bank", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void balanceLabel_Click(object sender, EventArgs e)
        {

        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
