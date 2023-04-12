using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public Button startButton;
    public InputField player_1;
    public InputField player_2;
    public InputField player_3;
    public InputField player_4;

    public Text field1;
    public Text field2;
    public Text field3;
    public Text field4;

    private int alter1;
    private int alter2;
    private int alter3;
    private int alter4;
    // Start is called before the first frame update
    void Start()
    {
        startButton.interactable = false;   
    }

    // Update is called once per frame
    void Update()
    {
        alter1 = int.Parse(player_1.text);
        alter2 = int.Parse(player_2.text);
        alter3 = int.Parse(player_3.text);
        alter4 = int.Parse(player_4.text);

        if (alter1>alter2&&alter1>alter3&&alter1>alter4)
        {
            field1.text = "Player 1 (BLUE)";
            field2.text = "Player 2 (PINK)";
            field3.text = "Player 3 (RED)";
            field4.text = "Player 4 (YELLOW)";
        }
        if (alter2 > alter1 && alter2 > alter3 && alter2 > alter4)
        {
            field1.text = "Player 4 (BLUE)";
            field2.text = "Player 1 (PINK)";
            field3.text = "Player 2 (RED)";
            field4.text = "Player 3 (YELLOW)";
        }
        if (alter3 > alter2 && alter3 > alter1 && alter3 > alter4)
        {
            field1.text = "Player 3 (BLUE)";
            field2.text = "Player 4 (PINK)";
            field3.text = "Player 1 (RED)";
            field4.text = "Player 2 (YELLOW)";
        }
        if (alter4 > alter2 && alter4 > alter3 && alter4 > alter1)
        {
            field1.text = "Player 2 (BLUE)";
            field2.text = "Player 3 (PINK)";
            field3.text = "Player 4 (RED)";
            field4.text = "Player 1 (YELLOW)";
        }
        if (alter1!=0&& alter2 != 0 && alter3 != 0 && alter4 != 0 )
        {
            startButton.interactable = true;
        }
        else
        {
            startButton.interactable = false;
        }
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("Main");
    }
}
