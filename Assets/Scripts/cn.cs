using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cn : MonoBehaviour {

	public int team;

    // Use this for initialization
    void Start()
    {
        
        colorassign();
    }

    public void colorassign()
    {
        var rend = this.GetComponent<SpriteRenderer>();
        if (team == 1)
        {
            rend.sprite = GameManager.FindRightChar(GameManager.PlayerName1);
            rend.color = GameManager.Player1Color;

        }
        if (team == 2)
        {

            rend.sprite = GameManager.FindRightChar(GameManager.PlayerName2);
            rend.color = GameManager.Player2Color;
        }

    }
}
