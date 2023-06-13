using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormScript : MonoBehaviour
{

    public GameObject GM;
    public WormGame game;

    private void Start()
    {
        GM = GameObject.Find("WormGameManager");
        game = GM.GetComponent<WormGame>();
    }

    public void updateScore()
    {
        game.score = game.score + 1;
        Destroy(this.gameObject);
    }

    private void OnMouseDown()
    {
        updateScore();
    }
}
