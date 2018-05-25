using UnityEngine;
using UnityEngine.UI;


public class Lion : Animal {
    public string name;
    [SerializeField]
    private GameObject Balloon;
    [SerializeField]
    private Text text;

    public override void SayHello()
    {
        Balloon.SetActive(true);
        text.text = "roooaoaaaaar";
    }

    public override void EatMeat()
    {
        Balloon.SetActive(true);
        text.text = "nomnomnom thx mate";
    }
}

