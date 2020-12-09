using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
//  1. Sukurti programą kurioje naudotojas galės įvesti skaičius
//     į vieną textbox elementą ir nuspausti mygtuką „skaičiuoti“.
//
//    a: nuspaudus mygtuką skaičius turi būti nuskaitomas ir 
//       supildomas į globalų [10-ties]
//       indeksų masyvą.
//
//    b: jei masyve visi skaičiai supildyti atlikti sumavimo
//       veiksmą.
//
//    c: jei masyve dar nėra 10ties elementų pridėti ką
//       tik įvestą ir parodyti label ar MessageBox elementą
//       vartotojui, kad įvestu papildomus skaičius.
//

//  2. Papildyti pirmąją programą button ir textbox elementu.
//     Programa turės gebėti nupiešti eglutę į richtextbox elementą:
//     kaip pvz. jei vartotojas į laukelį įves skaičių 4 
//     rezultatas kurį turės pateikti programa bus :
//           *
//          * *
//         * * *
//        * * * *
//     Atlikus visas užduotis į moodle užduoties laukelį įkelti
//     tekstinį dokumentą su nuorodą į jūsų projekto git
//     repositoriją.
*/


namespace GitUzduotys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // KINTAMIEJI
        const int n = 10;

        int position = -1;
        double number;

        double[] array = new double[n];
        double sum = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            if (double.TryParse(textBox1.Text, out number))
            {
                // Jeigu įvestis yra skaičius
                position += 1;
                number = double.Parse(textBox1.Text);

                label4.Text = "";
                textBox1.Text = "";

                if (position == n)
                {
                    for (int i = 0; i < n; i++)
                    {
                        sum += array[i];   
                    }
                    position = -1;
                    label4.Text += "Suma -> " + sum.ToString();
                    sum = 0;
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (i == position)
                        {
                            array[i] = number;
                        }
                        
                    }
                    label4.Text = "Įvedėte " + number + " (indeksas: " + position + ")" + " į masyvą, liko įvesti dar " + (n - (position));
                }
                
            }
            else
            {
                // Jeigu įvestis nėra skaičius
                MessageBox.Show("Įvedimas turi būti skaičius!");
                textBox1.Text = "";
            }
        }

        // KINTAMIEJI
        int secondNumber;
        int stars = 1;
        int space;
        private void button2_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox2.Text, out secondNumber))
            {
                // Jeigu įvestis yra sveikas skaičius
                secondNumber = int.Parse(textBox2.Text);
                space = secondNumber;

                richTextBox1.Text = "";
                textBox2.Text = "";

                for (int i = 0; i < secondNumber; i++)
                {
                    for (int j = 0; j < space; j++)
                    {
                        richTextBox1.Text += " ";
                    }
                    for (int j = 0; j < stars; j++)
                    {
                        richTextBox1.Text += "* ";
                    }
                    richTextBox1.Text += "\n";
                    stars++;
                    space--;
                }
                stars = 1;
            }
            else
            {
                // Jeigu įvestis nėra sveikas skaičius
                MessageBox.Show("Įvedimas turi būti sveikas skaičius!");
                textBox2.Text = "";
            }
        }
    }
 }
