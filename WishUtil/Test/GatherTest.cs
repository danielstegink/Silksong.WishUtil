namespace WishUtil.Test
{
    internal class GatherTest : TestQuest
    {
        public override bool GiveAtStart => true;

        public override QuestType QuestType => GetQuestType.GetType(QuestTypeEnum.Gather);

        public GatherTest() : base("GatherTest")
        {
        }
    }
}