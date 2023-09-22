using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogInUIButtonEvent : MonoBehaviour
{
    [SerializeField] private InputField loginField;
    [SerializeField] private InputField passwordField;
    [SerializeField] private GameObject signUpPanel;
    [SerializeField] private GameObject mainUI;
    [SerializeField] private GameObject logInUI;

    public void OnClickLogin()
    {
        if(PlayerPrefs.HasKey("PASS").ToString() == passwordField.text)
        {
            Destroy(logInUI);
            Instantiate(mainUI);
        }
    }

    public void OnClickSignUp()
    {
        Instantiate(signUpPanel);
    }
}
