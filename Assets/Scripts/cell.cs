using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cell : MonoBehaviour {

    public int RowValue;
    public int ColumnValue;
    public bool isFilled = false;
    public int filledWithTeam;
    public bool isRow1 = false;


    private void OnMouseEnter()
    {
        var renderer = GetComponent<SpriteRenderer>();
        Color color = new Color(0f, 0f, 0f, 255f);
        renderer.color = color;
        
    }
    private void OnMouseExit()
    {

        var renderer = GetComponent<SpriteRenderer>();
        Color color = new Color(0f, 0f, 0f, 0f);
        renderer.color = color;

    }

    private void OnMouseDown()
    {
        var gameManager = GameObject.FindGameObjectWithTag("gm").GetComponent<GameManager>();
        gameManager.fillWithCounter(this);

        var renderer = GetComponent<SpriteRenderer>();
        Color color = new Color(255f, 0f, 0f, 255f);
        renderer.color = color;
    }

    private void OnMouseUpAsButton()
    {
        print("Memem");
        var renderer = GetComponent<SpriteRenderer>();
        Color color = new Color(0f, 0f, 0f, 255f);
        renderer.color = color;
    }

    


}
