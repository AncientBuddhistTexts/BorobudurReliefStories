namespace BorobudurReliefStories.Core.ValueConverters
{
    using System;
    using System.Globalization;
    using BorobudurReliefStories.Core.Models;
    using MvvmCross.Converters;

    public sealed class LocalizedStringValueConverter : MvxValueConverter<LocalizedString, string>
    {
        protected override string Convert(LocalizedString value, Type targetType, object parameter, CultureInfo culture)
        {
            if (culture.TwoLetterISOLanguageName.Equals("id", StringComparison.OrdinalIgnoreCase))
            {
                return value.Id;
            }

            return value.En;
        }
    }
}