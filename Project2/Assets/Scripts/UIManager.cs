using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject main;
    public static Manager Instance { get; private set; }


    private void Start()
    {
        Init();
    }

    void Init()
    {
        if (Instance == null)
        {
            //@Managers 가 존재하는지 확인
            GameObject go = GameObject.Find("Manager");
            //없으면 생성
            if (go == null)
            {
                go = new GameObject { name = "Manager" };
            }
            if (go.GetComponent<Manager>() == null)
            {
                go.AddComponent<Manager>();

            }
            //없어지지 않도록 해줌
            DontDestroyOnLoad(go);
            //instance 할당
            Instance = go.GetComponent<Manager>();
        }
    }

    //public void OnLoginUI()
    //{
    //   // main = Instantiate("");
    //}

    //public void OnMainUI()
    //{
    //    Instantiate(main);
    //}


}
