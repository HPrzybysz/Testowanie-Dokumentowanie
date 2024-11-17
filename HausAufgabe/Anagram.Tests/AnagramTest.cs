using Library;
using Xunit;

namespace AnagramTests
{
    public class AnagramTests
    {
        [Theory]
        [InlineData("evil", "vile", true)]
        [InlineData("listen", "silent", true)]
        [InlineData("triangle", "integral", true)]
        [InlineData("rat", "car", false)]
        [InlineData("evil", "live", true)]
        [InlineData("hello", "world", false)]
        [InlineData("a gentleman", "elegant man", true)]
        [InlineData("Anagram", "Nag a ram", true)]
        [InlineData("spaces", "specs a", true)]
        [InlineData(" ", " ", true)]
        public void IsAnagram_ShouldReturnExpectedResults(string word1, string word2, bool expected)
        {
            bool result = Anagram.IsAnagram(word1, word2);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void IsAnagram_ShouldHandleEmptyStrings()
        {

            bool result = Anagram.IsAnagram(string.Empty, string.Empty);

            Assert.True(result);
        }

        [Fact]
        public void IsAnagram_ShouldHandleNullInputs()
        {
            bool result = Anagram.IsAnagram(null, null);

            Assert.False(result);
        }

        [Fact]
        public void IsAnagram_ShouldHandleMixedCaseStrings()
        {
            bool result = Anagram.IsAnagram("Evil", "VILE");

            Assert.True(result);
        }
    }
}
