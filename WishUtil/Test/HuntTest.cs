namespace WishUtil.Test
{
    internal class HuntTest : TestQuest
    {
        public override bool GiveAtStart => true;

        public override QuestType QuestType => GetQuestType.GetType(QuestTypeEnum.Hunt);

        public HuntTest() : base("HuntTest")
        {
        }
    }
}