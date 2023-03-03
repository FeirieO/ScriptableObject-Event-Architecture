using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public FloatVariable HP;
    public GamEventListener gamEventListener;

    public string nextSceneName;
    public UnityEvent DeathEvent;

    private bool gameWon;

    private void OnMouseDown()
    {
        if (gameWon)
        {
            return;
        }

        DamageAmount damage = gameObject.GetComponent<DamageAmount>();
        if (damage != null)
        {
            gamEventListener.OnEventRaised();
        }

        if (HP.Value <= 0.0f)
        {
            DeathEvent.Invoke();

            gameWon = true;
            Debug.Log("Game Won");
        }
    }

    public void SceneLoader()
    {
        if (string.IsNullOrEmpty(nextSceneName))
        {
            return;
        }
        SceneManager.LoadScene(nextSceneName);
    }

}
