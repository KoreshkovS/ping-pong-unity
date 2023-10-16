using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private bool _isPlayer1Goal;
    [SerializeField] private GameManager _gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (_isPlayer1Goal)
            {
                _gameManager.Player2Scored();
            }
            else
            {
                _gameManager.Player1Scored();
            }
        }
    }
}
