using GenesisPalindrome.Models;
using Xunit;

namespace GenesisPalindrome.Tests;

public class PalindromeTests
{
    [Theory]
    [InlineData("")]
    [InlineData("a")]
    [InlineData("aba")]
    [InlineData("abba")]
    [InlineData("abcba")]
    public void ShouldBePalindrome(string word)
    {
        Palindrome palindrome = new ();

        bool result = palindrome.IsPalindrome(word);

        Assert.True(result);
    }

    [Theory]
    [InlineData("Aba")]
    [InlineData("aBba")]
    [InlineData("abbc")]
    [InlineData("abca")]
    [InlineData("abcca")]
    public void ShouldNotBePalindrome(string word)
    {
        Palindrome palindrome = new ();

        bool result = palindrome.IsPalindrome(word);

        Assert.True(result);
    }
}
