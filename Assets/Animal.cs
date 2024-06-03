using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{
    // 동물에 대한 변수들
    public string name, sound;

    // 동물 울음소리 재생 메소드
    public void PlayAnimalSound()
    {
        Debug.Log($"{name}: {sound}");
    }
}
