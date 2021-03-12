﻿using System;
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

namespace _06_Styles_metanit
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
            public MainWindow()
            {
                InitializeComponent();

                //Создаю стиль кодоом для первых 2ух кнопок
                Style buttonStyle = new Style();
                buttonStyle.Setters.Add(new Setter { Property = Control.FontFamilyProperty, Value = new FontFamily("Verdana") });
                buttonStyle.Setters.Add(new Setter { Property = Control.MarginProperty, Value = new Thickness(10) });
                buttonStyle.Setters.Add(new Setter { Property = Control.BackgroundProperty, Value = new SolidColorBrush(Colors.Black) });
                buttonStyle.Setters.Add(new Setter { Property = Control.ForegroundProperty, Value = new SolidColorBrush(Colors.White) });
                //добавляю событие Button_Click
                buttonStyle.Setters.Add(new EventSetter { Event = Button.ClickEvent, Handler = new RoutedEventHandler(Button_Click2) });
                //Применение стиля к кнопке
                button1.Style = buttonStyle;
                button2.Style = buttonStyle;
            }

            //Обработчик EventStyle
            private void Button_Click(object sender, RoutedEventArgs e)
            {
                Button clickedButton = (Button)sender;
                MessageBox.Show(clickedButton.Content.ToString());
            }

            private void Button_Click2(object sender, RoutedEventArgs e)
            {
                Button clickedButton = (Button)sender;//Беру объект
                Style buttonStyle = new Style();//Создаю стиль

                buttonStyle.Setters.Add(new Setter { Property = Control.FontFamilyProperty, Value = new FontFamily("Times New Roman") });//добавляю в стиль свойства
                buttonStyle.Setters.Add(new Setter { Property = Control.ForegroundProperty, Value = new SolidColorBrush(Colors.Violet) });
                buttonStyle.Setters.Add(new Setter { Property = Control.BackgroundProperty, Value = new SolidColorBrush(Colors.Yellow) });
                clickedButton.Style = buttonStyle;//Применяю стиль к обекту
            }


    }
    
}