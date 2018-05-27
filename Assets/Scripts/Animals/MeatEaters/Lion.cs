using UnityEngine;
using UnityEngine.UI;
using Zoo;

public class Lion : Animal {
   
    //Texts Message can be given in Spanwer.cs 
    //-when creating an animal.

    
    [SerializeField]
    private GameObject Balloon;
    [SerializeField]
    private Text text;

    public override void SayHello()
    {
        Balloon.SetActive(true);
        //Texts Message can be given in Spanwer.cs 
        //-when creating an animal.
        //or code them here using: ""
        text.text = helloMessage;
    }

    public override void EatMeat()
    {
        Balloon.SetActive(true);
        text.text = feedMeatMessage;
    }
}

