using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelForwarder : MonoBehaviour
{

    public static int currentLevel = 0;

    public static LevelForwarder instance;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        currentLevel++;
        SceneManager.LoadScene(currentLevel);
    }
}