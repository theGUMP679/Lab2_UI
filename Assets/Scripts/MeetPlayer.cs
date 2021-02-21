using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MeetPlayer : MonoBehaviour
{
    public InputField playerInput;
    public static string playerName;
    

   public void SetName ()
    {
        playerName = playerInput.text;
        Debug.Log("name of player is " + playerName);
        
    }

    public void StartGame ()
    {
        PlayerPrefs.SetString("ThisPlayer", playerName);
        SceneManager.LoadScene("ChangeAvatar");
      


    }
}
