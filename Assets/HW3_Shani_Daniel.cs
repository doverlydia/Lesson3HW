using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW3_Shani_Daniel : MonoBehaviour
{

    void Start()
    {
    // bad naming. this doesnt tell me what the method do
        method1(25);
        method2(2);
        method2(7);
        method3(0);
        method3(-1);

    }

// shold call it DivideByHaldAddSeven();
    public static void method1(int number)
    {
        int result = number / 2 + 7;
        Debug.Log(result);
    }
// shold call it IsBiggerThanFive();
    public static void method2(int number)
    {
        if (number < 5){
            Debug.Log($"The number {number} is smaller than 5");
        }
        else
        {
            Debug.Log($"The number {number} is bigger than 5");
        }
    }
// shold call it ValidateNumber();
    public static void method3(int number)
    {
        switch (number)
        {
            case 0:
                Debug.Log($"The number {number} is invalid");
                break;
            case 1:
                Debug.Log($"The number {number} is positive!");
                break;
            case -1:
                Debug.Log($"The number {number} is negative!");
                break;
            default:
                Debug.Log($"The number {number} is fine.");
                break;
        }
    }





}
