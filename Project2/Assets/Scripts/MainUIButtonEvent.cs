using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIButtonEvent : MonoBehaviour
{
    [SerializeField] private GameObject mainUI;
    [SerializeField] private GameObject depositUI;
    [SerializeField] private GameObject withdrawUI;
    [SerializeField] private Text balanceText;
    [SerializeField] private Text cashText;
    [SerializeField] private Text nameText;

    private void Start()
    {
        nameText.text = DataManager.Instance.s_name;
        balanceText.text = DataManager.Instance.s_balance.ToString();
        cashText.text = DataManager.Instance.s_cash.ToString();
    }


    public void OnClickDepositUI()
    {
        Destroy(mainUI);
        Instantiate(depositUI);
    }

    public void OnClickWithdrawUI()
    {
        Destroy(mainUI);
        Instantiate(withdrawUI);
    }
}
