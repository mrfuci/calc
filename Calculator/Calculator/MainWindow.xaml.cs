﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double firstNumber;
        private double secondNumber;
        private Operator currentOperator;
        public MainWindow()
        {
            InitializeComponent();
        }

        public enum Operator
        {
            Add,
            Subtract,
            Multiply,
            Divide,
        }
        private void stisk(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;

            if (label.Text != "0")
            {
                label.Text = $"{label.Text}{btn.Content}";
            }
            else
            {
                label.Text = btn.Content.ToString();
            }
        }
        
        private void tlacitko_percent(object sender, RoutedEventArgs e)
        {
            secondNumber = double.Parse(label.Text);
            label.Text = GetResult(firstNumber, currentOperator, secondNumber);
        }
        
        
        private string GetResult(double firstNumber, Operator currentOperator, double secondNumber)
        {
            if (currentOperator == Operator.Add)
            {
                return (firstNumber + secondNumber).ToString();
            }
            else if (currentOperator == Operator.Subtract)
            {
                return (firstNumber - secondNumber).ToString();
            }
            else if (currentOperator == Operator.Multiply)
            {
                return (firstNumber * secondNumber).ToString();
            }
            else if (currentOperator == Operator.Divide)
            {
                return (firstNumber / secondNumber).ToString();
            }
            else return "0";
        }            

        private void tlacitko_CE_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            currentOperator = 0;
            label.Text = firstNumber + "0";
        }
        private void tlacitko_rovnase_Click(object sender, RoutedEventArgs e)
        {
            secondNumber = double.Parse(label.Text);
            label.Text = GetResult(firstNumber,currentOperator, secondNumber);
        }

        private void tlacitko_plus_Click(object sender, RoutedEventArgs e)
        {
            currentOperator = Operator.Add;
            firstNumber = double.Parse(label.Text);
            label.Text = firstNumber + "+";
        }

        private void tlacitko_minus_Click(object sender, RoutedEventArgs e)
        {
            currentOperator = Operator.Subtract;
            firstNumber = double.Parse(label.Text);
            label.Text = firstNumber + "-";
        }

        private void tlacitko_krat_Click(object sender, RoutedEventArgs e)
        {
            currentOperator = Operator.Multiply;
            firstNumber = double.Parse(label.Text);
            label.Text=firstNumber + "*";
        }
        private void tlacitko_prehozeni_plus_minus_Click(object sender, RoutedEventArgs e)
        {
            label.Text = (double.Parse(label.Text) * -1).ToString();
        }

        private void tlacitko_C_Click(object sender, RoutedEventArgs e)
        {
            label.Text = firstNumber + "";
        }
        private void tlacitko_carka_Click(object sender, RoutedEventArgs e)
        {
            if (label.Text.IndexOf(".") < 0 ) 
            {
            label.Text += ".";
            }
        }
        private void tlacitko_deleno_Click(object sender, RoutedEventArgs e)
        {
            currentOperator = Operator.Divide;
            firstNumber= double.Parse(label.Text);
            label.Text=firstNumber + "/";
        }

        private void tlacitko_backspace_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tlacitko_lomenoX_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tlacitko_nadruhou_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void tlacitko_odmocnina_Click(object sender, RoutedEventArgs e)
        {

        }
        private void tlacitko_0_Click(object sender, RoutedEventArgs e)
        {
            label.Text += "0" ;
        }
        private void tlacitko_1_Click(object sender, RoutedEventArgs e)
        {
            label.Text += "1";
        }
        private void tlacitko_2_Click(object sender, RoutedEventArgs e)
        {
            label.Text += "2" ;
        }
        private void tlacitko_3_Click(object sender, RoutedEventArgs e)
        {
            label.Text += "3";
        }
        private void tlacitko_4_Click(object sender, RoutedEventArgs e)
        {
            label.Text += "4";
        }
        private void tlacitko_5_Click(object sender, RoutedEventArgs e)
        {
            label.Text += "5";
        }
        private void tlacitko_6_Click(object sender, RoutedEventArgs e)
        {
            label.Text += "6";
        }
        private void tlacitko_7_Click(object sender, RoutedEventArgs e)
        {
            label.Text += "7";
        }
        private void tlacitko_8_Click(object sender, RoutedEventArgs e)
        {
            label.Text += "8";
        }
        private void tlacitko_9_Click(object sender, RoutedEventArgs e)
        {
            label.Text += "9";
        }
    }
}
