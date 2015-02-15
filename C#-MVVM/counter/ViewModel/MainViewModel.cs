using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace counter.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        int _Count;
        public int Count
        {
            get { return _Count; }
            set
            {
                Set(ref _Count, value);
            }
        }

        RelayCommand<object> _CmdIncrement;
        public RelayCommand<object> CmdIncrement
        {
            get
            {
                if (_CmdIncrement == null)
                {
                    _CmdIncrement = new RelayCommand<object>(
                        (parameter) =>
                        {
                            Count++;
                        });
                }
                return _CmdIncrement;
            }
        }
    }
}