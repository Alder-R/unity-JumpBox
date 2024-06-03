using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour      // 교재 예제 모음
{
    // Start is called before the first frame update
    void Start()
    {
        // 캐릭터의 프로필을 변수로 만들기
        string characterName = "라라";
        char bloodType = 'A';
        int age = 17;
        float height = 168.3f;
        bool isFemale = true;
        // 생성한 변수를 콘솔에 출력
        Debug.Log("캐릭터 이름: " + characterName);
        Debug.Log("혈액형: " + bloodType);
        Debug.Log("나이: " +  age);
        Debug.Log("키: " + height);
        Debug.Log("여성인가?: " + isFemale);

        // 두 점 사이의 거리 구하기 함수 출력
        float distance = GetDistance(2, 2, 5, 6);
        Debug.Log("(2, 2)에서 (5, 6)까지의 거리: " + distance);

        // 테스트1
        float h = 24.923f, w = 12.054f, j = 27.298f;
        int s1, s2;
        s1 = (h > w) ? 20 : 50;
        s2 = (s1 < j) ? 70 : 90;
        Debug.Log("s2의 결과는 " + s2);

        // 제어문 예제들
        // if, if else, else
        MiYeanSi(100);
        MiYeanSi(80);
        MiYeanSi(50);
        // &&, ||, !
        // for, while

        // 배열 예제
        int[] students = new int[5];
        students[0] = 100; students[1] = 90; students[2] = 80; students[3] = 70; students[4] = 60;
        for (int i = 0; i < students.Length; i++) Debug.Log($"{i}번 학생의 점수: {students[i]}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 두 점 사이의 거리 구하기 함수
    float GetDistance(float x1, float y1, float x2, float y2)
    {
        float width = x2 - x1;
        float height = y2 - y1;

        float distance = width * width + height * height;
        distance = Mathf.Sqrt(distance);

        return distance;
    }

    void MiYeanSi(int love)
    {
        if (90 < love) Debug.Log($"호감도: {love}, 트루엔딩");
        else if (70 < love) Debug.Log($"호감도: {love}, 굿엔딩");
        else Debug.Log($"호감도: {love}, 배드엔딩");
    }
}
