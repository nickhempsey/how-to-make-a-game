
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManger;

    private void OnTriggerEnter()
    {
        gameManger.CompleteLevel();
    }
}
