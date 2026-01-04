namespace WishUtil.Test
{
    internal class GrandHuntTest : TestQuest
    {
        public override bool GiveAtStart => true;

        public override QuestType QuestType => GetQuestType.GetType(QuestTypeEnum.GrandHunt);

        public GrandHuntTest() : base("GrandHuntTest")
        {
        }
    }
}