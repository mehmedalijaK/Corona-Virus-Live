using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Newtonsoft.Json;
using System.Net.Http;
using CoronaLive.Classes;

namespace CoronaLive
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();    
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ListaDrzava.Visibility = Visibility.Hidden;
            ListaDrzava.IsReadOnly = true;

            List<Country> drzave = await GetHtmlASyncAsync();


            try
            {
                if (drzave != null)
                {
                    Country AllCountires = new Country();

                    for (int i = 0; i < drzave.Count; i++) AllCountires = AllCountires + drzave[i];

                    AllCountires.DodatneInformacije.flag = "Slike/Web.png";
                    ListaDrzava.Items.Add(AllCountires);

                    List<Country> SortedList = drzave.OrderBy(o => o.UkupnoZarazenih).ToList();

                    for (int i = drzave.Count - 1; i >= 0; i--) ListaDrzava.Items.Add(SortedList[i]);
                }
            }
            catch
            {
                MessageBox.Show("Program nije uspeo da izvrši upis u data grid!");
            }

            ListaDrzava.Visibility = Visibility.Visible;
            LoadingDataGrid.Visibility = Visibility.Hidden;
        }

        private static async Task<List<Country>> GetHtmlASyncAsync()
        {
            try
            {
                var url = "https://corona.lmao.ninja/v2/countries";
                var httpClient = new HttpClient();
                string html = await httpClient.GetStringAsync(url);

                try
                {
                    List<Country> drzave = JsonConvert.DeserializeObject<List<Country>>(html);
                    return drzave;
                }
                catch
                {
                    MessageBox.Show("Program nije uspeo da izvrši konverziju JSON fajl-a!");
                    List<Country> a = null;
                    return a;
                }

            }
            catch
            {
                MessageBox.Show("Program nije uspeo da se konektuje sa serverom, proverite internet konekciju!");
                List<Country> a = null;
                return a;
            }
        }

        private void ListaDrzava_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
