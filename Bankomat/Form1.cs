using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bankomat
{
    public partial class Form1 : Form
    {
        BankDB DB = new BankDB();
        MoneyBox MB = new MoneyBox();

        Card activeCard;
       
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DB.cards.Add(new Card("1001", 123, "Ivanov1", 1000, false));
            //DB.cards.Add(new Card("1002", 123, "Ivanov2", 500, true));
            //DB.cards.Add(new Card("1003", 123, "Ivanov3", 100, false));
            //DB.SaveCard();

            MB.addMoney(mbType.mbt100, 4);
            MB.addMoney(mbType.mbt200, 3);
            MB.addMoney(mbType.mbt500, 2);

            MB.getMoney(800);

            MB.LoadValueMas();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Загружать все из файлов. 
            MB.LoadValueMas();
            DB.LoadCard();

        }

        private void button2_Click(object sender, EventArgs e) 
        {
            

            activeCard = DB.cards.Where(c => c.Number == edCardNumber.Text).FirstOrDefault();

            if (activeCard == null)
            {
                MessageBox.Show("Карта не найдена");
            }
            else
            {
                if  (activeCard.Block)
                {
                    MessageBox.Show("Ваша карта заблокирована");
                }
                else
                {
                    tbDisplay.SelectedIndex = 1;
                }
              

            }


            



            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblBalance.Text = activeCard.Money.ToString() + "рублей";
          

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {

            if (activeCard.Pincode.ToString() == edtextPincode.Text)
            {
                tbDisplay.SelectedIndex = 2;
            }
            else
            {
                activeCard.PincodeError++;
                if (activeCard.PincodeError >= 3)
                {
                    activeCard.Block = true;
                    MessageBox.Show("Ваша карта заблокирована");
                    tbDisplay.SelectedIndex = 0;
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbDisplay.SelectedIndex = 1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int money = int.Parse(edtextbox1.Text);

            if (activeCard.Money >= money)
            {
                if (MB.getMoney(money))
                {
                    activeCard.Money = activeCard.Money - money;
                    lblBalance.Text = activeCard.Money.ToString() + " руб.";
                    tbDisplay.SelectedIndex = 3;
                    label3.Text = activeCard.Money.ToString() + " руб.";
                    //activeCard.Money - int.Parse(edtextbox1.Text) == 
                }
                else
                {
                    lblBalance.Text = "Нет нужных купюр...";
                }
                
               

            }

            else
            {
                MessageBox.Show("На карте недостаточно средств");           
            }



        }

        private void edtextPincode_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
         
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.SaveCard();
            MB.Save();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            tbDisplay.SelectedIndex = 2;
        }

        

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

