using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class ProjectileBehaviour : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    private Vector3 _currentMovementVector;

    public Vector3 CurrentMovementVector
    {
        get => _currentMovementVector;
        set => _currentMovementVector = value;
    }

    void Start()
    {
        GenerateMoveVector();
    }

    void FixedUpdate()
    {
        transform.position += _currentMovementVector * _movementSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        ScoreHandler script = other.gameObject.GetComponent<ScoreHandler>();
        if(script != null)
            GenerateMoveVector();
    }

    private void GenerateMoveVector()
    {
        
        var (x, y) = ChooseVector();
        _currentMovementVector = new Vector3(x, y, 0);
        _currentMovementVector = _currentMovementVector.normalized;
    }

    private (float x, float y) ChooseVector()
    {
        float x = 0, y = 0;
        switch (Random.Range(0, 4))
        {
            case 0:
                x = 0.5f;
                y = 0.5f;
                break;
            case 1:
                x = 0.5f;
                y = -0.5f;
                break;
            case 2:
                x = -0.5f;
                y = -0.5f;
                break;
            case 3:
                x = -0.5f;
                y = 0.5f;
                break;
        }

        return (x, y);
    }
}
