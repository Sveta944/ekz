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

namespace WpfApp2
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
}
namespace WpfTemplate.Model
{
    namespace WpfTemplate.Model
    {
        public class People

        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string year { get; set; }
            public string dolxnost { get; set; }


            
        }
    }
}
}public class LocalDataProvider : IDataProvider
{
    public IEnumerable<People> GetCats()
    {
        return new[People]
        
            new people {Age=1,Breed="Василий", year="45", salary="60000"},
            new People {Age=2,Breed="Евгений",  year="26", salary="60000"},
            new People {Age=3,Breed="Александр",  year="55", salary="60000"}
        };
    }
    
    }
}
