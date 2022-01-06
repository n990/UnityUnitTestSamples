using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class SimpleAdditionTest
{
    [Test]
    public void AdditionTestMethod()
    {
        int numberOne = 1;
        int numberTwo = 1;

        Assert.AreEqual(numberOne + numberTwo, 2);
    } // Use the Assert class to test conditions
}

