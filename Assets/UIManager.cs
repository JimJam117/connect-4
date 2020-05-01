using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Dropdown Player1ColorDD;
    public Dropdown Player2ColorDD;
    public InputField Player1NameField;
    public InputField Player2NameField;
    public Text Player1Score;
    public Text Player2Score;

    public GameObject Title;
    public Button Play;
    public Button Back;
    public Button Exit;
    public Button Continue;
    public Button Menu;
    public Button PlayAgain;
    public Button ChangeLang;

    //localisation crap


    public Sprite TitleRU;
    public Sprite TitleEN;
    public Sprite FlagRU;
    public Sprite FlagEN;

    public Text Player1NameText;
    public Text Player1ColorText;
    public Text Player2NameText;
    public Text Player2ColorText;

    List<string> p1RUcolors = new List<string>{"красный", "синий", "золотой", "фиолетовый", "зеленый" };
    List<string> p2RUcolors = new List<string> { "синий", "красный", "золотой", "фиолетовый", "зеленый" };
    List<string> p1ENcolors = new List<string> { "red", "blue", "gold", "purple", "green" };
    List<string> p2ENcolors = new List<string> { "blue", "red", "gold", "purple", "green" };
    /*
    public void FlipLang() {

        GameManager.isRussian = !GameManager.isRussian;

        if (GameManager.isRussian == true)
        {
            Russify();

        }
        else {
            if (Title) { Title.GetComponent<SpriteRenderer>().sprite = TitleEN; }
            if (Play) { Play.GetComponentInChildren<Text>().text = "Play"; }
            if (Back) { Back.GetComponentInChildren<Text>().text = "Back"; }
            if (Exit) { Exit.GetComponentInChildren<Text>().text = "Exit"; }
            if (Continue) { Continue.GetComponentInChildren<Text>().text = "Continue"; }
            if (Menu) { Menu.GetComponentInChildren<Text>().text = "Main Menu"; }
            if (PlayAgain) { PlayAgain.GetComponentInChildren<Text>().text = "Play Again?"; }
            if (ChangeLang) { ChangeLang.image.sprite = FlagEN; }


            if (Player1ColorText) { Player1ColorText.text = "Player 1 Colour:"; }
            if (Player2ColorText) { Player2ColorText.text = "Player 2 Colour:"; }
            if (Player1NameText) { Player1NameText.text = "Player 1:"; }
            if (Player2NameText) { Player2NameText.text = "Player 2:"; }

            if (Player1ColorDD) { Player1ColorDD.ClearOptions(); Player1ColorDD.AddOptions(p1ENcolors); }
            if (Player2ColorDD) { Player2ColorDD.ClearOptions(); Player2ColorDD.AddOptions(p2ENcolors); }
        }

        


    }

    public void Russify()
    {
        if (Title) { Title.GetComponent<SpriteRenderer>().sprite = TitleRU; }
        if (Play) { Play.GetComponentInChildren<Text>().text = "Играть"; }
        if (Back) { Back.GetComponentInChildren<Text>().text = "Назад"; }
        if (Exit) { Exit.GetComponentInChildren<Text>().text = "Выход"; }
        if (Continue) { Continue.GetComponentInChildren<Text>().text = "Продолжать"; }
        if (Menu) { Menu.GetComponentInChildren<Text>().text = "Главное Меню"; }
        if (PlayAgain) { PlayAgain.GetComponentInChildren<Text>().text = "Играть Снова?"; }
        if (ChangeLang) { ChangeLang.image.sprite = FlagRU; }

        if (Player1ColorText) { Player1ColorText.text = "Цвет Игрока 1:"; }
        if (Player2ColorText) { Player2ColorText.text = "Цвет Игрока 2:"; }
        if (Player1NameText) { Player1NameText.text = "Игрок 1:"; }
        if (Player2NameText) { Player2NameText.text = "Игрок 2:"; }

        if (Player1ColorDD) { Player1ColorDD.ClearOptions(); Player1ColorDD.AddOptions(p1RUcolors); }
        if (Player2ColorDD) { Player2ColorDD.ClearOptions(); Player2ColorDD.AddOptions(p2RUcolors); }

    }
    */
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {

        


        if (Player1Score && Player2Score) {

            Player1Score.text = GameManager.PlayerName1 + "'s Score: "  + GameManager.Player1Score;
            Player2Score.text = GameManager.PlayerName2 + "'s Score: " + GameManager.Player2Score;
        }

        if (Input.GetKeyDown("w"))
        {
            print("Player 1 Color: " + GameManager.Player1Color + "Player 2 Color: " + GameManager.Player2Color);
        }
    }

    public void SetColors() {
        SetColorCNPlayer1(Player1ColorDD.value);
        SetColorCNPlayer2(Player2ColorDD.value);
    }

    public void SetColorCNPlayer2(int input) {

        switch (input)
        {
            case 0:
                GameManager.Player2Color = GameManager.CnBlue;
                break;
            case 1:
                GameManager.Player2Color = GameManager.CnRed;
                break;
            case 2:
                GameManager.Player2Color = GameManager.CnGold;
                break;
            case 3:
                GameManager.Player2Color = GameManager.CnPurple;
                break;
            case 4:
                GameManager.Player2Color = GameManager.CnGreen;
                break;


            default:
                GameManager.Player2Color = GameManager.CnBlue;
                break;
        }

    }

    public void SetColorCNPlayer1(int input)
    {

        switch (input)
        {
            case 0:
                GameManager.Player1Color = GameManager.CnRed;
                break;
            case 1:
                GameManager.Player1Color = GameManager.CnBlue;
                break;
            case 2:
                GameManager.Player1Color = GameManager.CnGold;
                break;
            case 3:
                GameManager.Player1Color = GameManager.CnPurple;
                break;
            case 4:
                GameManager.Player1Color = GameManager.CnGreen;
                break;


            default:
                GameManager.Player1Color = GameManager.CnRed;
                break;
        }





    }

    public void NametoChar() {
        if (Player1NameField.text != "") { GameManager.PlayerName1 = Player1NameField.text; }
        else { GameManager.PlayerName1 = "a"; }

        if (Player2NameField.text != "") { GameManager.PlayerName2 = Player2NameField.text; }
        else { GameManager.PlayerName2 = "b"; }

    }
}
