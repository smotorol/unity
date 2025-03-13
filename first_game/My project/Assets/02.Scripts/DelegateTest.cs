using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateTest : MonoBehaviour
{
    delegate void CalNumDelegate(int num);

    CalNumDelegate calNum;
    // Start is called before the first frame update
    void Start()
    {
        calNum = OnePlusNum;

        calNum(4);

        calNum = PowerNum;
        calNum(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnePlusNum(int num)
    {
        int result = num + 1;
        Debug.Log("One Plus =" + result);
    }

    void PowerNum(int num)
    {
        int result = num * num;
        Debug.Log("Power = "+ result);
    }
}
