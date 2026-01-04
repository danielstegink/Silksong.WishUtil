using HarmonyLib;

namespace WishUtil.HarmonyPatches
{
    [HarmonyPatch(typeof(QuestManager), "Awake")]
    public static class QuestManager_Awake
    {
        [HarmonyPostfix]
        public static void Postfix(QuestManager __instance)
        {
            //QuestType questType = QuestManager.GetQuest("Save the Fleas").QuestType;
            //WishUtil.instance.Log($"{questType.name}: {questType.textColor}");
            //questType = QuestManager.GetQuest("Mossberry Collection 1").QuestType;
            //WishUtil.instance.Log($"{questType.name}: {questType.textColor}");
            //questType = QuestManager.GetQuest("Rock Rollers").QuestType;
            //WishUtil.instance.Log($"{questType.name}: {questType.textColor}");
            //questType = QuestManager.GetQuest("Skull King").QuestType;
            //WishUtil.instance.Log($"{questType.name}: {questType.textColor}");
            //questType = QuestManager.GetQuest("Songclave Donation 1").QuestType;
            //WishUtil.instance.Log($"{questType.name}: {questType.textColor}");
            //questType = QuestManager.GetQuest("Courier Delivery Bonebottom").QuestType;
            //WishUtil.instance.Log($"{questType.name}: {questType.textColor}");
            //questType = QuestManager.GetQuest("Journal").QuestType;
            //WishUtil.instance.Log($"{questType.name}: {questType.textColor}");
            //questType = QuestManager.GetQuest("Sprintmaster Race").QuestType;
            //WishUtil.instance.Log($"{questType.name}: {questType.textColor}");
            //questType = QuestManager.GetQuest("Mr Mushroom").QuestType;
            //WishUtil.instance.Log($"{questType.name}: {questType.textColor}");
            //questType = QuestManager.GetQuest("Steel Sentinel").QuestType;
            //WishUtil.instance.Log($"{questType.name}: {questType.textColor}");

            foreach (CustomQuest quest in QuestData.quests.Values)
            {
                __instance.masterList.Add(quest);
                WishUtil.instance.Log($"{quest.name} added to QuestManager");
            }
        }
    }
}