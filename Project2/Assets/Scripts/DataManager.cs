using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DataManager : MonoBehaviour
{
    public static DataManager Instance { get; private set; }

    public Dictionary<string, string> memberDictionary = new Dictionary<string, string>();
    public int s_balance;
    public int s_cash;
    public string s_name;


    private void Start()
    {
        memberDictionary.Add("test","test");
        s_balance = 50000;
        s_cash = 100000;
        Init();
    }

    void Init()
    {
        if (Instance == null)
        {
            GameObject go = GameObject.Find("DataManager");
            //������ ����
            if (go == null)
            {
                go = new GameObject { name = "DataManager" };
            }
            if (go.GetComponent<DataManager>() == null)
            {
                go.AddComponent<DataManager>();
            }
            //�������� �ʵ��� ����
            DontDestroyOnLoad(go);
            //instance �Ҵ�
            Instance = go.GetComponent<DataManager>();
        }
    }

    public void NewMember(string id, string pass)
    {
        memberDictionary.Add(id, pass);
    }
}

    
