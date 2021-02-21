using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class showOnTwo : MonoBehaviour
{

    public Text pName;


    void Start()
    {
        pName.text = MeetPlayer.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
