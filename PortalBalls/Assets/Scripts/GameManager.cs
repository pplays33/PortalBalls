using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PointScript greenPoint;
    public PointScript bluePoint;
    public PointScript redPoint;
    public PointScript pinkPoint;
    public GameObject PlayerControll;

    private bool isGameOver;
    private FirstPersonController fps;


    void Start()
    {
        fps = PlayerControll.GetComponent<FirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGameOver = greenPoint.isSolved && bluePoint.isSolved && redPoint.isSolved && pinkPoint.isSolved;
    }

    void OnGUI()
    {
        if (isGameOver)
        {
            fps.enabled = false;
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box(rect, "Game Over");

            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label(rect2, "Good Job!");
        }
    }
}
