using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartKingLottary : MonoBehaviour
{
    public void KingLottary()
    {
        SceneManager.LoadScene(1);
    }

    public void QueenLottary()
    {
        SceneManager.LoadScene(2);
    }

    public void TigerJackpotNew()
    {
        SceneManager.LoadScene(3);
    }

    public void GoldenMatka()
    {
        SceneManager.LoadScene(4);
    }

    public void SilverMatka()
    {
        SceneManager.LoadScene(5);
    }

    public void DragonLottaryJackpot()
    {
        SceneManager.LoadScene(6);
    }

    
}
