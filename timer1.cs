using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public float time = 90f;
    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        print(time);
        if(time <= 0)
        {
            int scene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(scene);
        }
    }
}
