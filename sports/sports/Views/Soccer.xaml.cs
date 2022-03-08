using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace sports.Views
{
    public partial class Soccer : ContentPage
    {
        public Soccer()
        {
            InitializeComponent();
        }
        int homecount = 0;
        int awaycount = 0;



        void ButtonClickHome_Clicked(Object sender, EventArgs e)
        {
            homecount++;
            LabelHome.Text = $"{homecount}";
        }

        void ButtonClickHomeMin_Clicked(Object sender, EventArgs e)
        {
            homecount--;
            if (homecount <= -1)
            {
                homecount = 0;
            }
            LabelHome.Text = $"{homecount}";
        }



        void ButtonClickAway_Clicked(System.Object sender, System.EventArgs e)
        {
            awaycount++;
            LabelAway.Text = $"{awaycount}";
        }
        void ButtonClickAwayMin_Clicked(Object sender, EventArgs e)
        {
           awaycount--;
            if (awaycount <= -1)
            {
                awaycount = 0;
            }
            LabelAway.Text = $"{awaycount}";
        }
        void Reset_Clicked(Object sender, EventArgs e)
        {
            homecount = 0;
            awaycount = 0;
            LabelHome.Text = $"{homecount}";
            LabelAway.Text = $"{awaycount}";
        }
    }
}
