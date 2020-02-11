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
            
        }


        //Dialog Box
        string line6 = "";
        string line5 = "";
        string line4 = "";
        string line3 = "";
        string line2 = "";
        string line1 = "";

        string alllines = "";

        

        //Add next line to Dialog box
        public void dialogAdd(string newText)
        {

            line6 = line5;
            line5 = line4;
            line4 = line3;
            line3 = line2;
            line2 = line1;
            line1 = newText;

            alllines = "6. " + line6 + "\n" + "5. " + line5 + "\n" + "4. " + line4 + "\n" + "3. " + line3 + "\n" + "2. " + line2 + "\n" + "1. " + line1;

            dialogBox.Text = alllines;
        }

        private void MiddleButton_Clicked(object sender, EventArgs e)
        {
            dialogAdd("This is a new Line, Love it all");
        }


        //Movement Keys
        private void MoveUp_Clicked(object sender, EventArgs e)
        {

        }

        private void MoveDown_Clicked(object sender, EventArgs e)
        {

        }

        private void MoveRight_Clicked(object sender, EventArgs e)
        {

        }

        private void MoveLeft_Clicked(object sender, EventArgs e)
        {

        }
    }
}
