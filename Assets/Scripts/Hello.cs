using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Hello : MonoBehaviour
{

    
   //float score = 100f;
    
    void Start()
    {   
        #region Day1
            
        
        // Day 1

        //if else 
        //   score  = 5 + 10;
        //   Debug.Log("Addition : " + score);

        //   score = 5-10;
        //   Debug.Log("Substraction : " + score);

        //   score = 5 * 10;
        //   Debug.Log("Multiplication : " + score);

        //   score = 5f / 10f ; 
        //   Debug.Log("Divide : " + score);

        //   score =  5 % 10;  
        //   Debug.Log("Reminder : "+ score);

        // if (5 != 10 && 10 > 5)
        // {
        //     Debug.Log("Statement is True");
        // }
        // else
        // {
        //     Debug.Log("Statement is False");
        // }


        // float price = 100;
        // float coin_price = 75;

        // if (price >= coin_price)
        // {
        //     Debug.Log("Purchased Successfull !!!");

        //     price -= coin_price; 
        // }
        // else
        // {
        //     Debug.Log("Insuficient Balance ");
        // }


        // int gun_index = 0;

        // if (gun_index == 0)
        // {
        //     Debug.Log("Pistol is fired !");
        // }
        // else if (gun_index == 1)
        // {
        //     Debug.Log("Rifle is fired !");
        // }
        // else if (gun_index == 2)
        // {
        //     Debug.Log("Shotgun is fired !");
        // }
        // else
        // {
        //     Debug.Log("No Gun is selected !");
        // }

        // Switch Case
        // int gun_index = 0;

        // switch (gun_index)
        // {
        //     case 0:
        //         Debug.Log("Pistol is fired !");
        //         break;
        //     case 1:
        //         Debug.Log("Rifle is fired !");
        //         break;  
        //     case 2:
        //         Debug.Log("Shotgun is fired !");
        //         break;
        // }


        // Practice Example
        // int Player_coin = 5000;
        // int Player_level = 20;

        // int sword = 100;
        // int shield = 150;
        // int health_potion = 50;

        // if (Player_coin >= sword)
        // {

        //     Player_coin -= sword;
        //     Debug.Log("Sword Purchased !!!");
        // }
        // else 
        // {
        //     Debug.Log("Insufficient coin !");

        // }
        
        // if (Player_coin >= health_potion )
        // {

        //     Player_coin -= health_potion;
        //     Debug.Log("health potion purchased");

        // }
        // else
        // {
        //     Debug.Log("Not sufficient coin !");

        // }

        // if (Player_level < 5)
        // {
        //     Debug.Log(" Insufficient Player level");
        // }
        // else if (Player_coin >= shield)
        // {
        //     Debug.Log("Shield purchased Successfully !!");
        // }
        // else
        // {
            
        //     Debug.Log("Insufficient Coin !");
        // }


        // For loop 
        // int counter = 0 ;

        // for (int i = 10; i > 0; i--)
        // {
        //     counter++ ;
        //     Debug.Log("counter : " +  i);
        // }

        // while loop
        // int whilecounter = 0;

        // while (whilecounter < 25)
        // {
        //     whilecounter += 5 ;
        //     Debug.Log("While Counter : "+ whilecounter);




        //Array 

        //int [] studentArray  = new int[10]{1,2,3,4,5,6,7,8,9,90};
        // Debug.Log(studentArray[5]);

        // studentArray[5] = 5;
        // Debug.Log(studentArray[5]);

        //List  

        //List<int> StudentList = new List<int>();

        // StudentList.Add(10);
        // StudentList.Add(20);
        // StudentList.Add(30);
        // StudentList.Add(40);

        // Debug.Log(StudentList[0] + "  0th Value ");
    
        // Debug.Log(StudentList[1] + "  2nd Value ");

        // // StudentList.Remove(20);


        // Debug.Log(StudentList.Count + "List count ");   

        // Foreach
        // foreach (int element in StudentList)
        // {
        //     Debug.Log(element + "  list Elemet");
        // }

        // foreach (var i in studentArray)
        // {
        //     Debug.Log(i + "Array");
        // }

        // }
         #endregion   

    //MyFirstMethod();
    //MySecondMethod(5,15);
//    int result =  MyThirdMetod(10,15);
//     Debug.Log("Third Method  : "+result);

        myFourthMethod(10,20);
        Debug.Log("Two Digit Method : " +someOfTwoDigits);

        myFourthMethod(10,20,30);
        Debug.Log("Three digit method : "+ someOfTwoDigits);
}
        //Day 2 

        // Function and Methods 

    //     public void MyFirstMethod()
    // {
    //     Debug.Log("Method 1st is working");
    // }

    // public void MySecondMethod(int a , int b)
    // {
    //     int sum = a+b;
    //     Debug.Log("Addition is : "+sum);
    // }

    // public int MyThirdMetod(int a ,int b)
    // {
    //     int sum = a + b;
    //     return sum ;
    // }

    int someOfTwoDigits = 0;
    public void myFourthMethod(int a , int b)
    {
        someOfTwoDigits= a + b;

    }

    
    public void myFourthMethod(int a , int b, int c)
    {
        someOfTwoDigits= a + b + c;
  
    }

}