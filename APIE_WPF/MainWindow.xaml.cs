using System;
using System.Collections.Generic;
using System.Data;
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
using APIE_WPF.aniclasses;
using APIE_WPF.csvclasses;

namespace APIE_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const string FILE_PATH = @"C:\Users\User\Desktop\TAFE 2024\ClusterUnits\ICTPRG439_ICTPRG439_ICTPRG441_ICTPRG433_C#_OOP_OOD\Old\Wednesdays-Programming\OOP_Workshops\Week 13-14\APIE_WPF\APIE_WPF\APIE_WPF\zoo-data.csv";
        public List<CsvMapAnimals> importedRecords = new();
        public IDictionary<int, Animal> animalList = new Dictionary<int, Animal>();
        public MainWindow()
        {
            InitializeComponent();
            fillingDataGrid();
        }

        private void animalCsvDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var data = animalCsvDataGrid.DataContext as List<CsvMapAnimals>;

            int cellId = animalCsvDataGrid.SelectedIndex;
            //MessageBox.Show(cellData.ToString());
            //MessageBox.Show(data[cellId].name);

            idUpdate.Text = data[cellId].id.ToString();
            updateName.Text = data[cellId].name;
            updateGender.Text = data[cellId].gender;
            updateType.Text = data[cellId].animalType;
            updateAge.Text = data[cellId].age.ToString();

            var imgId = data[cellId].id - 1;
            string imgPath = "C:/Users/User/Desktop/TAFE 2024/ClusterUnits/ICTPRG439_ICTPRG439_ICTPRG441_ICTPRG433_C#_OOP_OOD/Old/Wednesdays-Programming/OOP_Workshops/Week 13-14/APIE_WPF/APIE_WPF/APIE_WPF/img/" + imgId + ".jpg";

            updateImg.Source = new BitmapImage(
                        new Uri(imgPath, UriKind.Absolute));
        }

        void fillingDataGrid()
        {
            importedRecords = CsvImporter.ImportSomeRecords(FILE_PATH).ToList();

            animalCsvDataGrid.DataContext = importedRecords;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var data = animalCsvDataGrid.DataContext as List<CsvMapAnimals>;

            int cellId = animalCsvDataGrid.SelectedIndex;

            Random rnd = new Random();
            int pickNum = rnd.Next(0, 6);
            //MessageBox.Show(pickNum.ToString());

            //MessageBox.Show(data[pickNum].id.ToString());
            //MessageBox.Show(data[pickNum].name);
            //MessageBox.Show(data[pickNum].gender);
            //MessageBox.Show(data[pickNum].animalType);
            //MessageBox.Show(data[pickNum].age.ToString());
            
            //UPDATE TXT
            idUpdate.Text = data[pickNum].id.ToString();
            updateName.Text = data[pickNum].name;
            updateGender.Text = data[pickNum].gender;
            updateType.Text = data[pickNum].animalType;
            updateAge.Text = data[pickNum].age.ToString();

            var imgId = pickNum;
            string imgPath = "C:/Users/User/Desktop/TAFE 2024/ClusterUnits/ICTPRG439_ICTPRG439_ICTPRG441_ICTPRG433_C#_OOP_OOD/Old/Wednesdays-Programming/OOP_Workshops/Week 13-14/APIE_WPF/APIE_WPF/APIE_WPF/img/" + imgId + ".jpg";

            updateImg.Source = new BitmapImage(
                        new Uri(imgPath, UriKind.Absolute));

            //Randome Object Selection -> created
            var selection = data[pickNum].animalType;

            switch (selection)
            {
                case "Dog":
                    var newDog = new Dog(data[pickNum].name, data[pickNum].age, "brown", true);
                    try
                    {
                        animalList.Add(pickNum,newDog);
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("An element with Key = \"txt\" already exists.");
                    }
                    break;
                case "Cat":
                    var newCat = new Cat(); //Missing Constructor
                    try
                    {
                        animalList.Add(pickNum, newCat);
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("An element with Key = \"txt\" already exists.");
                    }
                    break;
                case "Fish":
                    var newFish = new Fish(data[pickNum].name, data[pickNum].age, "black", false);
                    try
                    {
                        animalList.Add(pickNum, newFish);
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("An element with Key = \"txt\" already exists.");
                    }
                    break;
                case "Pig":
                    var newPig = new Pig(data[pickNum].name, data[pickNum].age, "brown", false);
                    try
                    {
                        animalList.Add(pickNum, newPig);
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("An element with Key = \"txt\" already exists.");
                    }
                    break;
                default:
                    MessageBox.Show("No object framework here yet");
                    break;

            }

            //animalList.Add();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var sb = new StringBuilder();
            foreach(KeyValuePair<int, Animal> animal in animalList)
            {
                sb.Append("Key: " + animal.Key.ToString());
                sb.AppendLine("Name: " + animal.Value.animalName);
            }

            MessageBox.Show(sb.ToString());
        }
    }
}
