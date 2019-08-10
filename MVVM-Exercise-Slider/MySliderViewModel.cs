using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Exercise_Slider
{
    class MySliderViewModel : INotifyPropertyChanged
    {
        public int _sliderValue = 50; //Value from the exercise 


        private Slider slider;
        public int SliderValue
        {
            get { return slider.SliderValue; }

            set
            {
                if (slider.SliderValue != value)
                {
                    slider.SliderValue = value;
                    OnPropertyChange("SliderValue");
                }
            }
        }


        public MySliderViewModel()
        {
            slider = new Slider
            {
                SliderValue = _sliderValue
            };
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
