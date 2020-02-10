using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MazeRunner
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            dialogAdd("Hello World");
        }

        public void dialogAdd(string newText)
        {
            dialogBox.IsReadOnly = false;
            dialogBox.Text = newText;
            dialogBox.IsReadOnly = true;
        }
    }
}
