namespace WishUtil.Test
{
    internal class LearnTest : TestQuest
    {
        public override bool GiveAtStart => true;

        public override QuestType QuestType => GetQuestType.GetType(QuestTypeEnum.Learn);

        public LearnTest() : base("LearnTest")
        {
        }
    }
}