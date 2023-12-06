using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace gitXamarinApp
{
    public partial class MainPage : ContentPage
    {
        private static int Likes = 0;

        public MainPage()
        {
            InitializeComponent();

            UpdateLikeCounter();
        }
        private void UpdateLikeCounter()
        {
            LikeCounter.Text = Likes + " Likes";
        }

        private void LikeButtonClicked(object sender, EventArgs e)
        {
            Likes++;
            UpdateLikeCounter();
        }

        private void DislikeButtonClicked(object sender, EventArgs e)
        {
            if (Likes > 0)
                Likes--;

            UpdateLikeCounter();
        }
    }
}
