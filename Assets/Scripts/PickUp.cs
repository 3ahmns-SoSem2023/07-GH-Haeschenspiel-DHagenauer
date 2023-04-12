using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PickUp : MonoBehaviour
{
    public Text scorPlayer1;
    public int score1;
    public Text scorPlayer2;
    public int score2;
    public Text scorPlayer3;
    public int score3;
    public Text scorPlayer4;
    public int score4;
    private Dice diceScript;

    public Button wuerfel;

    private int count1;
    // Start is called before the first frame update
    void Start()
    {
        diceScript = GetComponent<Dice>();
        wuerfel.interactable = true;
    }

    // Update is called once per frame
    void Update()
    {
        scorPlayer1.text = "Gepflückte Blumen: " + score1 + "/10";
        scorPlayer2.text = "Gepflückte Blumen: " + score2 + "/10";
        scorPlayer3.text = "Gepflückte Blumen: " + score3 + "/10";
        scorPlayer4.text = "Gepflückte Blumen: " + score4 + "/10";

        if (score1>=10)
        {
            scorPlayer1.text = "You won!!!";
            Invoke("LoadStartScene", 4);
            wuerfel.interactable = false;
        }
        if (score2 >= 10)
        {
            scorPlayer2.text = "You won!!!";
            Invoke("LoadStartScene", 4);
            wuerfel.interactable = false;
        }
        if (score3 >= 10)
        {
            scorPlayer3.text = "You won!!!";
            Invoke("LoadStartScene", 4);
            wuerfel.interactable = false;
        }
        if (score4 >= 10)
        {
            scorPlayer4.text = "You won!!!";
            Invoke("LoadStartScene", 4);
            wuerfel.interactable = false;
        }
    }
    void LoadStartScene()
    {
        SceneManager.LoadScene("Start");
    }
    public void pickBlue()
    {
        score1++;
        scorPlayer1.text = "Gepflückte Blumen: " + score1 + "/10";
        diceScript.NextPlayer();
    }
    public void pickPink()
    {
        score2++;
        scorPlayer2.text = "Gepflückte Blumen: " + score2 + "/10";
        diceScript.NextPlayer();
    }
    public void pickRed()
    {
        score3++;
        scorPlayer3.text = "Gepflückte Blumen: " + score3 + "/10";
        diceScript.NextPlayer();
    }
    public void pickYellow()
    {
        score4++;
        scorPlayer4.text = "Gepflückte Blumen: " + score4 + "/10";
        diceScript.NextPlayer();
    }

    public void PickGreen()
    {
        count1 = 0;
        if (diceScript.player1==true)
        {
            score1 +=2;
            scorPlayer1.text = "Gepflückte Blumen: " + score1 + "/10";
            for (int i = 0; i < 10; i++)
            {
                if (diceScript.flowerBlue[i].IsActive() == true && count1 < 2)
                {
                    diceScript.flowerBlueG[i].SetActive(false);
                    count1++;
                }
            }
            diceScript.NextPlayer();
           
            
        }
        if (diceScript.player2 == true)
        {
            score2 += 2;
            scorPlayer2.text = "Gepflückte Blumen: " + score2 + "/10";
            for (int i = 0; i < 10; i++)
            {
                if (diceScript.flowerPink[i].IsActive() == true && count1 < 2)
                {
                    diceScript.flowerPinkG[i].SetActive(false);
                    count1++;
                }
            }
            diceScript.NextPlayer();

        }
        if (diceScript.player3 == true)
        {
            score3 += 2;
            scorPlayer3.text = "Gepflückte Blumen: " + score3 + "/10";
            for (int i = 0; i < 10; i++)
            {
                if (diceScript.flowerRed[i].IsActive() == true && count1 < 2)
                {
                    diceScript.flowerRedG[i].SetActive(false);
                    count1++;
                }
            }
            diceScript.NextPlayer();
        }
        if (diceScript.player4 == true)
        {
            score4 += 2;
            scorPlayer4.text = "Gepflückte Blumen: " + score4 + "/10";
            for (int i = 0; i < 10; i++)
            {
                if (diceScript.flowerYellow[i].IsActive() == true && count1 < 2)
                {
                    diceScript.flowerYellowG[i].SetActive(false);
                    count1++;
                }
            }
            diceScript.NextPlayer();
        }
    }
}
