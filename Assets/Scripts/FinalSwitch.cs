using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalSwitch : MonoBehaviour
{
    RawImage m_RawImage;
    public Texture[] m_Textures;

    public int currentScene = 0;
    public int chosenRoute;

    private int route1end = 11;
    private int route2end = 16;
    public int endScene = 17;

    private int fishermanScene = 10;
    private int wormScene = 4;

    public int IScene;
    public bool chosen;
    
    private bool transitioning = false;
    public bool wormGame;

    void Start()
    {
        currentScene = 0;
        m_RawImage = GetComponent<RawImage>();
        m_RawImage.texture = m_Textures[currentScene];
    }

    private void Update()
    {

        if (transitioning == false)
        {
            this.gameObject.transform.localScale += new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //transitioning = true;
            //StartCoroutine(Transistion());
        }

        Debug.Log(currentScene);
    }

    public void GoToImage(int pathScene)
    {
        IScene = pathScene;
        transitioning = true;
        StartCoroutine(Transistion());
    }

    public void NextImage()
    {
        transitioning = true;
        StartCoroutine(Transistion());
    }

    public void ImageSwitch()
    {
        if (currentScene == fishermanScene && wormGame)
        {
            SceneManager.LoadSceneAsync(wormScene);
        }

        currentScene++;

        if (chosenRoute == 1 && currentScene > route1end) { currentScene = endScene; chosenRoute = 0; }
        if (chosenRoute == 2 && currentScene > route2end) { currentScene = endScene; chosenRoute = 0; }

        try
        {
            m_RawImage.texture = m_Textures[currentScene];
        }
        catch { currentScene = 0; m_RawImage.texture = m_Textures[0]; }
    }

    public void SpecImageSwitch()
    {
        chosen = true;
        currentScene = IScene;
        m_RawImage.texture = m_Textures[currentScene];
    }

    IEnumerator Transistion()
    {
        float sec = 0;
        float time = 1f;
        float rate = 0.01f;
        float increase = 0.006f;

        while (transitioning)
        {
            yield return new WaitForSeconds(rate);
            this.gameObject.transform.localScale += new Vector3(increase, increase, 0);
            sec += rate;
            if (sec >= time)
            { transitioning = false;
                this.gameObject.transform.localScale = new Vector3(1, 1, 0);
                if (chosenRoute != 0 && chosen == false)
                {
                    SpecImageSwitch();
                }
                else {
                    { ImageSwitch(); }
                }
                yield break; }
        }
        
    }

}
