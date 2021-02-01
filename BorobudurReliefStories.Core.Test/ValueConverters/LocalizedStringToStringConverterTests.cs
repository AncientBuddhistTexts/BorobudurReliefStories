namespace BorobudurReliefStories.Core.Test.ValueConverters
{
    using System.Globalization;
    using BorobudurReliefStories.Core.Models;
    using BorobudurReliefStories.Core.ValueConverters;
    using FluentAssertions;
    using Xunit;

    public class LocalizedStringToStringConverterTests
    {
        private static readonly LocalizedString LocStr = new LocalizedString
        {
            En = "in english",
            Id = "in bhasa",
        };

        [Theory]
        [InlineData("en", "in english")]
        [InlineData("en-GB", "in english")]
        [InlineData("id", "in bhasa")]
        [InlineData("id-ID", "in bhasa")]
        [InlineData("fr-FR", "in english")]
        public void LoadRepository(string cultureName, string expected)
        {
            var ci = new CultureInfo(cultureName);

            var str = new LocalizedStringValueConverter().Convert(LocStr, typeof(string), null, ci);

            str.Should().Be(expected);
        }
    }
}
