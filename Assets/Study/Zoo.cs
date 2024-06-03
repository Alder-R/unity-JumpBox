using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animal tom = new Animal();
        tom.name = "톰";
        tom.sound = "야옹";

        Animal jerry = new Animal();
        jerry.name = "제리";
        jerry.sound = "찍찍";

        Animal miki = new Animal();
        miki.name = "미키";
        miki.sound = jerry.sound;

        tom.PlayAnimalSound();
        jerry.PlayAnimalSound();
        miki.PlayAnimalSound();
    }
}
