using AxenvioButtons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainWindow : Form
    {
        Double result = 0;
        string operation = string.Empty;
        string fstNum, secNum;
        bool enterValue = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void BtnMathOperation_Click(object sender, EventArgs e)
        {
            if (result != 0) BtnEquals.PerformClick();
            else result = Double.Parse(TxtDisplay2.Text);

            AxenvioButton button = (AxenvioButton)sender;
            operation = button.Text;
            enterValue = true;
            if (TxtDisplay2.Text != "0")
            {
                TxtDisplay1.Text = fstNum = $"{result} {operation}";
                TxtDisplay2.Text = string.Empty;
            }
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            secNum = TxtDisplay2.Text;
            TxtDisplay1.Text = $"{TxtDisplay1.Text} {TxtDisplay2.Text} = ";
            if (TxtDisplay2.Text != string.Empty)
            {
                if (TxtDisplay2.Text == "0") TxtDisplay1.Text = string.Empty;
                switch (operation)
                {
                    case "＋":
                        TxtDisplay2.Text = (result + Double.Parse(TxtDisplay2.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{fstNum} {secNum} = {TxtDisplay2.Text}\n");
                        break;
                    case "－":
                        TxtDisplay2.Text = (result - Double.Parse(TxtDisplay2.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{fstNum} {secNum} = {TxtDisplay2.Text}\n");
                        break;
                    case "✕":
                        TxtDisplay2.Text = (result * Double.Parse(TxtDisplay2.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{fstNum} {secNum} = {TxtDisplay2.Text}\n");
                        break;
                    case "÷":
                        TxtDisplay2.Text = (result / Double.Parse(TxtDisplay2.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{fstNum} {secNum} = {TxtDisplay2.Text}\n");
                        break;
                    default:
                        TxtDisplay1.Text = string.Empty;
                        TxtDisplay1.Text = $"{TxtDisplay2.Text} = ";
                        break;
                }
                result = Double.Parse(TxtDisplay2.Text);
                operation = string.Empty;
            }
        }



        private void BtnRecent_Click(object sender, EventArgs e)
        {
            HistoryPanel.Height = (HistoryPanel.Height == 5) ? HistoryPanel.Height = 320 : 5;
        }

        private void BtnClearHistory_Click(object sender, EventArgs e)
        {
            RtBoxDisplayHistory.Clear();
        }

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            if (TxtDisplay2.Text.Length > 0)
                TxtDisplay2.Text = TxtDisplay2.Text.Remove(TxtDisplay2.Text.Length - 1, 1);
            if (TxtDisplay2.Text == string.Empty)
                TxtDisplay2.Text = "0";
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            TxtDisplay1.Text = string.Empty;
            TxtDisplay2.Text = "0";
            result = 0;
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            TxtDisplay2.Text = "0";
        }

        private void BtnOperations_Click(object sender, EventArgs e)
        {
            AxenvioButton button = (AxenvioButton)sender;
            operation = button.Text;
            switch (operation)
            {
                case "√ₓ":
                    TxtDisplay1.Text = $"√({TxtDisplay2.Text})";
                    TxtDisplay2.Text = Convert.ToString(Math.Sqrt(Double.Parse(TxtDisplay2.Text)));
                    break;
                case "x²":
                    TxtDisplay1.Text = $"({TxtDisplay2.Text})²";
                    TxtDisplay2.Text = Convert.ToString(Convert.ToDouble(TxtDisplay2.Text) * Convert.ToDouble(TxtDisplay2.Text));
                    break;
                case "⅟ₓ":
                    TxtDisplay1.Text = $"1/({TxtDisplay2.Text})";
                    TxtDisplay2.Text = Convert.ToString(1.0 / Convert.ToDouble(TxtDisplay2.Text));
                    break;
                case "％":
                    TxtDisplay1.Text = $"％({TxtDisplay2.Text})";
                    TxtDisplay2.Text = Convert.ToString(Convert.ToDouble(TxtDisplay2.Text) / Convert.ToDouble(100));
                    break;
                case "±":
                    TxtDisplay1.Text = $"±({TxtDisplay2.Text})";
                    TxtDisplay2.Text = Convert.ToString(-1 * Convert.ToDouble(TxtDisplay2.Text));
                    break;
                default:
                    break;
            }
            RtBoxDisplayHistory.AppendText($"{TxtDisplay1.Text} = {TxtDisplay2.Text} \n");
        }

        private void BtnMinimazeWin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //private void BtnFullScreen_Click(object sender, EventArgs e)
        //{
        //    WindowState = FormWindowState.Maximized;
        //}

        private void BtnNum_Click(object sender, EventArgs e)
        {
            if (TxtDisplay2.Text == "0" || enterValue) TxtDisplay2.Text = string.Empty;

            enterValue = false;

            AxenvioButton button = (AxenvioButton)sender;
            if (button.Text == ".")
            {
                if (!TxtDisplay2.Text.Contains("."))
                    TxtDisplay2.Text = TxtDisplay2.Text + button.Text;
            }
            else TxtDisplay2.Text = TxtDisplay2.Text + button.Text;

        }
    }
}
