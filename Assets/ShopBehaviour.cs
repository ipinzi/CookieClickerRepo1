using UnityEngine;

public class ShopBehaviour : MonoBehaviour
{
    public PlayerScore playerScore;

    public void BuyClickerUpgrade()
    {
        //if the player score is above 10
        if (playerScore.GetPlayerScoreValue() >= 10)
        {
            //remove the amount of score for the upgrade
            playerScore.RemoveScore(10);
            //increase their multiplier by one
            playerScore.IncreaseMultiplier();
        }
    }
}