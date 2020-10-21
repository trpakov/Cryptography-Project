﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography_Exercises
{
    public partial class CryptoTest : Form
    {
        public CryptoTest()
        {
            InitializeComponent();
        }

        private void AppGUIForm_Load(object sender, EventArgs e)
        {
            textBoxM.Text = new string(CaesarCipher.M);
            textBoxInput.Text = CaesarCipher.TestText;
        }

        private void radioButtonCaesar_CheckedChanged(object sender, EventArgs e)
        {
            textBoxM.Text = new string(CaesarCipher.M);
            if (radioButtonEncrypt.Checked)
                textBoxInput.Text = CaesarCipher.TestText;
            else
                textBoxInput.Text = CaesarCipher.TestCrypto;
            groupBoxKey.Enabled = false;
        }

        private void radioButtonDirectSubs_CheckedChanged(object sender, EventArgs e)
        {
            textBoxM.Text = new string(DirectSubstitution.M);
            if (radioButtonEncrypt.Checked)
                textBoxInput.Text = DirectSubstitution.TestText;
            else
                textBoxInput.Text = DirectSubstitution.TestCrypto;
            groupBoxKey.Enabled = false;
        }

        private void radioButtonPolySub_CheckedChanged(object sender, EventArgs e)
        {
            textBoxM.Text = new string(PolyalphabeticSubstitution.M);
            if (radioButtonEncrypt.Checked)
                textBoxInput.Text = PolyalphabeticSubstitution.TestText;
            else
                textBoxInput.Text = PolyalphabeticSubstitution.TestCrypto;
            groupBoxKey.Enabled = true;
            textBoxKey.Text = PolyalphabeticSubstitution.Key;
        }

        private void radioButtonMatrixSub_CheckedChanged(object sender, EventArgs e)
        {
            textBoxM.Text = new string(MatrixSubstitution.M);
            if (radioButtonEncrypt.Checked)
                textBoxInput.Text = MatrixSubstitution.TestText;
            else
                textBoxInput.Text = MatrixSubstitution.TestCrypto;
            groupBoxKey.Enabled = true;
            textBoxKey.Text = MatrixSubstitution.Key;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var chosenMethod = groupBoxMethods.Controls.OfType<TableLayoutPanel>().Single().Controls.OfType<RadioButton>().Where(x => x.Checked).Single();

            switch (chosenMethod.Name)
            {
                case "radioButtonCaesar":
                    textBoxM.Text = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 .,:/";
                    CaesarCipher.M = textBoxM.Text.ToCharArray();
                    break;
                case "radioButtonDirectSubs":
                    textBoxM.Text = "АБВГДЕИКЛМНОПРСТУФХЯ0123456789NYUD №-Ъ\"S";
                    DirectSubstitution.M = textBoxM.Text.ToCharArray();
                    break;
                case "radioButtonPolySub":
                    textBoxM.Text = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 \"-*";
                    PolyalphabeticSubstitution.M = textBoxM.Text.ToCharArray();
                    break;
                case "radioButtonMatrixSub":
                    textBoxM.Text = "0123456789АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯ -:,";
                    MatrixSubstitution.M = textBoxM.Text.ToCharArray();
                    break;
                default:
                    break;
            }
        }

        private void radioButtonEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxInput.Text = "Явен текст";
            btnAction.Text = "КРИПТИРАЙ";
            textBoxInput.Text = textBoxResult.Text;

            //var chosenMethod = groupBoxMethods.Controls.OfType<TableLayoutPanel>().Single().Controls.OfType<RadioButton>().Where(x => x.Checked).Single();
            //
            //switch (chosenMethod.Name)
            //{
            //    case "radioButtonCaesar":
            //        textBoxInput.Text = CaesarCipher.TestText;
            //        break;
            //    case "radioButtonDirectSubs":
            //        textBoxInput.Text = DirectSubstitution.TestText;
            //        break;
            //    case "radioButtonPolySub":
            //        textBoxInput.Text = PolyalphabeticSubstitution.TestText;
            //        break;
            //    case "radioButtonMatrixSub":
            //        textBoxInput.Text = MatrixSubstitution.TestText;
            //        break;
            //    default:
            //        break;
            //}
        }

        private void radioButtonDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxInput.Text = "Криптограма";
            btnAction.Text = "ДЕКРИПТИРАЙ";
            textBoxInput.Text = textBoxResult.Text;

            //var chosenMethod = groupBoxMethods.Controls.OfType<TableLayoutPanel>().Single().Controls.OfType<RadioButton>().Where(x => x.Checked).Single();
            //
            //switch (chosenMethod.Name)
            //{
            //    case "radioButtonCaesar":
            //        textBoxInput.Text = CaesarCipher.TestCrypto;
            //        break;
            //    case "radioButtonDirectSubs":
            //        textBoxInput.Text = DirectSubstitution.TestCrypto;
            //        break;
            //    case "radioButtonPolySub":
            //        textBoxInput.Text = PolyalphabeticSubstitution.TestCrypto;
            //        break;
            //    case "radioButtonMatrixSub":
            //        textBoxInput.Text = MatrixSubstitution.TestCrypto;
            //        break;
            //    default:
            //        break;
            //}

        }

        private void textBoxM_Leave(object sender, EventArgs e)
        {
            if(textBoxM.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете валидно множество от допустими стойности преди да започнете процеса на криптиране/декриптиране.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxM.Focus();
                return;
            }

            var chosenMethod = groupBoxMethods.Controls.OfType<TableLayoutPanel>().Single().Controls.OfType<RadioButton>().Where(x => x.Checked).Single();

            switch (chosenMethod.Name)
            {
                case "radioButtonCaesar":
                    CaesarCipher.M = textBoxM.Text.ToCharArray();
                    break;
                case "radioButtonDirectSubs":
                    DirectSubstitution.M = textBoxM.Text.ToCharArray();
                    break;
                case "radioButtonPolySub":
                    PolyalphabeticSubstitution.M = textBoxM.Text.ToCharArray();
                    break;
                case "radioButtonMatrixSub":
                    MatrixSubstitution.M = textBoxM.Text.ToCharArray();
                    break;
                default:
                    break;
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxInput.Text == string.Empty)
                {
                    MessageBox.Show("Моля въведете валидно множество от допустими стойности преди да започнете процеса на криптиране/декриптиране.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var chosenMethod = groupBoxMethods.Controls.OfType<TableLayoutPanel>().Single().Controls.OfType<RadioButton>().Where(x => x.Checked).Single();

                if (radioButtonEncrypt.Checked)
                {
                    switch (chosenMethod.Name)
                    {
                        case "radioButtonCaesar":
                            if (textBoxM.Text.ToCharArray() != CaesarCipher.M)
                                CaesarCipher.M = textBoxM.Text.ToCharArray();
                            textBoxResult.Text = CaesarCipher.Encrypt(textBoxInput.Text);
                            break;
                        case "radioButtonDirectSubs":
                            textBoxResult.Text = DirectSubstitution.Encrypt(textBoxInput.Text).Item2;

                            break;
                        case "radioButtonPolySub":
                            textBoxResult.Text = PolyalphabeticSubstitution.Encrypt(textBoxInput.Text);

                            break;
                        case "radioButtonMatrixSub":
                            textBoxResult.Text = MatrixSubstitution.Encrypt(textBoxInput.Text);

                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (chosenMethod.Name)
                    {
                        case "radioButtonCaesar":
                            if (textBoxM.Text.ToCharArray() != CaesarCipher.M)
                                CaesarCipher.M = textBoxM.Text.ToCharArray();
                            textBoxResult.Text = CaesarCipher.Decrypt(textBoxInput.Text);
                            break;
                        case "radioButtonDirectSubs":
                            textBoxResult.Text = DirectSubstitution.Decrypt(textBoxInput.Text);

                            break;
                        case "radioButtonPolySub":
                            textBoxResult.Text = PolyalphabeticSubstitution.Decrypt(textBoxInput.Text);

                            break;
                        case "radioButtonMatrixSub":
                            textBoxResult.Text = MatrixSubstitution.Decrypt(textBoxInput.Text);

                            break;
                        default:
                            break;
                    }

                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxKey_Leave(object sender, EventArgs e)
        {
            var chosenMethod = groupBoxMethods.Controls.OfType<TableLayoutPanel>().Single().Controls.OfType<RadioButton>().Where(x => x.Checked).Single();

            try
            {
                switch (chosenMethod.Name)
                {
                    case "radioButtonPolySub":
                        if (textBoxKey.Text != PolyalphabeticSubstitution.Key)
                            PolyalphabeticSubstitution.Key = textBoxKey.Text;

                        break;
                    case "radioButtonMatrixSub":
                        if (textBoxKey.Text != MatrixSubstitution.Key)
                            MatrixSubstitution.Key = textBoxKey.Text;

                        break;
                    default:
                        break;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRandomKey_Click(object sender, EventArgs e)
        {
            var chosenMethod = groupBoxMethods.Controls.OfType<TableLayoutPanel>().Single().Controls.OfType<RadioButton>().Where(x => x.Checked).Single();

            try
            {

                switch (chosenMethod.Name)
                {
                    case "radioButtonPolySub":
                        textBoxKey.Text = PolyalphabeticSubstitution.GenerateKey();
                        PolyalphabeticSubstitution.Key = textBoxKey.Text;
                        break;
                    case "radioButtonMatrixSub":
                        textBoxKey.Text = MatrixSubstitution.GenerateKey();
                        MatrixSubstitution.Key = textBoxKey.Text;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    
    }
}
