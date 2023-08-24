using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CosmicCuration.UI;

public class DifficultyController 
{
    // TODO: Lambda Method
   public DifficultyController(DifficultyState difficultyState)
    {
        SetDifficultyVariable(difficultyState);
    }

    // TODO: Change name to SetDifficultyState()
    private void SetDifficultyVariable(DifficultyState difficultyState)
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
