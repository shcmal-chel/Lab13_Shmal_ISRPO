using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Lab_13_Homework
{
    public partial class MainWindow : Window
    {
        private List<string> citates;
        private Random random;
        private bool isFirstClick = true;
        public MainWindow()
        {
            InitializeComponent();
            InitializeCitate();
            random = new Random();
            TextBlock.Text = "Нажми кнопку, чтобы получить дозу брутальности";
        }
        private void InitializeCitate()
        {
            citates = new List<string>
            {
                "Когда Стетхем говорит «Hello World», мир отвечает «Простите, сэр».",
                "Чак Норрис не спит. Он ждёт.",
                "Стетхем может разделить ноль на ноль.",
                "Стетхем не пользуется отладчиком. Он смотрит на код, и баги исправляются сами.",
                "Когда Стетхем бежит марафон, это дистанция убегает от него.",
                "Стетхем может хешировать пароли взглядом.",
                "Однажды Стетхем написал бесконечный цикл. Он закончился.",
                "Стетхем не боится темноты. Темнота боится Стетхема."
            };
        }
        private void buttonNew_Click(object sender, RoutedEventArgs e)
        {
            if (citates.Count > 0)
            {
                int index = random.Next(citates.Count);
                TextBlock.Text = citates[index];
            }
        }
    }
}