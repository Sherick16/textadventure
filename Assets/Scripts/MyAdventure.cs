using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {
        ShowMainMenu ();
    }
    void ShowMainMenu () {
        Terminal.ClearScreen ();
        Terminal.WriteLine ("Welcome to HorrorNite");
        Terminal.WriteLine ("This is based on a true story");
        Terminal.WriteLine ("Type 'start' to begin");
    }
    void OnUserInput (string input) { //schuur bellen
        switch (input) {
            case "start": //stap 1
                StartIntro ();
                break;
            case "continue": //stap 2
                ContinueHi ();
                break;
            case "bathroom": //stap 3 
                BathroomHi ();
                break;
            case "diningroom": //stap 3.x
                DiningroomHi ();
                break;
            case "room": //stap 4.10
                RoomHi ();
                break;
            case "frontdoor": //stap 4
                FrontdoorHi ();
                break;
            case "shed": //stap 5
                ShedHi ();
                break;
            case "house": //stap 6
                HouseHi ();
                break;
            case "room2": //stap 7
                Room2Hi ();
                break;
            case "end": //stap 8
                EndHi ();
                break;
            case "room1": //stap 5.1
                Room1Hi ();
                break;
            case "stay": //stap 6.1
                StayHi ();
                break;
            case "stay1": //stap 
                Stay1Hi ();
                break;
            case "room3": //stap 
                Room3Hi ();
                break;
            case "yes": //stap 
                YesHi ();
                break;
            case "no": //stap 
                NoHi ();
                break;
        }
    }
    void Write (string tekst) {
        Terminal.WriteLine (tekst);
    }
    void StartIntro () { //stap 1
        Write ("Once upon a time there was a little girl called Karen Anderson.");
        Write ("This is the story about how she got brutally murdered.");
        Write ("Are you ready to find out?.");
        Write ("Type 'continue' to move on to the next fragment.");
    }
    void ContinueHi () { //stap 2
        Write ("I was home alone.");
        Write ("The lights started flashing.");
        Write ("I didn't know where to go.");
        Write ("Type 'bathroom' or 'diningroom'.");
    }
    void BathroomHi () { //stap 3
        Write ("I saw a silhoutte on the wall infront of me.");
        Write ("When I turned around there was no one behind me.");
        Write ("I felt like I had to get out of there.");
        Write ("Type 'room' to return.");
        Write ("Type 'frontdoor' to get out of there.");
    }
    void FrontdoorHi () { //stap 4
        Write ("As I got to the front door I noticed that the lock was missing.");
        Write ("At the same time the lights stopped flickering.");
        Write ("It's too dark to see.");
        Write ("Type 'shed' to hide in the shed.");
        Write ("Type 'room1' to hide in your room.");
    }
    void ShedHi () { //stap 5
        Write ("After I got to the shed I started searching for my flashlight.");
        Write ("Once I found my flashlight I just hid in a corner.");
        Write ("Should I go back into the house?");
        Write ("Type 'house' or 'stay'.");
    }
    void HouseHi () { //stap 6
        Write ("I managed to make my way back to the house.");
        Write ("I need help.");
        Write ("Should I go get my phone?.");
        Write ("Type 'room2' to get your phone or type 'stay1' to stay in the dining room.");
    }
    void Room2Hi () { //stap 7
        Write ("As I look at the corner of the room I see a little girl sitting there.");
        Write ("I ask who she is before she lunges at me.");
        Write ("The world around me becomes black.");
        Write ("Type 'end'.");
    }
    void EndHi () { //stap 8
        Write ("Karen passed away on the 24th of February in 1997.");
        Write ("Its said that she still haunts that house to this day.");
        Write ("The end.");
    }
    void RoomHi () { //stap 3.x
        Write ("I notice that the window is open.");
        Write ("Should I close it?.");
        Write ("Type 'yes' or 'no'.");
    }
    void Room1Hi () { // stap 4.1
        Write ("The lights are off.");
        Write ("I don't know what to do.");
        Write ("Should I stay in my room or hide in the shed?.");
        Write ("Type 'room3' to stay in room or 'shed' to go hide in the shed.");
    }
    void Room3Hi () { // stap 5.1
        Write ("I tried to sleep since I was too scared to do anything.");
        Write ("I couldn't sleep though, what should I do?.");
        Write ("Type 'shed' to hide in shed or 'room2' to stay in the room.");
    }
    void YesHi () { // stap 6.1
        Write ("As I close the window I can't help but feel sad.");
        Write ("The wind felt good...");
        Write ("What should I do?.");
        Write ("Type 'room1' to stay or type 'frontdoor' to get out of there.");
    }
    void NoHi () { // stap
        Write ("I feel the wind running through my hair.");
        Write ("What should I do?.");
        Write ("Type 'room1' to stay or type 'frontdoor' to get out of there.");
    }
    void DiningroomHi () { // stap
        Write ("I see some fruits on the table, but I'm not hungry.");
        Write ("I can't help but feel like someone's starting at me.");
        Write ("Type 'room' to go back to your room or type 'frontdoor' to get out of there.");
    }
        void StayHi () { //stap 5
        Write ("I've been hiding for a solid 10 minutes now.");
        Write ("I'm getting cold and dehydrated.");
        Write ("I need to go back to the house before I freeze to death.");
        Write ("Type 'house' to continue.");
    }
    void Stay1Hi () { //stap 6
        Write ("I decided to get a drink out of the fridge.");
        Write ("When I went to get some juice, I noticed a puddle of a red substance right infront of me.");
        Write ("Shocked I ran to my room.");
        Write ("Type 'room2' to go to your room.");
    }

    // Update is called once per frame
    void Update () {

    }

}