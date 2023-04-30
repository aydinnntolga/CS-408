using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace CS_408_project.client.client
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private char PlayerChar;
        private char OpponentChar;
        private Socket socket;


        //Checking game in every turn if
        private bool checkState()
        {
            //Horizontals
            if (button1.Text == button2.Text && button2.Text == button3.Text && button3.Text != "")
            {
                if (button1.Text[0] == PlayerChar)
                {

                    label1.Text = "Game over. " + PlayerChar + " wins!";

                }

                else
                {
                    label1.Text = "Game over. " + OpponentChar + " wins!";
                }

                return true;
            }

            else if (button4.Text == button5.Text && button5.Text == button6.Text && button6.Text != "")
            {
                if (button4.Text[0] == PlayerChar)
                {

                    label1.Text = "Game over. " + PlayerChar + " wins!";

                }

                else
                {
                    label1.Text = "Game over. " + OpponentChar + " wins!";
                }

                return true;
            }

            else if (button7.Text == button8.Text && button8.Text == button9.Text && button9.Text != "")
            {
                if (button7.Text[0] == PlayerChar)
                {

                    label1.Text = "Game over. " + PlayerChar + " wins!";

                }

                else
                {
                    label1.Text = "Game over. " + OpponentChar + " wins!";
                }

                return true;
            }

            //Columns
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button7.Text != "")
            {
                if (button1.Text[0] == PlayerChar)
                {

                    label1.Text = "Game over. " + PlayerChar + " wins!";

                }

                else
                {
                    label1.Text = "Game over. " + OpponentChar + " wins!";
                }

                return true;
            }

            else if (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text != "")
            {
                if (button2.Text[0] == PlayerChar)
                {

                    label1.Text = "Game over. " + PlayerChar + " wins!";

                }

                else
                {
                    label1.Text = "Game over. " + OpponentChar + " wins!";
                }

                return true;
            }

            else if (button3.Text == button6.Text && button6.Text == button9.Text && button9.Text != "")
            {
                if (button3.Text[0] == PlayerChar)
                {

                    label1.Text = "Game over. " + PlayerChar + " wins!";

                }

                else
                {
                    label1.Text = "Game over. " + OpponentChar + " wins!";
                }

                return true;
            }

            //Diagonals
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button9.Text != "")
            {
                if (button1.Text[0] == PlayerChar)
                {

                    label1.Text = "Game over. " + PlayerChar + " wins!";

                }

                else
                {
                    label1.Text = "Game over. " + OpponentChar + " wins!";
                }

                return true;
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button7.Text != "")
            {
                if (button3.Text[0] == PlayerChar)
                {

                    label1.Text = "Game over. " + PlayerChar + " wins!";

                }

                else
                {
                    label1.Text = "Game over. " + OpponentChar + " wins!";
                }

                return true;
            }

            else if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                label1.Text = "It's draw!";
                return true;
            }



            return false;
        }

        private void freezeBoard()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void unfreezeBoard()
        {
            if (button1.Text == "")
                button1.Enabled = true;
            if (button2.Text == "")
                button2.Enabled = true;
            if (button3.Text == "")
                button3.Enabled = true;
            if (button4.Text == "")
                button4.Enabled = true;
            if (button5.Text == "")
                button5.Enabled = true;
            if (button6.Text == "")
                button6.Enabled = true;
            if (button7.Text == "")
                button7.Enabled = true;
            if (button8.Text == "")
                button8.Enabled = true;
            if (button9.Text == "")
                button9.Enabled = true;

        }

        private void RecieveMove()
        {
            byte[] buffer = new byte[1];
            socket.Receive(buffer);
            if (buffer[0] == 1)
                button1.Text = OpponentChar.ToString();
            if (buffer[0] == 2)
                button2.Text = OpponentChar.ToString();
            if (buffer[0] == 3)
                button3.Text = OpponentChar.ToString();
            if (buffer[0] == 4)
                button4.Text = OpponentChar.ToString();
            if (buffer[0] == 5)
                button5.Text = OpponentChar.ToString();
            if (buffer[0] == 6)
                button6.Text = OpponentChar.ToString();
            if (buffer[0] == 7)
                button7.Text = OpponentChar.ToString();
            if (buffer[0] == 8)
                button8.Text = OpponentChar.ToString();
            if (buffer[0] == 9)
                button9.Text = OpponentChar.ToString();


        }


    }
}
