using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Gameplay : MonoBehaviour
{

    //parameters
    [SerializeField] int blocksCount;

    // cache reference
    SceneLoader sceneLoader;

    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            sceneLoader.LoadNextScene();
        }
    }

    public void CountAllBlocks()
    {
        blocksCount++;
    }

    public void BlockDestroyed()
    {
        blocksCount--;
        if (blocksCount <= 0)
        {
            sceneLoader.LoadNextScene();
        }
    }
}
