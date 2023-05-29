using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zad4_KirillMalugin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
       

        public Page1()
        {
            InitializeComponent();
            Label myLabelOne = (Label)FindByName("myLabelOne");
            Label myLabelTwo = (Label)FindByName("myLabelTwo");
            Label myLabelThree = (Label)FindByName("myLabelThree");
        }


        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void percentSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double newValue = e.NewValue;
            if (newValue > 50)
            {
            }
        }
    }
}