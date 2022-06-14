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

        Debug.Log($"danceTeamInit TeamA has {danceTeamInit.teamA.allDancers.Count} dancers.");
        Debug.Log($"danceTeamInit TeamB has {danceTeamInit.teamB.allDancers.Count} dancers.");

        Debug.Log($"TeamA has {battleSystem.teamA.allDancers.Count} dancers.");
        Debug.Log($"TeamB has {battleSystem.teamB.allDancers.Count} dancers.");

        battleSystem.RequestRound();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
