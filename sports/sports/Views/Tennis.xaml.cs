using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace sports.Views
{
    public partial class Tennis : ContentPage
    {
        public Tennis()
        {
            InitializeComponent();
        }
        int homecount = 0;
        int awaycount = 0;
        string hometruecount = "Love";
        string awaytruecount = "Love";
        int homesetcount = 0;
        int awaysetcount = 0;
        int homesetsetcount = 0;
        int awaysetsetcount = 0;
        
        void trueCount()
        {
            if (homecount <= -1)
            {
                homecount = 0;
                if (homecount == 0)
                {
                    hometruecount = "Love";
                }
            }
            if (homecount == 0)
            {
                hometruecount = "Love";
            }
            if (homecount == 1)
            {
                hometruecount = "15";
                LabelAwayMatch.Text = $"{awaysetcount}";
                LabelHomeMatch.Text = $"{homesetcount}";
                LabelAwayFinal.Text = $"{awaysetsetcount}";
                LabelHomeFinal.Text = $"{homesetsetcount}";
                LabelAway.Text = $"{awaytruecount}";
            }
            if (homecount == 2)
            {
                hometruecount = "30";
            }
            if (homecount == 3 && awaycount != 3)
            {
                hometruecount = "40";
            }
            if (homecount == 3 && awaycount == 3)
            {
                hometruecount = "Deuce";
                awaytruecount = "Deuce";
                LabelAway.Text = $"{awaytruecount}";
            }
            if ((homecount == 4 && awaycount <= 2) || (homecount == 5 && awaycount <= 3))
            {
                hometruecount = "Game (Game + 1, Reset to Love)";
                homesetcount++;
                homecount = 0;
                awaycount = 0;
                LabelAway.Text = "Love";
                LabelHomeMatch.Text = $"{homesetcount}";
                LabelAwayMatch.Text = $"{awaysetcount}";

            }
            if (homecount == 4 && awaycount == 3)
            {
                hometruecount = "Advantage";
                

            }
            if (homecount == 4 && awaycount == 4)
            {
                homecount = 3;
                awaycount = 3;
                LabelHome.Text = "Deuce";
                LabelAway.Text = "Deuce";
                if (homecount == 3 && awaycount == 3)
                {
                    hometruecount = "Deuce";
                    awaytruecount = "Deuce";
                    LabelAway.Text = $"{awaytruecount}";
                    LabelHome.Text = $"{hometruecount}";
                }

            }
            if (homesetcount >= 6 && homesetcount >= (awaysetcount + 2))
            {
                LabelHomeMatch.Text = "Game and Set!";
                homesetcount = 0;
                awaysetcount = 0;
                homesetsetcount++;
                LabelAwayFinal.Text = $"{awaysetsetcount}";
                LabelHomeFinal.Text = $"{homesetsetcount}";
            }
            if (homesetsetcount >= 3)
            {
                LabelHomeFinal.Text = "Game, Set and Match!";
                homecount = 0;
                awaycount = 0;
                homesetcount = 0;
                awaysetcount = 0;
                homesetsetcount = 0;
                awaysetsetcount = 0;
                LabelAway.Text = $"{awaytruecount}";
                LabelHome.Text = $"{hometruecount}";
                LabelHomeMatch.Text = $"{homesetcount}";
                LabelAwayMatch.Text = $"{awaysetcount}";
                
            }
        }
        void trueAwayCount()
        {
            if (awaycount <= -1)
            {
                awaycount = 0;
                if (awaycount == 0)
                {
                    awaytruecount = "Love";
                }
            }
            if (awaycount == 0)
            {
                awaytruecount = "Love";
            }
            if (awaycount == 1)
            {
                awaytruecount = "15";
                LabelAwayMatch.Text = $"{awaysetcount}";
                LabelHomeMatch.Text = $"{homesetcount}";
                LabelAwayFinal.Text = $"{awaysetsetcount}";
                LabelHomeFinal.Text = $"{homesetsetcount}";
                LabelHome.Text = $"{hometruecount}";
            }
            if (awaycount == 2)
            {
                awaytruecount = "30";
            }
            if (awaycount == 3 && homecount != 3)
            {
                awaytruecount = "40";
            }
            if (awaycount == 3 && homecount == 3)
            {
                hometruecount = "Deuce";
                awaytruecount = "Deuce";
                LabelHome.Text = $"{hometruecount}";

            }
            if ((awaycount == 4 && homecount <= 2) || (awaycount == 5 && homecount <= 3))
            {
                awaytruecount = "Game (Game +1, Reset to Love)";
                awaysetcount++;
                awaycount = 0;
                homecount = 0;
                LabelHome.Text = "Love";
                LabelHomeMatch.Text = $"{homesetcount}";
                LabelAwayMatch.Text = $"{awaysetcount}";


            }
            if (awaycount == 4 && homecount == 3)
            {
                awaytruecount = "Advantage";
                

            }
            if (homecount == 4 && awaycount == 4)
            {
                homecount = 3;
                awaycount = 3;
                if (awaycount == 3 && homecount == 3)
                {
                    hometruecount = "Deuce";
                    awaytruecount = "Deuce";
                    LabelHome.Text = $"{hometruecount}";
                    LabelAway.Text = $"{awaytruecount}";
                }
                

            }
            if (awaysetcount >= 6 && awaysetcount >= (homesetcount + 2))
            {
                LabelAwayMatch.Text = "Game and Set!";
                homesetcount = 0;
                awaysetcount = 0;
                awaysetsetcount++;
                LabelAwayFinal.Text = $"{awaysetsetcount}";
                LabelHomeFinal.Text = $"{homesetsetcount}";
            }
            if (awaysetsetcount >= 3)
            {
                LabelAwayFinal.Text = "Game, Set and Match!";
                homecount = 0;
                awaycount = 0;
                homesetcount = 0;
                awaysetcount = 0;
                homesetsetcount = 0;
                awaysetsetcount = 0;
                LabelAway.Text = $"{awaytruecount}";
                LabelHome.Text = $"{hometruecount}";
                LabelHomeMatch.Text = $"{homesetcount}";
                LabelAwayMatch.Text = $"{awaysetcount}";

            }

        }


void ButtonClickHome_Clicked(Object sender, EventArgs e)
        {
            homecount++;
            trueCount();
            trueAwayCount();
            LabelHome.Text = $"{hometruecount}";
            LabelAway.Text = $"{awaytruecount}";

        }

        void ButtonClickHomeMin_Clicked(Object sender, EventArgs e)
        {
            homecount--;
            trueCount();
            trueAwayCount();
            LabelHome.Text = $"{hometruecount}";
            LabelAway.Text = $"{awaytruecount}";

        }



        void ButtonClickAway_Clicked(System.Object sender, System.EventArgs e)
        {
            awaycount++;
            trueAwayCount();
            trueCount();
            LabelAway.Text = $"{awaytruecount}";
            LabelHome.Text = $"{hometruecount}";


        }
        void ButtonClickAwayMin_Clicked(Object sender, EventArgs e)
        {
            awaycount--;
            trueAwayCount();
            trueCount();
            LabelAway.Text = $"{awaytruecount}";
            LabelHome.Text = $"{hometruecount}";
        }
        void Reset_Clicked(Object sender, EventArgs e)
        {
            homecount = 0;
            awaycount = 0;
            homesetcount = 0;
            awaysetcount = 0;
            homesetsetcount = 0;
            awaysetsetcount = 0;
            trueCount();
            trueAwayCount();
            LabelHome.Text = $"{hometruecount}";
            LabelAway.Text = $"{awaytruecount}";
            LabelHomeMatch.Text = $"{homesetcount}";
            LabelAwayMatch.Text = $"{awaysetcount}";
            LabelAwayFinal.Text = $"{awaysetsetcount}";
            LabelHomeFinal.Text = $"{homesetsetcount}";
        }
    }
}
