using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBManager : MonoBehaviour
{
    public static string username;
    public static string classname;
    public static int score;
    public static int score1;
    public static int score2;
    public static int score3;
    public static int score4;
    public static int coins;
    public static int diamands;
    public static int coins2;
    public static int diamands2;
    public static int stars2;
     public static int coins3;
    public static int diamands3;
    public static int stars3;
     public static int coins4;
    public static int diamands4;
    public static int stars4;
    public static float x;
    public static float y;
    public static float z;
    public static float x2;
    public static float y2;
    public static float z2;
     public static float x3;
    public static float y3;
    public static float z3;
     public static float x4;
    public static float y4;
    public static float z4;
    public static int level;
    public static int the_level;
    public static int health;
    public static int health2;
    public static int health3;
    public static int health4;
    public static float time;
    public static float time1;
    public static float time2;
    public static float time3;
    public static int addition1;
    public static int substraction1;
    public static int multiplication1;
    public static int division1;
    public static int addition2;
    public static int substraction2;
    public static int multiplication2;
    public static int division2;
    public static string dropdownvalue;
    public static int dropdownvalue2;
    public static bool LoggedIn{ get { return username != null; }}

    public static void LogOut()
    {
        username=null;
    }

    
     
    

}
