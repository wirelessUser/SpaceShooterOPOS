using CosmicCuration.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CosmicCuration.Player
{
    public class DifficultyService
    {
        private DifficultyController controller;
        public DifficultyState currentDifficultyState;

        // TODO: Lambda method
        public DifficultyService()
        {
            controller = new DifficultyController(currentDifficultyState);
        }
    }
}
