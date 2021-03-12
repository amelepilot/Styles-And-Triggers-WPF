using System;
using System.Collections.Generic;
using System.Linq;
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

namespace _02_EventSetters_itvdn
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        //Обработчики Текстблоков
        ////Сделать такие же, которые будут менять параметры ListBoxa
        private void Element_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock testTextBlock = sender as TextBlock;

            testTextBlock.Background = new SolidColorBrush(Colors.Green);////////////////////////////err
            testTextBlock.Foreground = new SolidColorBrush(Colors.Red);
            testTextBlock.FontSize = 17;
            //((TextBlock)sender).Background = new SolidColorBrush(Colors.Black);
        }

        private void Element_MouseLeave(object sender, MouseEventArgs e)
        {
            ((TextBlock)sender).Background = new SolidColorBrush(Colors.Yellow);
            ((TextBlock)sender).Foreground = new SolidColorBrush(Colors.Black);
            ((TextBlock)sender).FontSize = 15;
        }



        //Обработчики Кнопок
        private void Control_MouseEnter(object sender, MouseEventArgs e)
        {
            Button testButton = sender as Button;
            testButton.Background = new SolidColorBrush(Colors.Yellow);//почемуто не работает..
            testButton.Foreground = new SolidColorBrush(Colors.Red);
            testButton.FontSize = 17;
            testButton.Height = 35;
            testButton.Width = 180;
        }

        private void Control_MouseLeave(object sender, MouseEventArgs e)
        {
            Button testButton = sender as Button;
            testButton.Background = new SolidColorBrush(Colors.DarkOrange);
            testButton.Foreground = new SolidColorBrush(Colors.Black);
            testButton.FontSize = 15;
            testButton.Height = 30;
            testButton.Width = 120;
        }
        private void Control_MouseTest3(object sender, MouseEventArgs e)
        {
            Button testButton = sender as Button;
            testButton.Background = new SolidColorBrush(Colors.DarkOrange);
            testButton.Foreground = new SolidColorBrush(Colors.Black);
            testButton.FontSize = 20;
            testButton.Height = 130;
            testButton.Width = 420;
        }


    }
}
