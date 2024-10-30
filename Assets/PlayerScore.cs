using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    //we are making the score private as we want to only interact with it through methods
    private int _playerScore = 0;
    //this is how powerful the players clicks are
    private int _scoreMultiplier = 1;
    
    //these are references to our text in the scene
    public TMP_Text multiplierText;
    public TMP_Text scoreText;

    //we can set the initial score of the player here
    private void Start()
    {
        UpdateText();
    }

    //the parameter takes an int to remove from the players score
    public void AddScore()
    {
        _playerScore += 1 * _scoreMultiplier;
        UpdateText();
    }

    //the parameter takes an int to remove from the players score
    public void RemoveScore(int scoreToRemove)
    {
        _playerScore -= scoreToRemove;
    }

    //this increases the player multiplier
    public void IncreaseMultiplier()
    {
        _scoreMultiplier++;
        UpdateText();
    }

    //this is for the shop to able to see how much score the player has without directly accessing the variable
    public int GetPlayerScoreValue()
    {
        return _playerScore;
    }

    //since we update the text a lot, we created a separate method we can call from multiple places
    private void UpdateText()
    {
        scoreText.text = $"Player Score = {_playerScore}";
        multiplierText.text = "Player Multiplier = " + _scoreMultiplier;
    }
}
