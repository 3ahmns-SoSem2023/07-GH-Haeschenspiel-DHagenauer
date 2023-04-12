using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    private int rnd;
    public Image dice;
    public int runde = 0;
    public Text Player;
    private int x;
    private PickUp pickUpScript;
    private int count;

    public bool player1 = false;
    public bool player2 = false;
    public bool player3 = false;
    public bool player4 = false;

    public Button[] flowerBlue;
    public GameObject[] flowerBlueG;
    public Button[] flowerPink;
    public GameObject[] flowerPinkG;
    public Button[] flowerRed;
    public GameObject[] flowerRedG;
    public Button[] flowerYellow;
    public GameObject[] flowerYellowG;
    public Button[] flowerGreen;

    // Start is called before the first frame update
    void Start()
    {
        pickUpScript = GetComponent<PickUp>();
        player1 = true;
        Player.text = "An der Reihe: Player1";
        for (int i = 0; i < 10; i++)
        {
            flowerBlue[i].interactable = false;
            //flowerGreen[i].interactable = false;
            flowerPink[i].interactable = false;
            flowerRed[i].interactable = false;
            flowerYellow[i].interactable = false;

        }
        for (int i = 0; i < 14; i++)
        {
            flowerGreen[i].interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

        x = runde + 1;


        if (rnd==0 && player1==false)
        {
            Player.text = "An der Reihe: Player " + x;
        }
        if (rnd == 1 && player2 == false)
        {
            Player.text = "An der Reihe: Player " + x;
        }
        if (rnd == 2 && player3 == false)
        {
            Player.text = "An der Reihe: Player " + x;
        }
        if (rnd == 3 && player4 == false)
        {
            Player.text = "An der Reihe: Player " + x;
        }
    }

    public void NextPlayer()
    {
        for (int i = 0; i < 10; i++)
        {
            flowerBlue[i].interactable = false;
            //flowerGreen[i].interactable = false;
            flowerPink[i].interactable = false;
            flowerRed[i].interactable = false;
            flowerYellow[i].interactable = false;

        }
        for (int i = 0; i < 14; i++)
        {
            flowerGreen[i].interactable = false;
        }
        
        
        Player.text = "An der Reihe: Player " + x;
    }


    public void Wuerfel()
    {
        runde ++;
        count = 0;
        if (runde == 1)
        {
            player1 = true;
            player2 = false;
            player3 = false;
            player4 = false;
            Player.text = "An der Reihe: Player 1";
        }

        if (runde == 2)
        {
            player1 = false;
            player2 = true;
            player3 = false;
            player4 = false;
            Player.text = "An der Reihe: Player 2";
        }
        if (runde == 3)
        {
            player1 = false;
            player2 = false;
            player3 = true;
            player4 = false;
            Player.text = "An der Reihe: Player 3";
        }
        if (runde == 4)
        {
            player1 = false;
            player2 = false;
            player3 = false;
            player4 = true;
            Player.text = "An der Reihe: Player 4";
            runde = 0;
            
        }
        Debug.Log(runde);
        rnd = Random.Range(0, 6);
        if (rnd==0)
        {
            dice.color = Color.blue;
            if (player1 == true)
            {
                for (int i = 0; i < 10; i++)
                {
                    flowerBlue[i].interactable = true;
                    //flowerGreen[i].interactable = false;
                    flowerPink[i].interactable = false;
                    flowerRed[i].interactable = false;
                    flowerYellow[i].interactable = false;
                    
                }
            }
            if (player1 == false)
            {
                for (int i = 0; i < 10; i++)
                {
                    flowerBlue[i].interactable = false;
                    //flowerGreen[i].interactable = false;
                    flowerPink[i].interactable = false;
                    flowerRed[i].interactable = false;
                    flowerYellow[i].interactable = false;
                    
                }
               
            }
        }
        if (rnd == 1)
        {
            dice.color = Color.magenta;
            if (player2 == true)
            {
                for (int i = 0; i < 10; i++)
                {
                    flowerBlue[i].interactable = false;
                    //flowerGreen[i].interactable = false;
                    flowerPink[i].interactable = true;
                    flowerRed[i].interactable = false;
                    flowerYellow[i].interactable = false;
                    
                }
                for (int i = 0; i < 14; i++)
                {
                    flowerGreen[i].interactable = false;
                }
            }
            if (player2 == false)
            {
                for (int i = 0; i < 10; i++)
                {
                    flowerBlue[i].interactable = false;
                    //flowerGreen[i].interactable = false;
                    flowerPink[i].interactable = false;
                    flowerRed[i].interactable = false;
                    flowerYellow[i].interactable = false;
                    
                }
                for (int i = 0; i < 14; i++)
                {
                    flowerGreen[i].interactable = false;
                }

            }
        }
        if (rnd == 2)
        {
            dice.color = Color.red;
            if (player3 == true)
            {
                for (int i = 0; i < 10; i++)
                {
                    flowerBlue[i].interactable = false;
                    //flowerGreen[i].interactable = false;
                    flowerPink[i].interactable = false;
                    flowerRed[i].interactable = true;
                    flowerYellow[i].interactable = false;
                    
                }
                for (int i = 0; i < 14; i++)
                {
                    flowerGreen[i].interactable = false;
                }
            }
            if (player3 == false)
            {
                for (int i = 0; i < 10; i++)
                {
                    flowerBlue[i].interactable = false;
                    //flowerGreen[i].interactable = false;
                    flowerPink[i].interactable = false;
                    flowerRed[i].interactable = false;
                    flowerYellow[i].interactable = false;
                    
                }
                for (int i = 0; i < 14; i++)
                {
                    flowerGreen[i].interactable = false;
                }

            }
        }
        if (rnd == 3)
        {
            dice.color = Color.yellow;
            if (player4 == true)
            {
                for (int i = 0; i < 10; i++)
                {
                    flowerBlue[i].interactable = false;
                    //flowerGreen[i].interactable = false;
                    flowerPink[i].interactable = false;
                    flowerRed[i].interactable = false;
                    flowerYellow[i].interactable = true;
                    
                }
                for (int i = 0; i < 14; i++)
                {
                    flowerGreen[i].interactable = false;
                }
            }
            if (player4 == false)
            {
                for (int i = 0; i < 10; i++)
                {
                    flowerBlue[i].interactable = false;
                    //flowerGreen[i].interactable = false;
                    flowerPink[i].interactable = false;
                    flowerRed[i].interactable = false;
                    flowerYellow[i].interactable = false;
                    
                }
                for (int i = 0; i < 14; i++)
                {
                    flowerGreen[i].interactable = false;
                }

            }
        }
        if (rnd == 4)
        {
            dice.color = Color.green;
            
            
                for (int i = 0; i < 10; i++)
                {
                    flowerBlue[i].interactable = false;
                    //flowerGreen[i].interactable = true;
                    flowerPink[i].interactable = false;
                    flowerRed[i].interactable = false;
                    flowerYellow[i].interactable = false;
                    
                }
                for (int i = 0; i < 14; i++)
                {
                    flowerGreen[i].interactable = true;
                }
            
        }
        if (rnd == 5)
        {
            dice.color = Color.black;
           
            
                for (int i = 0; i < 10; i++)
                {
                    flowerBlue[i].interactable = false;
                    //flowerGreen[i].interactable = false;
                    flowerPink[i].interactable = false;
                    flowerRed[i].interactable = false;
                    flowerYellow[i].interactable = false;
                
                }
            for (int i = 0; i < 14; i++)
            {
                flowerGreen[i].interactable = false;
            }
            if (player1 == true && pickUpScript.score1 < 2)
            {
                Player.text = "An der Reihe: Player 2";
            }
            if (player1 == true && pickUpScript.score1>= 2)
            {
                pickUpScript.score1 = pickUpScript.score1 - 2;
                Player.text = "An der Reihe: Player 2";
                for (int i = 0; i < 10; i++)
                {
                    if (flowerBlue[i].IsActive() == false && count<2)
                    {
                        flowerBlueG[i].SetActive(true);
                        count++;

                    }
                }
            }
            if (player2 == true && pickUpScript.score2 < 2)
            {
                Player.text = "An der Reihe: Player 3";
            }
            if (player2 == true && pickUpScript.score2 >= 2)
            {
                pickUpScript.score2 = pickUpScript.score2 - 2;
                Player.text = "An der Reihe: Player 3";
                for (int i = 0; i < 10; i++)
                {
                    if (flowerPink[i].IsActive() == false && count < 2)
                    {
                        flowerPinkG[i].SetActive(true);
                        count++;

                    }
                }
            }
            if (player3 == true && pickUpScript.score3 < 2)
            {
                Player.text = "An der Reihe: Player 4";
            }
            if (player3 == true && pickUpScript.score3 >= 2)
            {
                pickUpScript.score3 = pickUpScript.score3 - 2;
                Player.text = "An der Reihe: Player 4";
                for (int i = 0; i < 10; i++)
                {
                    if (flowerRed[i].IsActive() == false && count < 2)
                    {
                        flowerRedG[i].SetActive(true);
                        count++;

                    }
                }
            }
            if (player4 == true && pickUpScript.score4 < 2)
            {
                Player.text = "An der Reihe: Player 1";
            }
            if (player4 == true && pickUpScript.score4 >= 2)
            {
                pickUpScript.score4 = pickUpScript.score4 - 2;
                Player.text = "An der Reihe: Player 1";
                for (int i = 0; i < 10; i++)
                {
                    if (flowerYellow[i].IsActive() == false && count < 2)
                    {
                        flowerYellowG[i].SetActive(true);
                        count++;

                    }
                }
            }

        }

    }
}
