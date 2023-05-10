using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FakeLoader : MonoBehaviour
{

    public Slider slider;
    public int scene;
    private float loadProgress = 0;
    public float loadSpeed = 0.1f;
    
    void Start()
    {
        StartCoroutine(FakeLoad());
    }


    IEnumerator FakeLoad()
    {
        while (loadProgress < 1)
        {
            yield return new WaitForSeconds(loadSpeed);
            loadProgress = loadProgress + 0.01f;
            slider.value = loadProgress;
        }

        SceneManager.LoadScene(scene);
    }

}
