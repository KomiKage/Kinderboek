using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class WormGame : MonoBehaviour
{
    public Transform [] spawn;
    public GameObject worm;
    private GameObject pref;
    public TMP_Text SC;

    public GameObject finished;

    public int score = 0;
    private int target = 6;

    private void Start()
    {
        StartCoroutine(wormSpawm());
    }

    private void Update()
    {
        SC.text = score.ToString();

        if (score == target) 
        {
            StopAllCoroutines();
            finished.SetActive(true);
        }
    }

    IEnumerator wormSpawm()
    {
        while (true)
        {
            int spawnTime = Random.Range(1, 4);
            yield return new WaitForSeconds(spawnTime);
            Debug.Log(spawnTime);
            try { Destroy(pref); } catch { Debug.Log("no pref available"); }
            int index = Random.Range(0, spawn.Length);
            pref = Instantiate(worm, spawn[index].position,Quaternion.identity);
        }

    }
}
