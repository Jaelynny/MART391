using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int tick = 0;
    private System.Random random = new System.Random(42);

    public delegate void PlayerActionEvent();
    public delegate void PuzzleActionEvent();
    public static event PuzzleActionEvent OnPuzzleAction;
    public static event PlayerActionEvent OnPlayerAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject newGameObject = new GameObject("MyGameObject");
        newGameObject.AddComponent<Rigidbody>();
        InitializePuzzle();
    }

    private void InitializePuzzle()
    {
        throw new NotImplementedException();
    }

    void FixedUpdate()
    {
        tick++;
        UpdateGameState();
        tick++;
        UpdatePuzzleState();
    }

    private void UpdateGameState()
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Tick: " + tick);
        // I used github fix math as a fixed point math for fixed calculations
        int randomValue = random.Next();
        Debug.Log("Random Value: " + randomValue);

        if (Input.GetButtonDown("Space"))
        {
            OnPuzzleAction?.Invoke();
        }
    }
    void InitializePuzzel()
    {
        Debug.Log("Initializing puzzel");
    }
    
    void UpdatePuzzleState()
    {
        Debug.Log("Tick: " + tick);
    }
}
