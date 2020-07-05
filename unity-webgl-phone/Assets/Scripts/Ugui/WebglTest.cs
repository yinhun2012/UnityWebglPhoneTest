using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebglTest : MonoBehaviour
{
    public Button buttonUgui;
    public Text textUgui;

    public Dropdown dropdownUgui;
    public Text textDropdown;

    public Button buttonSound;
    public Button buttonDirection;

    public Button buttonLand;
    public Button buttonJump;

    public CharacterCtrl charaCtrl;
    public SoundCtrl soundCtrl;

    void Start()
    {
        buttonUgui.onClick.AddListener(() =>
        {

            textUgui.text = string.Format("click time = {0}", Time.time);
        });

        dropdownUgui.onValueChanged.AddListener((int index) =>
        {
            textDropdown.text = string.Format("drop index = {0}", index);
        });

        buttonSound.onClick.AddListener(() =>
        {
            soundCtrl.Play();
        });

        buttonDirection.onClick.AddListener(() =>
        {
            if (Screen.orientation == ScreenOrientation.Portrait)
            {
                Screen.orientation = ScreenOrientation.LandscapeLeft;
            }
            else if (Screen.orientation == ScreenOrientation.LandscapeLeft)
            {
                Screen.orientation = ScreenOrientation.Portrait;
            }
        });

        buttonLand.onClick.AddListener(() =>
        {
            charaCtrl.Land();
        });

        buttonJump.onClick.AddListener(() =>
        {
            charaCtrl.Jump();
        });
    }

}
