using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day2 : MonoBehaviour
{
    string heroname = " superman ";
    int heropower = 200;
    //
    string villainname = " shadow ";
    int villainpower = 150;
    float playerspeed = 2.7f;


    // Start is called before the first frame update
    void Start()
    {
        if (heropower >= villainpower)
        {
            print(" heropower stronger than villainpower ");
        }
        else if (heropower < villainpower )
        {
            print("villainpower is powerfull heropower");
        }
        else
        {
            print(" heropower equal villainpower ");
        }

        print(playerspeed);
        setspeed(2.5f);
        comparespeed(1 , 2);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void setspeed(float speed)
    {
        playerspeed = speed;
    }

    void comparespeed(float speed1 , float speed2 )
    {
        if (speed1 > speed2)
        {
            print(speed1);
        }
        else if (speed1 < speed2) 
        {
            print(speed2);
        }

        else if (speed1 == speed2)
        {
            print(speed1 + speed2);
        }
    }

}
