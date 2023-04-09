using System.Windows;
using System.Windows.Media;

namespace NotePad.Models
{
    public class FormatModel : ObservableObject
    {
        private FontStyle _fontStyle;
        private FontWeight _fontWeight;
        private FontFamily _fontFamily;
        private TextWrapping _textWrapping;
        private bool isWrapped;
        private double _size;

        public FontStyle FontStyle
        {
            get { return _fontStyle; }
            set { OnPropertyChanged(ref _fontStyle, value); }
        }

        public FontWeight FontWeight
        {
            get { return _fontWeight; }
            set { OnPropertyChanged(ref _fontWeight, value); }
        }

        public FontFamily FontFamily
        {
            get { return _fontFamily; }
            set
            {
                OnPropertyChanged(ref _fontFamily, value);
            }

        }
        public TextWrapping TextWrapping
        {
            get { return _textWrapping; }
            set
            {
                OnPropertyChanged(ref _textWrapping, value);
                isWrapped = value==TextWrapping.Wrap ? true:false;
            }
        }


        public bool IsWrapped
        {
            get { return isWrapped; }
            set
            {
                OnPropertyChanged(ref isWrapped, value);
            }
        }

        public double Size
        {
            get { return _size; }
            set { OnPropertyChanged(ref _size, value); }
        }

    }
}