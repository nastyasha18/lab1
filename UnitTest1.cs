using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
public class ONE
{
    [TestMethod]
    public void Sort_Test1()
    {
        // Arrange
        int[] digitals = { 5, 3, 1, 4, 2, 8, 8 };
        MAMAJAMA fun = new MAMAJAMA();


        // Act
        int result = fun.Sort(digitals);

        // Assert
        Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void Sort_Test2()
    {
        // Arrange
        int[] digitals = { 5, 4, 3, 2, 1 };
        MAMAJAMA fun = new MAMAJAMA();


        // Act
        int result = fun.Sort(digitals);

        // Assert
        Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void Sort_Test3()
    {
        // Arrange
        int[] digitals = { 1, 2, 3, 4, 5 };
        MAMAJAMA fun = new MAMAJAMA();


        // Act
        int result = fun.Sort(digitals);

        // Assert
        Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void Sort_Test4()
    {
        // Arrange
        int[] digitals = {};
        MAMAJAMA fun = new MAMAJAMA();


        // Act
        int result = fun.Sort(digitals);

        // Assert
        Assert.AreEqual(0, result);
    }
    // уже отсотрирован
    // {}
}

[TestClass]
public class TWO
{
    [TestMethod]
    public void Palindrome_test1()
    {
        //Arrange
        String pal = "radar";
        MAMAJAMA fun = new MAMAJAMA();

        //act
        int result = fun.Palindrome(pal);

        //Assert
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Palindrome_test2()
    {
        //Arrange
        String pal = "luk";
        MAMAJAMA fun = new MAMAJAMA();

        //act
        int result = fun.Palindrome(pal);

        //Assert
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void Palindrome_test3()
    {
        //Arrange
        String pal = "ar ra";
        MAMAJAMA fun = new MAMAJAMA();

        //act
        int result = fun.Palindrome(pal);

        //Assert
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Palindrome_test4()
    {
        //Arrange
        String pal = ".,f,.";
        MAMAJAMA fun = new MAMAJAMA();

        //act
        int result = fun.Palindrome(pal);

        //Assert
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Palindrome_test5()
    {
        //Arrange
        String pal = "";
        MAMAJAMA fun = new MAMAJAMA();

        //act
        int result = fun.Palindrome(pal);

        //Assert
        Assert.AreEqual(0, result);
    }
}

[TestClass]
public class THREE
{
    [TestMethod]
    public void Fact_test1()
    {
        //Arrange 
        int Fac = 14;
        MAMAJAMA fun = new MAMAJAMA();

        //Act
        int result =fun.Fact(Fac);

        //Assert
        Assert.AreEqual(-1, result);
    }

    [TestMethod]
    public void Fact_test2()
    {
        //Arrange 
        int Fac = 0;
        MAMAJAMA fun = new MAMAJAMA();

        //Act
        int result = fun.Fact(Fac);

        //Assert
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Fact_test3()
    {
        //Arrange 
        int Fac = -5;
        MAMAJAMA fun = new MAMAJAMA();

        //Act
        int result = fun.Fact(Fac);

        //Assert
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void Fact_test4()
    {
        //Arrange 
        int Fac = 3;
        MAMAJAMA fun = new MAMAJAMA();

        //Act
        int result = fun.Fact(Fac);

        //Assert
        Assert.AreEqual(6, result);
    }
}

[TestClass]
public class FOUR
{
    [TestMethod]
    public void Fib_test1()
    {
        //Arrange
        int Fiba = 0;
        MAMAJAMA fun = new MAMAJAMA();

        //Act
        int result = fun.Fib(Fiba);

        //Assert
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void Fib_test2() 
    {
        //Arrange
        int Fiba = -1;
        MAMAJAMA fun = new MAMAJAMA();

        //Act
        int result =fun.Fib(Fiba);

        //Assert
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Fib_test3()
    {
        //Arrange
        int Fiba = 1;
        MAMAJAMA fun = new MAMAJAMA();

        //Act
        int result = fun.Fib(Fiba);

        //Assert
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Fib_test4()
    {
        //Arrange
        int Fiba = 3;
        MAMAJAMA fun = new MAMAJAMA();

        //Act
        int result = fun.Fib(Fiba);

        //Assert
        Assert.AreEqual(2, result);
    }
}

[TestClass]
public class FIVE
{

    [TestMethod]    
    public void Stroki_test1() 
    { 
        //Arrange
        string text = "as";
        string word = "mask";
        int count = 0;
        MAMAJAMA fun = new MAMAJAMA();

        //Act
        int result = fun.Stroki(text, word);

        //Assert
        Assert.AreEqual(count,result);
    }

    [TestMethod]
    public void Stroki_test2()
    {
        //Arrange
        string text = "fokys";
        string word = "fdyikjgdse";
        int count = 0;
        MAMAJAMA fun = new MAMAJAMA();

        //Act
        int result = fun.Stroki(text, word);

        //Assert
        Assert.AreEqual(count, result);
    }

    [TestMethod]
    public void Stroki_test3()
    {
        //Arrange
        string text = "   ";
        string word = "mask";
        int count = 0;
        MAMAJAMA fun = new MAMAJAMA();

        //Act
        int result = fun.Stroki(text, word);

        //Assert
        Assert.AreEqual(count, result);
    }

    [TestMethod]
    public void Stroki_test4()
    {
        //Arrange
        string text = "lis";
        string word = "podlisa";
        int count = 0;
        MAMAJAMA fun = new MAMAJAMA();

        //Act
        int result = fun.Stroki(text, word);

        //Assert
        Assert.AreEqual(count, result);
    }
}

[TestClass]
public class SIX
{

    [TestMethod]
    public void Easy_test1()
    {
        //Arrange
        int norm = -3;
        MAMAJAMA fun = new MAMAJAMA();

        //Act
        int result = fun.Easy(norm);

        //Assert
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void Easy_test2()
    {
        //Arrange
        int norm = 1;
        MAMAJAMA fun = new MAMAJAMA();

        //Act
        int result = fun.Easy(norm);

        //Assert
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void Easy_test3()
    {
        //Arrange
        int norm = 7;
        MAMAJAMA fun = new MAMAJAMA();

        //Act
        int result = fun.Easy(norm);

        //Assert
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Easy_test4()
    {
        //Arrange
        int norm = 9;
        MAMAJAMA fun = new MAMAJAMA();

        //Act
        int result = fun.Easy(norm);

        //Assert
        Assert.AreEqual(0, result);
    }
}

[TestClass]
public class SEVEN
{

    [TestMethod]
    public void ReverseNumber_test1()
    {
        //Arrange
        int x = 1;
        MAMAJAMA fun = new MAMAJAMA();

        //Act
        int result = fun.ReverseNumber(1);

        //Assert
        Assert.AreEqual(x, result);
    }

    [TestMethod]
    public void ReverseNumber_test2()
    {
        //Arrange
        int x = -12;
        MAMAJAMA fun = new MAMAJAMA();

        //Act
        int result = fun.ReverseNumber(-21);

        //Assert
        Assert.AreEqual(x, result);
    }

    [TestMethod]
    public void ReverseNumber_test3()
    {
        //Arrange
        int x = -331;
        MAMAJAMA fun = new MAMAJAMA();

        //Act
        int result = fun.ReverseNumber(-133);

        //Assert
        Assert.AreEqual(x, result);
    }

    [TestMethod]
    public void ReverseNumber_test4()
    {
        //Arrange
        int x = 321;
        MAMAJAMA fun = new MAMAJAMA();

        //Act
        int result = fun.ReverseNumber(123);

        //Assert
        Assert.AreEqual(x, result);
    }
}

[TestClass]
public class EIGHT
{

    [TestMethod]
    public void IntToRoman_test1() 
    {
        //Arrange
        int x = -1;
        MAMAJAMA fun = new MAMAJAMA();

        //Act
        string result = fun.IntToRoman(x);

        //Assert
        Assert.AreEqual("", result);
    }

    [TestMethod]
    public void IntToRoman_test2()
    {
        //Arrange
        int x = 0;
        MAMAJAMA fun = new MAMAJAMA();

        //Act
        string result = fun.IntToRoman(x);

        //Assert
        Assert.AreEqual("", result);
    }

    [TestMethod]
    public void IntToRoman_test3()
    {
        //Arrange
        int x = 900;
        MAMAJAMA fun = new MAMAJAMA();

        //Act
        string result = fun.IntToRoman(x);

        //Assert
        Assert.AreEqual("CM", result);
    }

    [TestMethod]
    public void IntToRoman_test4()
    {
        //Arrange
        int x = 4000;
        MAMAJAMA fun = new MAMAJAMA();

        //Act
        string result = fun.IntToRoman(x);

        //Assert
        Assert.AreEqual("", result);
    }
}