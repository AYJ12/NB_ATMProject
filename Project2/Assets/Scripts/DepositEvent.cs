using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.EventSystems;

public class DepositEvent : MonoBehaviour
{
    [SerializeField] private Text nameText;
    [SerializeField] private Text balance;
    [SerializeField] private Text cash;
    [SerializeField] private InputField inputField;
    [SerializeField] private GameObject mainUI;
    [SerializeField] private GameObject thisUI;
    [SerializeField] private GameObject panel;

    private void Start()
    {
        nameText.text = DataManager.Instance.s_name;
        balance.text = DataManager.Instance.s_balance.ToString();
        cash.text = DataManager.Instance.s_cash.ToString();
    }

    public void OnClickDepositEvent()
    {
        GameObject clickObject = EventSystem.current.currentSelectedGameObject;
        string str = (clickObject.GetComponentInChildren<Text>().text).Replace(",","");
        if (str.All(char.IsDigit))
        {
            int changeCash = int.Parse(str);
            if (int.Parse(cash.text) > changeCash)
            {
                cash.text = (int.Parse(cash.text) - changeCash).ToString();
                DataManager.Instance.s_cash -= changeCash; 
                balance.text = (int.Parse(balance.text) + changeCash).ToString();
                DataManager.Instance.s_balance += changeCash;
            }
            else
            {
                Instantiate(panel);
            }
        }
        else
        {
            int changeCash = int.Parse(inputField.text);
            if (int.Parse(cash.text) > changeCash)
            {
                cash.text = (int.Parse(cash.text) - changeCash).ToString();
                DataManager.Instance.s_cash -= changeCash;
                balance.text = (int.Parse(balance.text) + changeCash).ToString();
                DataManager.Instance.s_balance += changeCash;
            }
            else
            {
                Instantiate(panel);
            }
        }
    }

    public void OnClickMainUIEvent()
    {
        Destroy(gameObject);
        Destroy(thisUI);
        Instantiate(mainUI);
    }
}
