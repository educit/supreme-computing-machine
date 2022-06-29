using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automate : MonoBehaviour
{
    [SerializeField] DanceTeamInit danceTeamInit;
    [SerializeField] BattleSystem battleSystem;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("GAM404 - Starts");
        danceTeamInit.InitTeams();

        battleSystem.teamA = danceTeamInit.teamA;
        battleSystem.teamB = danceTeamInit.teamB;

        battleSystem.RequestRound();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            Application.Quit();

        if( battleSystem.teamA.activeDancers.Count <= 0 ||
            battleSystem.teamB.activeDancers.Count <= 0)
        {
            Debug.Log($"TeamA has {battleSystem.teamA.activeDancers.Count} dancers.");
            Debug.Log($"TeamB has {battleSystem.teamB.activeDancers.Count} dancers.");
            Application.Quit();
        }
    }
}
