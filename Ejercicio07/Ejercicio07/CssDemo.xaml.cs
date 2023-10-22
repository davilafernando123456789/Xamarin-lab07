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
        new Song { Title = "Remember", Artist = "Taylor Swift" },
        new Song { Title = "Bohemian Rhapsody", Artist = "Queen" },
        new Song { Title = "Billie Jean", Artist = "Michael Jackson" },
        new Song { Title = "Hotel California", Artist = "Eagles" },
        new Song { Title = "Imagine", Artist = "John Lennon" },
        new Song { Title = "Uptown Funk", Artist = "Mark Ronson ft. Bruno Mars" },
        new Song { Title = "Thriller", Artist = "Michael Jackson" },
        new Song { Title = "Despacito", Artist = "Luis Fonsi ft. Daddy Yankee" },
        new Song { Title = "Sweet Child o' Mine", Artist = "Guns N' Roses" },
        new Song { Title = "Yesterday", Artist = "The Beatles" },
        new Song { Title = "Stairway to Heaven", Artist = "Led Zeppelin" },
        new Song { Title = "Wonderwall", Artist = "Oasis" }

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