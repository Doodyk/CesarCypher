using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cesar_Cypher_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static string EncodingProcess(int Key, string Message)
        {
            char[] Alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string OutPut = "";
            char[] CharMessage = Message.ToCharArray();
            for (int i = 0; i <= CharMessage.Length - 1; i++)
            {
                for (int y = 0; y <= Alphabet.Length - 1; y++)
                {
                    Console.ReadLine();
                    Console.WriteLine("tst" + y.ToString() + i.ToString());
                    if (CharMessage[i] == Alphabet[y])
                    {
                        if (y + Key >= Alphabet.Length)
                        {
                            OutPut += Alphabet[y + Key - Alphabet.Length];
                        }
                        else
                        {
                            OutPut += Alphabet[y + Key];
                        }
                        Console.WriteLine("Found a missing piece: " + OutPut);
                    }
                }
            }
            return OutPut;
        }

        private static string DecodingProcess(int Key, string Message)
        {
            char[] Alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string OutPut = "";
            char[] CharMessage = Message.ToCharArray();
            for (int i = 0; i <= CharMessage.Length - 1; i++)
            {
                for (int y = 0; y <= Alphabet.Length - 1; y++)
                {
                    Console.ReadLine();
                    Console.WriteLine("tst" + y.ToString() + i.ToString());
                    if (CharMessage[i] == Alphabet[y])
                    {
                        if (y - Key < 0)
                        {
                            OutPut += Alphabet[y - Key + Alphabet.Length];
                        }
                        else
                        {
                            OutPut += Alphabet[y - Key];
                        }
                        Console.WriteLine("Found a missing piece: " + OutPut);
                    }
                }
            }
            return OutPut;
        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            //Run Encode
            if (CypherKeyInput.Text != "" || CypherKeyInput.Text != "Enter Cypher Key")
            {
                if (Int32.Parse(CypherKeyInput.Text) >= 26)
                {
                    MessageBox.Show("The key can not exceed this range 0-25", "Key Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CypherKeyInput.Text = "";
                }
                else
                {
                    OutputBox.Text = EncodingProcess(Int32.Parse(CypherKeyInput.Text.ToLower()), InputBox.Text);
                }
            }
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            //Run Decode
            if (CypherKeyInput.Text != "" || CypherKeyInput.Text != "Enter Cypher Key")
            {
                if (Int32.Parse(CypherKeyInput.Text) >= 26)
                {
                    MessageBox.Show("The key can not exceed this range 0-25", "Key Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CypherKeyInput.Text = "";
                }
                else
                {
                    InputBox.Text = DecodingProcess(Int32.Parse(CypherKeyInput.Text.ToLower()), OutputBox.Text);
                }
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            //Copy To Clipboard
            try
            {
                Clipboard.SetText("Input: " + InputBox.Text + " Key: " + CypherKeyInput.Text + " Output: " + OutputBox.Text);
            }
            catch
            {
                MessageBox.Show("Sorry, The copy function timed out", "Error 0x411000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputBox_TextChanged(object sender, EventArgs e)
        {

        }
        //Cypher Key TextBox Controls 
        private void CypherKeyInput_Enter(object sender, EventArgs e)
        {
            CypherKeyInput.Text = "";
        }
        private void CypherKeyInput_Exit(object sender, EventArgs e)
        {
            if (CypherKeyInput.Text == null || CypherKeyInput.Text == "")
            {
                CypherKeyInput.Text = "Enter Cypher Key";
            }
        }
        private void CypherKeyInput_TextChanged(object sender, EventArgs e)
        {
            if (!CypherKeyInput.Text.All(c => char.IsDigit(c)) && CypherKeyInput.Text != "Enter Cypher Key")
            {
                CypherKeyInput.Text = "";
                MessageBox.Show("The key can only consist of numerical values", "Key Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
