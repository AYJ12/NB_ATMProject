using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class SignUp : MonoBehaviour
{
    [SerializeField] private InputField idField;
    [SerializeField] private InputField nameField;
    [SerializeField] private InputField passField;
    [SerializeField] private InputField passConfirmField;
    [SerializeField] private GameObject signUpError;

    public void OnClickSignUpCheck()
    {
        if(PlayerPrefs.HasKey(idField.text))
        {
            Instantiate(signUpError);
        }
        
        if((idField.text.Length >= 3 && idField.text.Length <= 10) && 
            (nameField.text.Length >= 2 && nameField.text.Length <= 5) &&
            (passField.text.Length >= 5 && passField.text.Length <= 15) &&
            (passField.text == passConfirmField.text))
        {
            PlayerPrefs.SetString("ID",idField.text);
            PlayerPrefs.SetString("Name",nameField.text);
            PlayerPrefs.SetString("PASS", passField.text);
            PlayerPrefs.Save();
        }    
    }

    public void OnClickCancle()
    {
        Destroy(signUpError);
    }
}
