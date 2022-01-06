using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class CubeTest
{
    private Cube[] cubes;
    // A Test behaves as an ordinary method
    [SetUp]
    public void Setup()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
        
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator CubeTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        cubes = GameObject.FindObjectsOfType<Cube>();
        yield return new WaitForSeconds(0.1f);
        Assert.AreEqual(cubes.Length, 4);
    }
}
