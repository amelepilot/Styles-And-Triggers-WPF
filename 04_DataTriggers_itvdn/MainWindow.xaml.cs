using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; // необходимо длч данной коллекции  ObservableCollection<Country> 
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

namespace _04_DataTriggers_itvdn
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

    }

    public class Countres : ObservableCollection<Country>   //эта коллекция нужна для того, чтоб при добавлении в эту коллекцию элемента из код бихада
    {                                                       //Форма сразу обновлялась, если использовать лист - не получится
        public Countres()
        {

            //this.Add(new Country());
            this.Add(new Country("Окефния", "RU"));
            this.Add(new Country("Евразия", "ЕR"));
            this.Add(new Country("Остазия", "OS"));
            this.Add(new Country("СССР", "SR"));
            this.Add(new Country("СССР", "SR"));
            this.Add(new Country("СССР", "SR"));
        }
    }

    //Тестовый Базовый класс данных
    public class Country
    {
        public string Name { get; set; }
        public string ShortName { get; set; }

        public Country()
        {

        }

        public Country(string name, string shortName)
        {
            Name = name;
            ShortName = shortName;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // return base.ToString();//по умолч
            return Name;
        }

    }
}
