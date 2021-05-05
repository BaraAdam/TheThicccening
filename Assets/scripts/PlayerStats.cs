using System.Collections;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney = 400;

    public static int Lives;
    public int startlives = 20;

    public static int Rounds;

    void Start ()
    {
        Money = startMoney;
        Lives = startlives;

        Rounds = 0;
    }
}
