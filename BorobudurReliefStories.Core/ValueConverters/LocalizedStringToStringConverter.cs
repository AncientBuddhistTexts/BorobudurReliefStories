namespace BorobudurReliefStories.Core.ValueConverters
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using BorobudurReliefStories.Core.Models;
    using MvvmCross.Converters;

    public sealed class LocalizedStringValueConverter : MvxValueConverter<LocalizedString, string>
    {
        [SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", Scope = "Method", MessageId = "0", Justification = "Passing null is supported.")]
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
