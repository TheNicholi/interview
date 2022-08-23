using System;
using System.Collections.Generic;
using Truckstop.Interview.Business;
using Xunit;

namespace Truckstop.Interview.UnitTests.Business
{
    public class StatisticsManagerTests
    {
        [Fact]
        public void Given_ListOfWordsWhereLongestWordIsUnicorn_When_GettingLongestWord_Then_ReturnsUnicorn()
        {
            // Arrange
            var expected = "unicorn";
            var wordList = new List<string> { "the", expected, "value", "better", "be", "result" };
            var target = new StatisticsManager();

            // Act
            var actual = target.GetLongestWord(wordList);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Given_ListOfWordsAllOfSameLength_When_GettingLongestWord_Then_ReturnsFirstWordInList()
        {
            // Arrange
            var expected = "geek";
            var wordList = new List<string> { expected, "will", "rule", "thee", "test" };
            var target = new StatisticsManager();

            // Act
            var actual = target.GetLongestWord(wordList);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Given_InvalidId_When_GettingVocabWord_Then_ThrowsException()
        {
            // Arrange
            var invalidId = 1;
            var target = new StatisticsManager();

            // Act / Assert
            Assert.ThrowsAsync<Exception>(() => target.GetVocabWordByIdAsync(invalidId));
        }
    }
}
