using DanielSteginkUtils.ExternalFiles;
using System;
using System.Collections.Generic;
using System.Reflection;
using TeamCherry.Localization;
using UnityEngine;

namespace WishUtil
{
    public enum QuestTypeEnum
    {
        Wayfarer,
        Gather,
        Hunt,
        GrandHunt,
        Donate,
        Delivery,
        Learn,
        Sprint,
        Witness,
        Steel,
    }
            
    public static class GetQuestType
    {
        /// <summary>
        /// Maps each quest type to its given enum value
        /// </summary>
        internal static Dictionary<QuestTypeEnum, QuestType> types = new Dictionary<QuestTypeEnum, QuestType>();

        /// <summary>
        /// Stores the text color for each quest type
        /// </summary>
        private static Dictionary<QuestTypeEnum, Color> typeColors = new Dictionary<QuestTypeEnum, Color>()
        {
            { QuestTypeEnum.Wayfarer, new Color(0.925f, 0.792f, 0.478f) },
            { QuestTypeEnum.Gather, new Color(0.559f, 0.926f, 0.724f) },
            { QuestTypeEnum.Hunt, new Color(0.925f, 0.514f, 0.478f) },
            { QuestTypeEnum.GrandHunt, new Color(0.925f, 0.514f, 0.478f) },
            { QuestTypeEnum.Donate, new Color(0.915f, 0.662f, 0.522f) },
            { QuestTypeEnum.Delivery, new Color(0.783f, 0.471f, 0.321f) },
            { QuestTypeEnum.Learn, new Color(0.962f, 0.595f, 0.760f) },
            { QuestTypeEnum.Sprint, new Color(0.358f, 0.590f, 0.783f) },
            { QuestTypeEnum.Witness, new Color(1.000f, 0.600f, 0.278f) },
            { QuestTypeEnum.Steel, new Color(0.750f, 0.750f, 0.750f) },
        };

        /// <summary>
        /// Gets a template quest type
        /// </summary>
        /// <param name="questType"></param>
        /// <returns></returns>
        public static QuestType GetType(QuestTypeEnum questType)
        {
            return types[questType];
        }

        /// <summary>
        /// Builds a custom quest type
        /// </summary>
        /// <param name="questTypeName"></param>
        /// <param name="icon"></param>
        /// <param name="textColor"></param>
        /// <param name="iconGlow"></param>
        /// <param name="iconLarge"></param>
        /// <param name="iconLargeGlow"></param>
        /// <returns></returns>
        public static QuestType BuildCustomType(LocalisedString questTypeName, Sprite icon, Color? textColor, 
                                                Sprite? iconGlow, Sprite? iconLarge, Sprite? iconLargeGlow) 
        {
            if (iconGlow == null)
            {
                iconGlow = icon;
            }

            if (iconLarge == null)
            {
                iconLarge = icon;
            }

            if (iconLargeGlow == null)
            {
                iconLargeGlow = icon;
            }

            if (textColor == null)
            {
                textColor = Color.white;
            }

            return QuestType.Create(questTypeName, icon, (Color)textColor, iconLarge, iconLargeGlow, iconGlow);
        }

        /// <summary>
        /// Builds the template quest types and stores them so GetType can easily reference them
        /// </summary>
        /// <returns></returns>
        internal static void BuildQuestTypes()
        {
            foreach (QuestTypeEnum value in (QuestTypeEnum[])Enum.GetValues(typeof(QuestTypeEnum)))
            {
                string typeName = value.ToString();
                //WishUtil.instance.Log($"Building type for {typeName}");

                LocalisedString name = new LocalisedString($"Mods.{WishUtil.Id}", $"TYPE_NAME_{typeName}");
                Assembly assembly = Assembly.GetExecutingAssembly();
                Sprite? icon = GetSprite.GetLocalSprite($"WishUtil.Resources.{typeName}.Icon.png", assembly);
                Sprite? iconGlow = GetSprite.GetLocalSprite($"WishUtil.Resources.{typeName}.Glow.png", assembly);
                Sprite? iconLarge = GetSprite.GetLocalSprite($"WishUtil.Resources.{typeName}.Large.png", assembly);
                Sprite? iconLargeGlow = GetSprite.GetLocalSprite($"WishUtil.Resources.{typeName}.Large_Glow.png", assembly);
                Color textColor = typeColors[value];

                QuestType type = QuestType.Create(name, icon, textColor, iconLarge, iconLargeGlow, iconGlow);
                types.Add(value, type);
            }
        }
    }
}