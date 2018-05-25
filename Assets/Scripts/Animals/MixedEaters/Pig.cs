using UnityEngine;
using UnityEngine.UI;

public class Pig : Animal{
    public string name;
    [SerializeField]
    private GameObject Balloon;
    [SerializeField]
    private Text text;

    public override void SayHello()
    {
        Balloon.SetActive(true);
        text.text = "oink oink";
    }

    public override void EatLeaves()
    {
        Balloon.SetActive(true);
        text.text = "munch munch oink";
    }

    public override void EatMeat()
    {
        Balloon.SetActive(true);
        text.text = "nomnomnom oink thx";
    }

    public override void PerformTrick()
    {
        StartCoroutine(DoTrick());
    }
}

	
