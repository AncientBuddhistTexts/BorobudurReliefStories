namespace BorobudurReliefStories.UI.ValueConverters
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using BorobudurReliefStories.Core.Models;
    using Dawn;
    using Xamarin.Forms;

    public sealed class LocalizedStringValueConverter : IValueConverter
    {
        [SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", Scope = "Method", MessageId = "0", Justification = "Passing null is supported.")]
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Guard.Argument(targetType, nameof(targetType)).Equal(typeof(string));

            if (culture.TwoLetterISOLanguageName.Equals("id", StringComparison.OrdinalIgnoreCase))
            {
                return ((LocalizedString)value).Id;
            }

            return ((LocalizedString)value).En;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}
