﻿namespace Rescues
{
    public sealed class MainControllers : Controllers
    {
        #region ClassLifeCycles
        
        public MainControllers(GameContext context, Services services)
        {
            Add(new InitializeCharacterController(context, services));
            Add(new InitializeInteractableObjectController(context, services));
            Add(new InitializeInventoryController(context, services));
<<<<<<< Updated upstream
            Add(new ItemPutInInventoryController(context, services));
            Add(new DoorTeleporterController(context, services));
            Add(new HidingPlaceController(context, services));
=======
            Add(new InitializeEnemyController(context, services));
            Add(new ItemPutInInventoryController(context, services));
            Add(new DoorTeleporterController(context, services));
            Add(new EnemyVisionController(context, services));
            Add(new EnemyMoveController(context, services));
>>>>>>> Stashed changes
            Add(new InputController(context, services));
        }

        #endregion
    }
}
