using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ImageSwitcher : MonoBehaviour
{
    RawImage m_RawImage;
    public Texture[] m_Textures;

    int currentImg = 0;

    void Start()
    {
        m_RawImage = GetComponent<RawImage>();
        m_RawImage.texture = m_Textures[currentImg];
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentImg++;
            try
            {
                m_RawImage.texture = m_Textures[currentImg];
            }
            catch { currentImg = 0; m_RawImage.texture = m_Textures[0]; }
        }
    }

}
