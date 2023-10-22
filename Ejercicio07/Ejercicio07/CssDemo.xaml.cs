using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio07
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CssDemo : ContentPage
    {
        public CssDemo()
        {
            InitializeComponent();

            List<Song> songs = new List<Song>
        {
            new Song { Title = "No se va", Artist = "Morat" },
            new Song { Title = "Eres mi nuevo vicio", Artist = "CNCO" },
            new Song { Title = "Shape of you", Artist = "Ed Sheeran" },
            new Song { Title = "Remember", Artist = "Tylor Swift" },
        };

            songListView.ItemsSource = songs;
        }
    }

    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
    }


}