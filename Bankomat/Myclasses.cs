using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bankomat
{

    class BankDB
    {
        public List<Card> cards = new List<Card>();
        public void SaveCard()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("cards");
            var en = doc.CreateXmlDeclaration("1.0", "utf-8", "");
            doc.AppendChild(en);
            doc.AppendChild(root);

            foreach (var item in cards)
            {
                XmlElement ev = doc.CreateElement("Card");
                ev.SetAttribute("number", item.Number);
                ev.SetAttribute("pincode", item.Pincode.ToString());
                ev.SetAttribute("block", item.Block.ToString());
                ev.SetAttribute("money", item.Money.ToString());
                ev.SetAttribute("fio", item.FIO);
                ev.SetAttribute("pincodeerror", item.PincodeError.ToString());
                
                root.AppendChild(ev);
            }

            doc.Save("db.xml");



        }

        public void LoadCard()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("db.xml");
            foreach (XmlNode node in doc.DocumentElement)
            {
                string number = node.Attributes.GetNamedItem("number").Value;
                int pincode = Convert.ToInt32(node.Attributes.GetNamedItem("pincode").Value);
                string fio  = node.Attributes.GetNamedItem("fio").Value;
                int money = Convert.ToInt32(node.Attributes.GetNamedItem("money").Value);
                bool block =  Convert.ToBoolean(node.Attributes.GetNamedItem("block").Value);
                int pincodeerror = Convert.ToInt32(node.Attributes.GetNamedItem("pincodeerror").Value);

                cards.Add(new Card(number, pincode, fio, money, block, pincodeerror));
                //cards.Add(new Card("1003", 234, "Petrov", 3000, true));
            }
            
        }


    }
    class Card
    {
        public string Number { get; set; }
        public int Pincode { get; set; }
        public int PincodeError { get; set;}
         public string FIO { get; set; }
        public int  Money { get; set; }
         public bool Block { get; set; }




        public Card (string number, int pincode, string fio, int money, bool block, int pincodeerror)
        {
            this.Number = number;
            this.Pincode = pincode;
            this.FIO = fio;
            this.Money = money;
            this.Block = block;
            this.PincodeError = pincodeerror;

        }





    }

    enum mbType
    {
        mbt100,
        mbt200,
        mbt500,
        mbt1000,
        mbt2000,
        mbt5000
    }
    class MoneyBox : Object
    {
        int[] box = new int[6];
        int[] values = new int[]{100, 200, 500, 1000, 2000, 5000};



        public override string ToString()
        {
            return getBalance().ToString();
        }
        public void addMoney(mbType mtype, int count)
        {
            box[(int)mtype] = box[(int)mtype] + count;

        }

        public int getCountMoney(mbType mtype)
        {
            return box[(int)mtype]; 
        }

        public int getBalance()
        {
            int bal = 0;
            for (int i = 0; i < 5; i++)
            {
                bal = bal + box[i] * values[i];
            }
            return bal;
            
        }

        public bool getMoney(int value)
        {
            int[] cash = new int[] { 0, 0, 0, 0, 0, 0 };

            for (int i = 5; i >= -1 ; i--)
            {
                if (i == -1)
                    return false;

                if (box[i] - cash[i] > 0)
                {
                    if (value - values[i] > 0)
                    {
                        // Нашли банкноту 
                        cash[i] = cash[i] + 1;
                        value = value - values[i];
                        i++;
                        continue;
                    }

                    if (value - values[i] == 0)
                    {
                        // Нашли банкноту последнюю  
                        cash[i] = cash[i] + 1;
                        value = value - values[i];
                        break;
                    }
                }

            }
            // Вычесть кэш из бокса 
            for (int i = 0; i < 6; i++)
            {
                box[i] = box[i] - cash[i];
            }
            return true;
        }
        public void Save()  /*надо сделать массив из начений*/
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("values");
            var en = doc.CreateXmlDeclaration("1.0", "utf-8", "");
            doc.AppendChild(en);
            doc.AppendChild(root);
            XmlElement ev = doc.CreateElement("Value"); 
            ev.SetAttribute("b0", box[0].ToString());
            ev.SetAttribute("b1", box[1].ToString());
            ev.SetAttribute("b2", box[2].ToString());
            ev.SetAttribute("b3", box[3].ToString());
            ev.SetAttribute("b4", box[4].ToString());
            ev.SetAttribute("b5", box[5].ToString());
            

            root.AppendChild(ev);

            doc.Save("Value.xml");
        }
        public void LoadValueMas()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Value.xml");
            XmlElement root = doc.DocumentElement;
            XmlNode values = root.FirstChild;
            box[0] = Convert.ToInt32(values.Attributes.GetNamedItem("b0").Value);
            box[1] = Convert.ToInt32(values.Attributes.GetNamedItem("b1").Value);
            box[2] = Convert.ToInt32(values.Attributes.GetNamedItem("b2").Value);
            box[3] = Convert.ToInt32(values.Attributes.GetNamedItem("b3").Value);
            box[4] = Convert.ToInt32(values.Attributes.GetNamedItem("b4").Value);
            box[5] = Convert.ToInt32(values.Attributes.GetNamedItem("b5").Value);
            
        }

        internal void getBalance(string v)
        {
            throw new NotImplementedException();
        }
    }   

}
