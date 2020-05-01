using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static bool isRussian = false;

    public static int Player1Score = 0;
    public static int Player2Score = 0;

    public static bool player_switch = true;
    public cn cn;

    public static string PlayerName1;
    public static string PlayerName2;

    private static bool GameIsWon = false;

    public static Sprite Player1Cn;
    public static Sprite Player2Cn;

    public static Color CnRed = new Color32(197, 40, 40, 255);
    public static Color CnBlue = new Color32(40, 72, 197, 255);
    public static Color CnPurple = new Color32(185, 66, 181, 255);
    public static Color CnGreen = new Color32(66, 185, 81, 255);
    public static Color CnGold = new Color32(209, 212, 57, 255);

    public static Color Player1Color = CnRed;
    public static Color Player2Color = CnBlue;


    public static bool ColorGoldisTaken = false;
    public static bool ColorRedisTaken = true;
    public static bool ColorBlueisTaken = true;
    public static bool ColorPurpleisTaken = false;
    public static bool ColorGreenisTaken = false;

    public Text wintext;
    public Button winbutton;


    public static int winner;


    static public cell[] tempColumns = new cell[7];
    static public cell[] tempRows = new cell[8];
    static public cell[] tempDaig = new cell[43];


    public void LoadMainMenu() {
        if (GameIsWon) { GameIsWon = false; }
        Player1Score = 0;
        Player2Score = 0;
        SceneManager.LoadScene("MainMenu");
    }
    public void LoadGameMenu() { SceneManager.LoadScene("GameMenu"); }
    public void LoadGameScreen() { SceneManager.LoadScene("Game"); }
    public void Quit() { Application.Quit(); }

    // 1 red, 2 blue
    public static void YouWin(int input)
    {
        GameIsWon = true;   
        if (input == 1)
        {
            print("RED WINSSSSSSSSSS");
            Player1Score++;
            winner = 1;

        }
        else if (input == 2)
        {
            print("BLUE WINSSSSSSSSSS");
            Player2Score++;
            winner = 2;
        }
        else
        {
            Debug.LogError("THE INPUT FOR THIS FUNCTION WAS NOT 1 OR 2 SO IDK WHO WINSSSSSSSSSS");
        }

        
        


    }


    private void Start()
    {
        

        
    }

    // WIN CHECKS
    public static void WinCheckDaig()
    {

        //rows (1,2,3,4) OR (2,3,4,5) OR (3,4,5,6) OR (4, 5, 6, 7)
        int tempI = 1;
        
        for (int input = 7; input > 0; input--)
        {
            for (int i = 6; i > 0; i--)
            {
                Debug.LogWarning("Now Attempting to draw Cell for daig " + input + ";" + i);
                tempDaig[tempI] = GameObject.Find("Cell " + input + ";" + i).GetComponent<cell>();
                tempI++;
            }

        }

        /** 1 MOVE DIAGS **/
        
        if (areFourFilled(tempDaig[24].isFilled,
            tempDaig[17].isFilled,
            tempDaig[10].isFilled,
            tempDaig[3].isFilled))
        {
            //Debug.LogError("1 MOVE DIAG");
            areFourTheSameTeam(tempDaig[24].filledWithTeam,
                tempDaig[17].filledWithTeam,
                tempDaig[10].filledWithTeam,
                tempDaig[3].filledWithTeam);

        }

        if (areFourFilled(tempDaig[40].isFilled,
            tempDaig[33].isFilled,
            tempDaig[26].isFilled,
            tempDaig[19].isFilled))
        {
            //Debug.LogError("1 MOVE DIAG");
            areFourTheSameTeam(tempDaig[40].filledWithTeam,
                tempDaig[33].filledWithTeam,
                tempDaig[26].filledWithTeam,
                tempDaig[19].filledWithTeam);

        }

        if (areFourFilled(tempDaig[24].isFilled,
           tempDaig[29].isFilled,
           tempDaig[34].isFilled,
           tempDaig[39].isFilled))
        {
            //Debug.LogError("1 MOVE DIAG");
            areFourTheSameTeam(tempDaig[24].filledWithTeam,
                tempDaig[29].filledWithTeam,
                tempDaig[34].filledWithTeam,
                tempDaig[39].filledWithTeam);

        }

        if (areFourFilled(tempDaig[4].isFilled,
           tempDaig[9].isFilled,
           tempDaig[14].isFilled,
           tempDaig[19].isFilled))
        {
           //Debug.LogError("1 MOVE DIAG");
            areFourTheSameTeam(tempDaig[4].filledWithTeam,
                tempDaig[9].filledWithTeam,
                tempDaig[14].filledWithTeam,
                tempDaig[19].filledWithTeam);

        }


        /** 2 MOVE DIAGS **/

        if (areFourFilled(tempDaig[30].isFilled,
            tempDaig[23].isFilled,
            tempDaig[16].isFilled,
            tempDaig[9].isFilled))
        {
            //Debug.LogError("2 MOVE DIAG");
            areFourTheSameTeam(tempDaig[30].filledWithTeam,
                tempDaig[23].filledWithTeam,
                tempDaig[16].filledWithTeam,
                tempDaig[9].filledWithTeam);

        }

        if (areFourFilled(tempDaig[23].isFilled,
            tempDaig[16].isFilled,
            tempDaig[9].isFilled,
            tempDaig[2].isFilled))
        {
            //Debug.LogError("2 MOVE DIAG");
            areFourTheSameTeam(tempDaig[23].filledWithTeam,
                tempDaig[16].filledWithTeam,
                tempDaig[9].filledWithTeam,
                tempDaig[2].filledWithTeam);

        }

        if (areFourFilled(tempDaig[41].isFilled,
            tempDaig[34].isFilled,
            tempDaig[27].isFilled,
            tempDaig[20].isFilled))
        {
            //Debug.LogError("2 MOVE DIAG");
            areFourTheSameTeam(tempDaig[41].filledWithTeam,
                tempDaig[34].filledWithTeam,
                tempDaig[27].filledWithTeam,
                tempDaig[20].filledWithTeam);

        }

        if (areFourFilled(tempDaig[34].isFilled,
            tempDaig[27].isFilled,
            tempDaig[20].isFilled,
            tempDaig[13].isFilled))
        {
            //Debug.LogError("2 MOVE DIAG");
            areFourTheSameTeam(tempDaig[34].filledWithTeam,
                tempDaig[27].filledWithTeam,
                tempDaig[20].filledWithTeam,
                tempDaig[13].filledWithTeam);

        }

        /** 2 MOVE DIAGS (INVERTED) **/

        if (areFourFilled(tempDaig[5].isFilled,
            tempDaig[10].isFilled,
            tempDaig[15].isFilled,
            tempDaig[20].isFilled))
        {
            //Debug.LogError("2 MOVE DIAG");
            areFourTheSameTeam(tempDaig[5].filledWithTeam,
                tempDaig[10].filledWithTeam,
                tempDaig[15].filledWithTeam,
                tempDaig[20].filledWithTeam);

        }

        if (areFourFilled(tempDaig[10].isFilled,
            tempDaig[15].isFilled,
            tempDaig[20].isFilled,
            tempDaig[25].isFilled))
        {
            //Debug.LogError("2 MOVE DIAG");
            areFourTheSameTeam(tempDaig[10].filledWithTeam,
                tempDaig[15].filledWithTeam,
                tempDaig[20].filledWithTeam,
                tempDaig[25].filledWithTeam);

        }

        if (areFourFilled(tempDaig[18].isFilled,
            tempDaig[23].isFilled,
            tempDaig[28].isFilled,
            tempDaig[33].isFilled))
        {
            //Debug.LogError("2 MOVE DIAG");
            areFourTheSameTeam(tempDaig[18].filledWithTeam,
                tempDaig[23].filledWithTeam,
                tempDaig[28].filledWithTeam,
                tempDaig[33].filledWithTeam);

        }

        if (areFourFilled(tempDaig[23].isFilled,
            tempDaig[28].isFilled,
            tempDaig[33].isFilled,
            tempDaig[38].isFilled))
        {
            //Debug.LogError("2 MOVE DIAG");
            areFourTheSameTeam(tempDaig[23].filledWithTeam,
                tempDaig[28].filledWithTeam,
                tempDaig[33].filledWithTeam,
                tempDaig[38].filledWithTeam);

        }

        /** 3 MOVE DIAGS TOP **/

        if (areFourFilled(tempDaig[42].isFilled,
            tempDaig[35].isFilled,
            tempDaig[28].isFilled,
            tempDaig[21].isFilled))
        {
            //Daig MOVE
            areFourTheSameTeam(tempDaig[42].filledWithTeam,
                tempDaig[35].filledWithTeam,
                tempDaig[28].filledWithTeam,
                tempDaig[21].filledWithTeam);

        }

        if (areFourFilled(tempDaig[35].isFilled,
            tempDaig[28].isFilled,
            tempDaig[21].isFilled,
            tempDaig[14].isFilled))
        {
            //Daig MOVE
            areFourTheSameTeam(tempDaig[35].filledWithTeam,
                tempDaig[28].filledWithTeam,
                tempDaig[21].filledWithTeam,
                tempDaig[14].filledWithTeam);

        }

        if (areFourFilled(tempDaig[28].isFilled,
            tempDaig[21].isFilled,
            tempDaig[14].isFilled,
            tempDaig[7].isFilled))
        {
            //Daig MOVE
            areFourTheSameTeam(tempDaig[28].filledWithTeam,
                tempDaig[21].filledWithTeam,
                tempDaig[14].filledWithTeam,
                tempDaig[7].filledWithTeam);

        }

        /** 3 MOVE DIAGS BOTTOM **/

        if (areFourFilled(tempDaig[36].isFilled,
            tempDaig[29].isFilled,
            tempDaig[22].isFilled,
            tempDaig[15].isFilled))
        {
            //Daig MOVE
            areFourTheSameTeam(tempDaig[36].filledWithTeam,
                tempDaig[29].filledWithTeam,
                tempDaig[22].filledWithTeam,
                tempDaig[15].filledWithTeam);

        }

        if (areFourFilled(tempDaig[29].isFilled,
            tempDaig[22].isFilled,
            tempDaig[15].isFilled,
            tempDaig[8].isFilled))
        {
            //Daig MOVE
            areFourTheSameTeam(tempDaig[29].filledWithTeam,
                tempDaig[22].filledWithTeam,
                tempDaig[15].filledWithTeam,
                tempDaig[8].filledWithTeam);

        }

        if (areFourFilled(tempDaig[22].isFilled,
            tempDaig[15].isFilled,
            tempDaig[8].isFilled,
            tempDaig[1].isFilled))
        {
            //Daig MOVE
            areFourTheSameTeam(tempDaig[22].filledWithTeam,
                tempDaig[15].filledWithTeam,
                tempDaig[8].filledWithTeam,
                tempDaig[1].filledWithTeam);

        }

        /** 3 MOVE DIAGS TOP (INVERTED) **/

        if (areFourFilled(tempDaig[31].isFilled,
            tempDaig[26].isFilled,
            tempDaig[21].isFilled,
            tempDaig[16].isFilled))
        {
            //Daig MOVE
            areFourTheSameTeam(tempDaig[31].filledWithTeam,
                tempDaig[26].filledWithTeam,
                tempDaig[21].filledWithTeam,
                tempDaig[16].filledWithTeam);

        }

        if (areFourFilled(tempDaig[26].isFilled,
            tempDaig[21].isFilled,
            tempDaig[16].isFilled,
            tempDaig[11].isFilled))
        {
            //Daig MOVE
            areFourTheSameTeam(tempDaig[26].filledWithTeam,
                tempDaig[21].filledWithTeam,
                tempDaig[16].filledWithTeam,
                tempDaig[11].filledWithTeam);

        }

        if (areFourFilled(tempDaig[21].isFilled,
            tempDaig[16].isFilled,
            tempDaig[11].isFilled,
            tempDaig[6].isFilled))
        {
            //Daig MOVE
            areFourTheSameTeam(tempDaig[21].filledWithTeam,
                tempDaig[16].filledWithTeam,
                tempDaig[11].filledWithTeam,
                tempDaig[6].filledWithTeam);

        }

        /** 3 MOVE DIAGS BOTTOM (INVERTED) **/

        if (areFourFilled(tempDaig[37].isFilled,
            tempDaig[32].isFilled,
            tempDaig[27].isFilled,
            tempDaig[22].isFilled))
        {
            //Daig MOVE
            areFourTheSameTeam(tempDaig[37].filledWithTeam,
                tempDaig[32].filledWithTeam,
                tempDaig[27].filledWithTeam,
                tempDaig[22].filledWithTeam);

        }

        if (areFourFilled(tempDaig[32].isFilled,
            tempDaig[27].isFilled,
            tempDaig[22].isFilled,
            tempDaig[17].isFilled))
        {
            //Daig MOVE
            areFourTheSameTeam(tempDaig[32].filledWithTeam,
                tempDaig[27].filledWithTeam,
                tempDaig[22].filledWithTeam,
                tempDaig[17].filledWithTeam);

        }

        if (areFourFilled(tempDaig[27].isFilled,
            tempDaig[22].isFilled,
            tempDaig[17].isFilled,
            tempDaig[12].isFilled))
        {
            //Daig MOVE
            areFourTheSameTeam(tempDaig[27].filledWithTeam,
                tempDaig[22].filledWithTeam,
                tempDaig[17].filledWithTeam,
                tempDaig[12].filledWithTeam);

        }

    }



    public static void WinCheckRows(int input)
    {

        //rows (1,2,3,4) OR (2,3,4,5) OR (3,4,5,6) OR (4, 5, 6, 7)

        for (int i = 7; i > 0; i--)
        {
            //Debug.LogWarning("Now Attempting to draw Cell " + i + ";" + input);
            tempRows[i] = GameObject.Find("Cell " + i + ";" + input).GetComponent<cell>();


        }

        if (areFourFilled(tempRows[1].isFilled,
            tempRows[2].isFilled,
            tempRows[3].isFilled,
            tempRows[4].isFilled))
        {

            areFourTheSameTeam(tempRows[1].filledWithTeam,
                tempRows[2].filledWithTeam,
                tempRows[3].filledWithTeam,
                tempRows[4].filledWithTeam);

        }
        if (areFourFilled(tempRows[2].isFilled,
            tempRows[3].isFilled,
            tempRows[4].isFilled,
            tempRows[5].isFilled))
        {
            areFourTheSameTeam(tempRows[2].filledWithTeam,
                tempRows[3].filledWithTeam,
                tempRows[4].filledWithTeam,
                tempRows[5].filledWithTeam);

        }
        if (areFourFilled(tempRows[3].isFilled,
            tempRows[4].isFilled,
            tempRows[5].isFilled,
            tempRows[6].isFilled))
        {
            areFourTheSameTeam(tempRows[3].filledWithTeam,
                tempRows[4].filledWithTeam,
                tempRows[5].filledWithTeam,
                tempRows[6].filledWithTeam);

        }
        if (areFourFilled(tempRows[4].isFilled,
            tempRows[5].isFilled,
            tempRows[6].isFilled,
            tempRows[7].isFilled))
        {
            areFourTheSameTeam(tempRows[4].filledWithTeam,
                tempRows[5].filledWithTeam,
                tempRows[6].filledWithTeam,
                tempRows[7].filledWithTeam);

        }


    }



    public static void WinCheckColumns(int input){

        //columns (1,2,3,4) OR (2,3,4,5) OR (3,4,5,6)

        for (int i = 6; i > 0; i--)
        {
            //Debug.LogWarning("Now Attempting to draw Cell " + input + ";" + i);
            tempColumns[i] = GameObject.Find("Cell " + input + ";" + i).GetComponent<cell>();


        }

        if (areFourFilled(tempColumns[1].isFilled, tempColumns[2].isFilled, tempColumns[3].isFilled, tempColumns[4].isFilled)) {
            
            areFourTheSameTeam(tempColumns[1].filledWithTeam, tempColumns[2].filledWithTeam, tempColumns[3].filledWithTeam, tempColumns[4].filledWithTeam);
            
        }
        if (areFourFilled(tempColumns[2].isFilled, tempColumns[3].isFilled, tempColumns[4].isFilled, tempColumns[5].isFilled))
        {
            areFourTheSameTeam(tempColumns[2].filledWithTeam, tempColumns[3].filledWithTeam, tempColumns[4].filledWithTeam, tempColumns[5].filledWithTeam);

        }
        if (areFourFilled(tempColumns[3].isFilled, tempColumns[4].isFilled, tempColumns[5].isFilled, tempColumns[6].isFilled))
        {
            areFourTheSameTeam(tempColumns[3].filledWithTeam, tempColumns[4].filledWithTeam, tempColumns[5].filledWithTeam, tempColumns[6].filledWithTeam);

        }



    }


    public static bool areFourFilled(bool i1, bool i2, bool i3, bool i4) {
        if (i1 == true && i2 == true && i3 == true && i4 == true)
        {
            return true;
        }
        else {
            return false;
        }
    }

    public static void areFourTheSameTeam(int i1, int i2, int i3, int i4) {
        print("Checking if won; first 4 are filled, execute win");
        Debug.Log("i1 = " + i1 + ", i2 = " + i2 + ", i3 = " + i3 + ", i4 =" + i4);

        if (i1 == 1 && i2 == 1 && i3 == 1 && i4 == 1)
        {
            
            YouWin(1);

        }
        if (i1 == 2 && i2 == 2 && i3 == 2 && i4 == 2)
        {
            YouWin(2);
        }
        
        


    }



    public void fillWithCounter(cell inputCell)
    {

        if (!GameIsWon)
        {
            var cellToFill = FindCellToFill(inputCell.ColumnValue);
            if (cellToFill.RowValue != 0)
            {
                CreateCounter(cellToFill);
            }


            for (int i = 7; i > 0; i--)
            {
                WinCheckColumns(i);
            }
            for (int i = 6; i > 0; i--)
            {
                WinCheckRows(i);
            }
            WinCheckDaig();

        }







    }


    // This takes the column of the selected cell and finds the next free cell to place a counter at
    public cell FindCellToFill(int column) {
        //This is used to identify if the thingy fails to find a spot
        var error = GameObject.Find("Cell " + 0 + ";" + 0).GetComponent<cell>();
        
        //Topcheck is used to check if the top of the column is filled
        //If it isn't, the for loop is executed. If it is, it skips it and returns the error cell
        var topCheck = GameObject.Find("Cell " + column + ";" + 6).GetComponent<cell>();
        if (!topCheck.isFilled)
        {
            //i is 6 because it's the top row
            for (int i = 6; i > 0; i--)
            {


                //temp is the cheking variable, it repesents the cell the loop is checking
                var temp = GameObject.Find("Cell " + column + ";" + i).GetComponent<cell>();
                print("Temp Col value: " + temp.ColumnValue + ", Temp row value: " + temp.RowValue);

                if (temp.isFilled && temp.RowValue < 6)
                {
                    //TempI is used for incrementing the current i, so the cell above it can be filled
                    int tempI = i + 1;
                    print("Created Counter!!! Exact Command: " + "Cell " + column + ";" + tempI);
                    var temp2 = GameObject.Find("Cell " + column + ";" + tempI).GetComponent<cell>();

                    return temp2;
                }

                else if (temp.isRow1 && !temp.isFilled)
                {
                    print("Was bottom row, created first counter!");
                    return temp;

                }

                print("Did not create a counter this go, trying again");
            }

        }

        // Couldn't find spot, so the move must be invalid
        Debug.LogWarning("Move does not compute, moving to temp cell");
        return error;



    }



    private void Update()
    {
        if (Input.GetKeyDown("u")) {
            NewGame();
        }




        if (GameIsWon) {

            if (winner == 1) { wintext.text = PlayerName1 + " Wins!"; };
            if (winner == 2) { wintext.text = PlayerName2 + " Wins!"; };
            winbutton.gameObject.SetActive(true);
        }

        else if (player_switch == true && wintext) {
            wintext.text = PlayerName1 + "'s Turn";
        }
        else if (player_switch == false && wintext)
        {
            wintext.text = PlayerName2 + "'s Turn";
        }
    }



    public void NewGame() {
        GameIsWon = false;

        winbutton.gameObject.SetActive(false);
        

        GameObject[] counters = GameObject.FindGameObjectsWithTag("cn");
        foreach (GameObject cn in counters)
        {
            GameObject.Destroy(cn);
        }

        GameObject[] cells = GameObject.FindGameObjectsWithTag("cell");
        foreach (GameObject cell in cells)
        {
            cell.GetComponent<cell>().isFilled = false;
            cell.GetComponent<cell>().filledWithTeam = 0;
        }
        player_switch = true;

    }







    public void CreateCounter(cell input) {

        if (!GameIsWon)
        {
            if (GameManager.player_switch == true)
            {

                print("filled red " + input.RowValue + "/" + input.ColumnValue);
                input.isFilled = true;
                input.filledWithTeam = 1;

                cn.team = 1;
                Instantiate(cn, input.transform.position, Quaternion.identity);


                GameManager.player_switch = false;
            }

            else if (GameManager.player_switch == false)
            {

                print("filled blue " + input.RowValue + "/" + input.ColumnValue);
                input.isFilled = true;
                input.filledWithTeam = 2;

                cn.team = 2;
                Instantiate(cn, input.transform.position, Quaternion.identity);


                GameManager.player_switch = true;
            }
        }

    }


    public void  SetColorCNPlayer2(string input) {

        switch (input)
        {
            case "Blue":
                Player2Color = CnBlue;
                break;
            case "Red":
                Player2Color = CnRed;
                break;
            case "Gold":
                Player2Color = CnGold;
                break;
            case "Purple":
                Player2Color = CnPurple;
                break;
            case "Green":
                Player2Color = CnGreen;
                break;


            default:
                Player2Color = CnBlue;
                break;
        }

    }

    public void SetColorCNPlayer1(string input)
    {

        switch (input)
        {
            case "Blue":
                Player1Color = CnBlue;
                break;
            case "Red":
                Player1Color = CnRed;
                break;
            case "Gold":
                Player1Color = CnGold;
                break;
            case "Purple":
                Player1Color = CnPurple;
                break;
            case "Green":
                Player1Color = CnGreen;
                break;


            default:
                Player1Color = CnBlue;
                break;
        }

    }






    public static Sprite FindRightChar(string inputString) {


        if (inputString == ("maddy") || inputString == ("Maddy"))
        {
            return Resources.Load<Sprite>("letters/mHeart");
        }

        inputString = inputString.ToLower();
        

            char letter = inputString[0];

            String[] arrayOfLetters = {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q",
            "r", "s", "t", "u", "v", "w", "x", "y","z", "я", "ш", "е", "р", "т", "ы", "у",
            "ё", "ъ", "и", "о", "п", "ю", "щ", "а","с", "д", "ф", "г", "ч", "й", "к", "л",
            "ь", "ж", "э", "з", "х", "ц", "в", "б","н", "м"};

        int pos = Array.IndexOf(arrayOfLetters, letter.ToString());
        

        if (pos > -1)
            {

            if      (letter.ToString() == "ё") { return Resources.Load<Sprite>("letters/ru-yo"); }
            else if (letter.ToString() == "я") { return Resources.Load<Sprite>("letters/ru-ya"); }
            else if (letter.ToString() == "ш") { return Resources.Load<Sprite>("letters/ru-sh"); }
            else if (letter.ToString() == "е") { return Resources.Load<Sprite>("letters/ru-e"); }
            else if (letter.ToString() == "р") { return Resources.Load<Sprite>("letters/ru-r"); }
            else if (letter.ToString() == "т") { return Resources.Load<Sprite>("letters/ru-t"); }
            else if (letter.ToString() == "ы") { return Resources.Load<Sprite>("letters/ru-y"); }
            else if (letter.ToString() == "у") { return Resources.Load<Sprite>("letters/ru-oo"); }
            else if (letter.ToString() == "и") { return Resources.Load<Sprite>("letters/ru-i"); }
            else if (letter.ToString() == "о") { return Resources.Load<Sprite>("letters/ru-o"); }
            else if (letter.ToString() == "п") { return Resources.Load<Sprite>("letters/ru-p"); }
            else if (letter.ToString() == "ю") { return Resources.Load<Sprite>("letters/ru-yu"); }
            else if (letter.ToString() == "щ") { return Resources.Load<Sprite>("letters/ru-shch"); }
            else if (letter.ToString() == "а") { return Resources.Load<Sprite>("letters/ru-a"); }
            else if (letter.ToString() == "с") { return Resources.Load<Sprite>("letters/ru-s"); }
            else if (letter.ToString() == "д") { return Resources.Load<Sprite>("letters/ru-d"); }
            else if (letter.ToString() == "ф") { return Resources.Load<Sprite>("letters/ru-f"); }
            else if (letter.ToString() == "г") { return Resources.Load<Sprite>("letters/ru-g"); }
            else if (letter.ToString() == "ч") { return Resources.Load<Sprite>("letters/ru-ch"); }
            else if (letter.ToString() == "й") { return Resources.Load<Sprite>("letters/ru-j"); }
            else if (letter.ToString() == "к") { return Resources.Load<Sprite>("letters/ru-k"); }
            else if (letter.ToString() == "л") { return Resources.Load<Sprite>("letters/ru-l"); }
            else if (letter.ToString() == "ь") { return Resources.Load<Sprite>("letters/ru-soft"); }
            else if (letter.ToString() == "ж") { return Resources.Load<Sprite>("letters/ru-zh"); }
            else if (letter.ToString() == "э") { return Resources.Load<Sprite>("letters/ru-shortE"); }
            else if (letter.ToString() == "з") { return Resources.Load<Sprite>("letters/ru-z"); }
            else if (letter.ToString() == "х") { return Resources.Load<Sprite>("letters/ru-h"); }
            else if (letter.ToString() == "ц") { return Resources.Load<Sprite>("letters/ru-ts"); }
            else if (letter.ToString() == "в") { return Resources.Load<Sprite>("letters/ru-v"); }
            else if (letter.ToString() == "б") { return Resources.Load<Sprite>("letters/ru-b"); }
            else if (letter.ToString() == "н") { return Resources.Load<Sprite>("letters/ru-n"); }
            else if (letter.ToString() == "м") { return Resources.Load<Sprite>("letters/ru-m"); }
            else if (letter.ToString() == "ъ") { return Resources.Load<Sprite>("letters/ru-hard"); }

            else { return Resources.Load<Sprite>("letters/" + letter); }


            
            }
            else
            {
                return Resources.Load<Sprite>("letters/a");
            }
        




    }

}
