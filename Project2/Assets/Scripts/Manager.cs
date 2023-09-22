using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    [SerializeField] private GameObject main;
    public static Manager Instance { get; private set; }
    

    private void Start()
    {
        Instantiate(main);
        Init();
    }

    void Init()
    {
        if (Instance == null)
        {
            //@Managers �� �����ϴ��� Ȯ��
            GameObject go = GameObject.Find("Manager");
            //������ ����
            if (go == null)
            {
                go = new GameObject { name = "Manager" };
            }
            if (go.GetComponent<Manager>() == null)
            {
                go.AddComponent<Manager>();
            }
            //�������� �ʵ��� ����
            DontDestroyOnLoad(go);
            //instance �Ҵ�
            Instance = go.GetComponent<Manager>();
        }
    }
}