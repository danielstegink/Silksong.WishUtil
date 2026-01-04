namespace WishUtil.Test
{
    internal class WayfarerTest : TestQuest
    {
        public override bool GiveAtStart => true;

        public override QuestType QuestType => GetQuestType.GetType(QuestTypeEnum.Wayfarer);

        public WayfarerTest() : base("WayfarerTest")
        {
        }
    }
}