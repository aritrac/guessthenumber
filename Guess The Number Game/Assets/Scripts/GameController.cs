using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    private int num;

    private int countGuess;

    [SerializeField]
    private GameObject btn;

    [SerializeField]
    private InputField input;

    [SerializeField]
    private Text text;

    private void Awake()
    {
        //input = GameObject.Find("InputField").GetComponent<InputField>();

        num = Random.Range(0,100);
        text.text = "Guess A Number Between 0 And 100";

    }

    public void GetInput(string guess)
    {
        CompareGuesses(int.Parse(guess));
        //Debug.Log("You Entered " + guess);
        input.text = "";
        countGuess++;
    }

    void CompareGuesses(int guess)
    {
        if(guess == num)
        {
            text.text = "You Guessed Correctly. The Number Was " + guess + " It Took You " + countGuess + " Guess(es), Do You Want To Play Again?";
            btn.SetActive(true);
        }else if(guess < num)
        {
            text.text = "Your Guess Number Is Less Than The Number You Are Trying To Guess";
        }else if(guess > num)
        {
            text.text = "Your Guess Number Is More Than The Number You Are Trying To Guess";
        }
    }

    public void PlayAgain()
    {
        num = Random.Range(0, 100);
        text.text = "Guess A Number Between 0 And 100";
        countGuess = 0;
        btn.SetActive(false);
    }
}
