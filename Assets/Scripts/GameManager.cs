using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Gamestate state;

    public static event Action<Gamestate> OnGameStateChanged ;
 

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        UpdateGamestate(Gamestate.Ecran_titre);
    }

    public void UpdateGamestate(Gamestate newState)
    {
        state = newState;

        switch (newState)
        {
            case Gamestate.Ecran_titre:
                HandleEcrant_titre();
                break;
            case Gamestate.jeu:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newStae, null);
        }
        OnGameStateChanged?.Invoke(newState);
    }
}
private void HandleEcrant_titre()
{

}
public enum Gamestate
{
    Ecran_titre,
    jeu,
}
