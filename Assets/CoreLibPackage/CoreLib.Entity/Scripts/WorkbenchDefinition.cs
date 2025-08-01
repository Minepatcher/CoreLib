﻿using System.Collections.Generic;
using Pug.Sprite;
using Pug.UnityExtensions;
using UnityEngine;
using UnityEngine.Serialization;

namespace CoreLib.Submodules.ModEntity
{
    [CreateAssetMenu(fileName = "WorkbenchDefinition", menuName = "CoreLib/New WorkbenchDefinition", order = 2)]
    public class WorkbenchDefinition : ScriptableObject
    {
        [Tooltip("Format: <ModID>:<ItemID>\nExample: CoreLib:RootModWorkbench")]
        public string itemId;
        
        [FormerlySerializedAs("icon")] [Tooltip("Large Icon: 16x16 PNG")]
        public Sprite bigIcon;
        [Tooltip("Small Icon: 16x16 PNG\nRecommended Sprite Size: 10x10")]
        public Sprite smallIcon;
        
        [FormerlySerializedAs("variations")] [Tooltip("(not required)\nAll Variations of the item in a large 16x80 PNG")]
        public Texture2D texture;
        [Tooltip("Sprite Asset Skin: Target Asset should be Workbench.asset in CoreLib")]
        public SpriteAssetSkin assetSkin;
        [Tooltip("Bind this Workbench to the Root Workbench in CoreLib")]
        public bool bindToRootWorkbench;
        
        [FormerlySerializedAs("requiredObjectsToCraft")] [Tooltip("The required items to make this Workbench")]
        public List<InventoryItemAuthoring.CraftingObject> recipe;
        [Tooltip("The items this Workbench can craft")]
        public List<InventoryItemAuthoring.CraftingObject> canCraft;
        
        [PickStringFromEnum(typeof(ObjectID))] [Tooltip("The Workbenches that this Workbench can switch to.\nThe items of that Workbench will be added to this one.")]
        public List<string> relatedWorkbenches;
        [Tooltip("Refresh all the Window Titles when switching to a different related Workbench")]
        public bool refreshRelatedWorkbenchTitles;

        [Tooltip("The center Window Title of the Workbench")]
        public string title;
        [Tooltip("The left Window Title of the Workbench")]
        public string leftTitle;
        [Tooltip("The right Window Title of the Workbench")]
        public string rightTitle;
        [Tooltip("The skin of the Windows of the Workbench")]
        public UIManager.CraftingUIThemeType skin;
    }
}