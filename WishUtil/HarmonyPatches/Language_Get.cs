using HarmonyLib;
using TeamCherry.Localization;

namespace WishUtil.HarmonyPatches
{
    [HarmonyPatch(typeof(Language), "Get", new System.Type[] { typeof(string), typeof(string) })]
    public static class Language_Get
    {
        [HarmonyPostfix]
        public static void Postfix(ref string key, ref string sheetTitle, ref string __result)
        {
            //if (key.Equals("QUEST_DESC"))
            //{
            //    WishUtil.instance.Log($"Getting quest description for {sheetTitle}");
            //}

            foreach (CustomQuest quest in QuestData.quests.Values)
            {
                if (sheetTitle.Equals(quest.inventoryDescription.Sheet) &&
                    key.Equals(quest.inventoryDescription.Key))
                {
                    __result = quest.GetDescription();
                }
            }
        }
    }
}