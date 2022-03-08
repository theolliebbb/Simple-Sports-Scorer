using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace sports.Views
{
    public partial class FootBall : ContentPage
    {
        public FootBall()
        {
            InitializeComponent();
        }
        int homecount = 0;
        int awaycount = 0;

        void ButtonClickHome1_Clicked(Object sender, EventArgs e)
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

        void ButtonClickHome2_Clicked(Object sender, EventArgs e)
        {
            homecount += 2;
            LabelHome.Text = $"{homecount}";
        }

        void ButtonClickHomeMin2_Clicked(Object sender, EventArgs e)
        {
            homecount -= 2;
            if (homecount <= -1)
            {
                homecount = 0;
            }
            LabelHome.Text = $"{homecount}";
        }
        void ButtonClickHome3_Clicked(Object sender, EventArgs e)
        {
            homecount += 3;
            LabelHome.Text = $"{homecount}";
        }

        void ButtonClickHomeMin3_Clicked(Object sender, EventArgs e)
        {
            homecount -= 3;
            if (homecount <= -1)
            {
                homecount = 0;
            }
            LabelHome.Text = $"{homecount}";
        }

        void ButtonClickHome6_Clicked(Object sender, EventArgs e)
        {
            homecount += 6;
            LabelHome.Text = $"{homecount}";
        }

        void ButtonClickHomeMin6_Clicked(Object sender, EventArgs e)
        {
            homecount -= 6;
            if (homecount <= -1)
            {
                homecount = 0;
            }
            LabelHome.Text = $"{homecount}";
        }


        void ButtonClickAway2_Clicked(System.Object sender, System.EventArgs e)
        {
            awaycount += 2;
            LabelAway.Text = $"{awaycount}";
        }
        void ButtonClickAwayMin2_Clicked(Object sender, EventArgs e)
        {
            awaycount -= 2;
            if (awaycount <= -1)
            {
                awaycount = 0;
            }
            LabelAway.Text = $"{awaycount}";
        }
        void ButtonClickAway3_Clicked(System.Object sender, System.EventArgs e)
        {
            awaycount += 3;
            LabelAway.Text = $"{awaycount}";
        }
        void ButtonClickAwayMin3_Clicked(Object sender, EventArgs e)
        {
            awaycount -= 3;
            if (awaycount <= -1)
            {
                awaycount = 0;
            }
            LabelAway.Text = $"{awaycount}";
        }
        void ButtonClickAway6_Clicked(System.Object sender, System.EventArgs e)
        {
            awaycount += 6;
            LabelAway.Text = $"{awaycount}";
        }
        void ButtonClickAwayMin6_Clicked(Object sender, EventArgs e)
        {
            awaycount -= 6;
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

