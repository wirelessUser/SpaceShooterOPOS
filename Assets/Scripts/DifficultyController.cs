using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CosmicCuration.UI;

public class DifficultyController 
{
   public DifficultyController(DifficultyState difficultyState)=> SetDifficultyState(difficultyState);

    private void SetDifficultyState(DifficultyState difficultyState)
    {
        switch (difficultyState)
        {
            case DifficultyState.Easy:
                // changing data values here
                break;
            case DifficultyState.Medium:
                // changing data values here
                break;
            case DifficultyState.Hard:
                // changing data values here
                break;
        }
    }

    public void GetDifficultyVariable()
    {

    }

}
