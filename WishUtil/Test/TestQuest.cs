using TeamCherry.Localization;

namespace WishUtil.Test
{
    internal abstract class TestQuest : CustomQuest
    {
        internal TestQuest(string questName) : base(questName,
                                                    new LocalisedString($"Mods.{WishUtil.Id}", "QUEST_NAME"),
                                                    new LocalisedString($"Mods.{WishUtil.Id}", "QUEST_LOC"))
        { }

        public override string GetDescription()
        {
            return name;
        }
    }
}