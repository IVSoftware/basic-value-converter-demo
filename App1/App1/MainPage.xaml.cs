    using System;
    using System.Globalization;
    using Xamarin.Forms;

    namespace App1
    {
        public partial class MainPage : ContentPage
        {
            public MainPage()
            {
                BindingContext = this;
                InitializeComponent();
            }
            bool _IsToggled = false;
            public bool IsToggled
            {
                get => _IsToggled;
                set
                {
                    if (_IsToggled != value)
                    {
                        _IsToggled = value;
                        OnPropertyChanged(nameof(IsToggled));
                    }
                }
            }
        }

        /// <summary>
        /// Value converter class
        /// </summary>
        public class BoolToTextConverter : IValueConverter
        {
            public string IfFalse { get; set; }
            public string IfTrue { get; set; }

            public virtual object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                if ((bool)value)
                {
                    return IfTrue;
                }
                else
                {
                    return IfFalse;
                }
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        }
    }