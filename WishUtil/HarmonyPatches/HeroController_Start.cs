using HarmonyLib;
using System.Collections.Generic;

namespace WishUtil.HarmonyPatches
{
    [HarmonyPatch(typeof(HeroController), "Start")]
    public static class HeroController_Start
    {
        [HarmonyPostfix]
        public static void Postfix(HeroController __instance)
        {
            // Add quests to Quest Completion database
            List<string> questNames = PlayerData.instance.QuestCompletionData.GetValidNames();
            foreach (CustomQuest quest in QuestData.quests.Values)
            {
                if (!questNames.Contains(quest.name))
                {
                    QuestCompletionData.Completion data = new QuestCompletionData.Completion()
                    {
                        HasBeenSeen = quest.GiveAtStart,
                        IsAccepted = quest.GiveAtStart,
                        IsCompleted = false,
                        WasEverCompleted = false,
                        CompletedCount = 0,
                    };
                    PlayerData.instance.QuestCompletionData.SetData(quest.name, data);
                    quest.Completion = data;
                    WishUtil.instance.Log($"{quest.name} added to QuestCompletionData (Accepted: {data.IsAccepted}, Completed: {data.IsCompleted})");
                }
                else
                {
                    QuestCompletionData.Completion data = PlayerData.instance.QuestCompletionData.GetData(quest.name);
                    WishUtil.instance.Log($"QuestCompletionData found for {quest.name} (Accepted: {data.IsAccepted}, Completed: {data.IsCompleted})");
                }
            }
        }
    }
}