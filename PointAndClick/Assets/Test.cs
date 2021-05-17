using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private int Carpan = 3;
    private void Start()
    {
        Debug.Log(AtisHizi);
        AtisHizi = 5;
    }
    public int AtisHizi
    {

        get
        {
            return Carpan;
        }
        set
        {
            Carpan = value;
            test2();
        }
    }
    void test2()
    {
        Debug.Log(AtisHizi);
    }
}
