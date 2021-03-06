﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextController : MonoBehaviour
{

    public Text text;

    private enum States {bedroom, bathroom, shower, furnish, bathroom_2, wardrobe, nursery};
    private States myState;

    // Use this for initialization
    void Start()
    {
        myState = States.bedroom;
    }

    // Update is called once per frame
    void Update()
    {
        print(myState);
        if (myState == States.bedroom)
        {
            State_bedroom();
        }
        else if (myState == States.bathroom)
        {
            State_bathroom();
        }
        else if (myState == States.furnish)
        {
            State_furnish();
        }
        else if (myState == States.shower)
        {
            State_shower();
        }
        else if (myState == States.bathroom_2)
        {
            State_bathroom_2();
        }
        else if (myState == States.wardrobe)
        {
            State_wardrobe();
        }
        else if (myState == States.nursery)
        {
            State_nursery();
        }
    }

    void State_bedroom()
    {
        text.text = "The sun slowly rises over the Hothersall estate, nestled sweetly in the arms of the Lancashire hills. " +
                    "The hour is yet early and Lord Hothersall rests soundly for a single precious hour after having been woken throughout the night " +
                    "by the harsh battering of Pendletons finely polished Oxford dress shoes making the ascent to attend to Master Elijah." +
                    "Disgruntled he rises to prepare for the day ahead.\n\n" +
                    "After calling for Pendleton to dress him in his velvet dressing gown, he slides on his slippers which are of course embroidered\n\n" +
                    "with the silk from an endangered field worm he'd hunted himself in the rice paddies of Bali, armed with nothing but a brittle branch he had" +
                    "fasioned into a less than effective peasant beating stick, and a sturdy british vigour.\n\n" +
                    "B - Enter the ensuite marble furnished bathroom \n\n" +
                    "W - Look in the 17th century Venetian wardrobe";
        if (Input.GetKeyDown(KeyCode.B))
        {
            myState = States.bathroom;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.wardrobe;
        }
    }

    void State_bathroom()
    {
        text.text = "He wanderes into the bathroom, enjoying the softness of the Croatian mongoose carpet he'd had flown in 1st class last payday.\n\n" +
                    //bathroom_1
                    "A - Admire the fine furnishings\n\n" +
                    //bathroom_2
                    "S - Take a shower\n\n" +
                    "R - Return to bedroom\n\n" +
                    "W - Go to wardrobe";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.bedroom;
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.furnish;
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.bathroom_2;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.wardrobe;
        }
    }

    void State_furnish()
    {
        text.text = "Lord Hothersall looks around in awe at the technological marvels that make up his bathroom. He starts to feel nostalgia for the fonder times " +
                    "when this sort of functionality wasn't available in a water closet.\n\n" +
                    "D - Done";

        if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.bathroom_2;
        }
    }

    void State_shower()
    {
        text.text = "Lord Hothersall calls in Pendleton to undress him. Pendleton shys away at the sight of his strangely furry ass and something that" +
                    "looks like a penis but smaller. He leaves and puts Beethovens symphony No3 on the gramaphone as is always his masters request.\n\n"+
                    "D - Done";

        if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.bathroom_2;
        }
    }

    void State_bathroom_2()
    {
        text.text = "He admires his lordly prowess while singing the national anthem.\n\n" +
                    "A - Admire Furnishings\n\n" +
                    "S - Take a shower\n\n" +
                    "W - Go to wardrobe"; //Next Level From Here

        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.furnish;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.shower;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.wardrobe;
        }
    }

    void State_wardrobe()
    {
        text.text = "Pendleton opens the door to the large wardrobe filled with tuxedos, tweed and walking boots. " +
                    "Master Elijah cries from the nursery.\n\n" +
                    "\"No Pendleton, I will go old boy,\"\n" +
                    "\"As you wish Sir\"\n\n" +
                    "He made his way to the nursery for it was almost 9 and time for Master Elijah's tutelage. Today he will be learning the complexities behind " +
                    "the idetification of subjects that posess a lack of AI\n\n\n" +
                    "B - Go to bathroom\n\n" +
                    "N - Enter nursery";

        if (Input.GetKeyDown(KeyCode.B))
        {
            myState = States.bathroom;
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            myState = States.nursery;
        }
    }

    void State_nursery()
    {
        text.text = "As Lord Hoth enters the nursery, he see one of the peasants sneaking out of the window after stealing some dolphin ribeyes from the pantry.\n\n" +
                    "C - Chase the wretched little blighter. Follow him out of the window\n\n" +
                    "G - Run to the gun cabinet and retreive your trusty musket\n\n";
    }
}