using GalaSoft.MvvmLight;

namespace temperature.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        string _Celsius;
        public string Celsius
        {
            get { return _Celsius; }
            set
            {
                double c;
                if (double.TryParse(value, out c))
                {
                    Set(ref _Celsius, value);

                    _Fahrenheit = (c * (9 / 5.0) + 32).ToString();
                    RaisePropertyChanged(() => Fahrenheit);                    
                }
            }
        }

        string _Fahrenheit;
        public string Fahrenheit
        {
            get { return _Fahrenheit; }
            set
            {
                double f;
                if (double.TryParse(value, out f))
                {
                    Set(ref _Fahrenheit, value);

                    _Celsius = ((f - 32) * (5/9.0)).ToString();
                    RaisePropertyChanged(() => Celsius); 
                }
            }
        }


    }
}