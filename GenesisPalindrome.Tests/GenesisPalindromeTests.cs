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
        Assert.True(result, $"Failed for '{word}'");
    }

    [Theory]
    [InlineData("Aba")]
    [InlineData("aBba")]
    public void ShouldBeCaseInsensitive(string word)
    {
        Palindrome palindrome = new ();
        bool result = palindrome.IsPalindrome(word);
        Assert.True(result, $"Failed for '{word}'");
    }

    [Theory]
    // [InlineData(")a!b@c#d$d/c]b&a^")]
    [InlineData("  a b   b        a      ")]
    public void ShouldIgnoreNonAlphaNumeric(string word)
    {
        Palindrome palindrome = new ();
        bool result = palindrome.IsPalindrome(word);
        Assert.True(result, $"Failed for '{word}'");
    }

    [Theory]
    [InlineData("abc")]
    [InlineData("abbc")]
    [InlineData("abca")]
    [InlineData("abcca")]
    public void ShouldNotBePalindrome(string word)
    {
        Palindrome palindrome = new ();
        bool result = palindrome.IsPalindrome(word);
        Assert.False(result, $"Failed for '{word}'");
    }

    [Fact]
    public void ShouldFindPalindromeAfterNotFindingPalindrome()
    {
        string palindromeWord = "";
        string notPalindromeWord = "abbc";

        Palindrome palindrome = new Palindrome();

        bool result = palindrome.IsPalindrome(notPalindromeWord);
        Assert.False(result);

        result = palindrome.IsPalindrome(palindromeWord);
        Assert.True(result);
    }
}
