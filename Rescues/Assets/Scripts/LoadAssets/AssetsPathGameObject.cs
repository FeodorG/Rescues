﻿using System.Collections.Generic;


namespace Rescues
{
    public sealed class AssetsPathGameObject
    {
        #region Fields

        public static readonly Dictionary<GameObjectType, string> Object = new Dictionary<GameObjectType, string>()
        {
            {GameObjectType.Character, "Player/Character"},
        };

        #endregion
    }
}