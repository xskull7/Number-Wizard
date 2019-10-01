using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberwizard : MonoBehaviour {
    [SerializeField] int max;
    [SerializeField] int min;
    int gusse;

    // Use this for initialization
    void Start () {

        StartGame();
	}
	 void StartGame()
    {
        Debug.Log("welcome to number wizard");
        Debug.Log("Pick a number and dont tell me");
        Debug.Log("highest number you can take is ->" + max);
        Debug.Log("Lowest number you can take is ->" + min);
        Debug.Log("Tell me that your number is higher or lower than" + gusse);
        Debug.Log("push up=higher   push down = lower    enter = correct ");
        max = max + 1;
    }
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            min = gusse;
            NextGuess();

        }
     else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            
            max = gusse;
            NextGuess();
        }
       else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Gocha !!!! I am a Genius");
        }
    }
    void NextGuess()
    {
        gusse = (max + min) / 2;
        Debug.Log(" is it higher or lower then ..." + gusse);
    }
}
