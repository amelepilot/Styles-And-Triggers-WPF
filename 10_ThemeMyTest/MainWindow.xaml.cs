
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

namespace _10_ThemeMyTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<string> styles = new List<string> {    "dict_theme_dark", 
                                                        "dict_theme_forest", 
                                                        "dict_theme_light", 
                                                        "dict_theme_start", 
                                                        "dict_theme_yello",
                                                        "dict_theme_yello_big",
                                                        "dict_theme_crazi_animation" };
            styleBox.SelectionChanged += ThemeChange;
            styleBox.ItemsSource = styles;
            styleBox.SelectedItem = "dict_theme_yello_big";
        }


        /// <summary>
        /// Tеперь применим  стили light и dark.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string style = styleBox.SelectedItem as string;
            var uri = new Uri(style + ".xaml", UriKind.Relative);                           // определяем путь к файлу ресурсов
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;// загружаем словарь ресурсов
            Application.Current.Resources.Clear();                                          // очищаем коллекцию ресурсов приложения
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);              // добавляем загруженный словарь ресурсов
        }
    }
}
