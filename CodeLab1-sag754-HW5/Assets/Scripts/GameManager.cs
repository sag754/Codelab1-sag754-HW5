using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text infoText;
    public Text infoTime;

    public float timer = 0; //start timer at 0 and keeps track of time

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        infoText.text = "Coins x " + PlayerController.instance.Coins;
        infoTime.text = "Time: " + (int)timer;
    }
}