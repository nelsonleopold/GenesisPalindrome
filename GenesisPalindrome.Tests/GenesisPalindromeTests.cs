using GenesisPalindrome.Models;
using Xunit;

namespace GenesisPalindrome.Tests;

public class PalindromeTests
{
    [Theory]
    [InlineData("aba")]
    [InlineData("Aba")]
    public void ShouldBePalindrome(string word)
    {
        Palindrome palindrome = new ();

        bool result = palindrome.IsPalindrome(word);

        Assert.True(result);
    }
}
