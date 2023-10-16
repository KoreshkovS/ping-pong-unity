using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header ("Ball")]
    [SerializeField] private Ball _ball;

    [Header("Player1")]
    [SerializeField] private Paddle _player1Paddle;
    [SerializeField] private GameObject _player1Goal;

    [Header("Player2")]
    [SerializeField] private Paddle _player2Paddle;
    [SerializeField] private GameObject _player2Goal;

    [Header("Score UI")]
    [SerializeField] private TextMeshProUGUI _player1Text;
    [SerializeField] private TextMeshProUGUI _player2Text;

    private int _player1Score;
    private int _player2Score;

    public void Player1Scored()
    {
        _player1Score++;
        _player1Text.text = _player1Score.ToString();
        ResetPosition();
    }

    public void Player2Scored()
    {
        _player2Score++;
        _player2Text.text = _player2Score.ToString();
        ResetPosition();
    }

    private void ResetPosition()
    {
        _ball.Reset();
        _player1Paddle.Reset();
        _player2Paddle.Reset();
    }
}
