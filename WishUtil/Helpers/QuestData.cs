using System.Collections.Generic;

namespace WishUtil
{
    public static class QuestData
    {
        /// <summary>
        /// Stores Wishes for ease of manipulation
        /// </summary>
        internal static Dictionary<string, CustomQuest> quests = new Dictionary<string, CustomQuest>();

        /// <summary>
        /// Adds the given quest to the list of custom quests.
        /// 
        /// This should be done in your mod's Start or Awake methods in order to ensure that the quest gets 
        /// added to the game.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static void AddQuest<T>(T quest) where T : CustomQuest
        {
            quests.Add(quest.name, quest);
        }

        /// <summary>
        /// Gets the given quest from the quest list. Recommend calling this AFTER QuestManager.Awake
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static CustomQuest GetQuest(string name)
        {
            return quests[name];
        }
    }
}