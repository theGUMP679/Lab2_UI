using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour
{
    public string playerName2;
    public CanvasGroup StatsScreen;
    public Text tellPlayer;
    public Slider EyeProPick;
    public Slider HeadGearPick;
    public Slider FaceMaskPick;
    public Button Button;

    public Image Eyes;
    public Image Head;
    public Image Face;

    public Sprite glasses1;
    public Sprite glasses2;
    public Sprite glasses3;
    public Sprite head1;
    public Sprite head2;
    public Sprite head3;
    public Sprite mask1;
    public Sprite mask2;
    public Sprite mask3;

    // Start is called before the first frame update
   public void changeEyePro ()
    {
        float newEyeProValue = EyeProPick.value;
        if (newEyeProValue == 0)
        {
            Eyes.sprite = glasses1;

        }
        else if (newEyeProValue == 1)
        {
            Eyes.sprite = glasses2;

        }
        else if (newEyeProValue == 2)
        {
            Eyes.sprite = glasses3;
        }
    }
    public void changeHeadGear()
    {
        float newHeadGearValue = HeadGearPick.value;
        if (newHeadGearValue == 0)
        {
            Head.sprite = head1;

        }
        else if (newHeadGearValue == 1)
        {
            Head.sprite = head2;

        }
        else if (newHeadGearValue == 2)
        {
            Head.sprite = head3;
        }
    }
    public void changeFaceMask ()
    {
        float newFaceMaskValue = FaceMaskPick.value;
        if (newFaceMaskValue == 0)
        {
            Face.sprite = mask1;

        }
        else if (newFaceMaskValue == 1)
        {
            Face.sprite = mask2;

        }
        else if (newFaceMaskValue == 2)
        {
            Face.sprite = mask3;
        }
    }

    public void quitGame ()
    {
        StatsScreen.alpha = 0f;
        StatsScreen.interactable = false;
        StatsScreen.blocksRaycasts = false;
    }


}
