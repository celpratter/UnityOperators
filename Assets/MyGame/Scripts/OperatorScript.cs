using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // Declare Variables
        int tree;
        int flower;
        string one;
        string two;
        string three;

        // Assign a Value
        tree = 1;
        flower = 3;
        one = "welcome";
        two = "to";
        three = "unity";



        //  Multiplikative Operatoren
        Debug.Log(4 * 4);
        Debug.Log(36 / 4);
        Debug.Log(7 % 2);

        // Additive Operatoren
        Debug.Log(1 + 1);
        Debug.Log(100 - 1);

        // Relationale Operatoren
        Debug.Log(2 < 3);
        Debug.Log(2 <= 2);
        Debug.Log(28637 > 28638);
        Debug.Log(28637 >= 28638);

        Debug.Log(flower == tree);

        // Gleichheits Operatoren
        Debug.Log(3 == 3);
        Debug.Log(3 == 4);
        Debug.Log(2 != 2);
        Debug.Log(2 != 3);

        Debug.Log(tree == 1);

        //Logische Operatoren
        Debug.Log(3 > 2 & 1 < 2);

        // String Concatination
        Debug.Log("Hello" + " " + "Unity");

        Debug.Log(one + " " + two + " " + three);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
