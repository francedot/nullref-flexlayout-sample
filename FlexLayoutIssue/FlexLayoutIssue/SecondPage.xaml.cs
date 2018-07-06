using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FlexLayoutIssue
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();

            Device.StartTimer(TimeSpan.FromMilliseconds(250), () =>
            {
                FirstGrid.IsVisible = !FirstGrid.IsVisible;
                return true;
            });
            Device.StartTimer(TimeSpan.FromMilliseconds(300), () =>
            {
                SecondGrid.IsVisible = !SecondGrid.IsVisible;
                return true;
            });
            Device.StartTimer(TimeSpan.FromMilliseconds(350), () =>
            {
                ThirdGrid.IsVisible = !ThirdGrid.IsVisible;
                return true;
            });
        }
    }
}
