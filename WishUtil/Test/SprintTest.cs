namespace WishUtil.Test
{
    internal class SprintTest : TestQuest
    {
        public override bool GiveAtStart => true;

        public override QuestType QuestType => GetQuestType.GetType(QuestTypeEnum.Sprint);

        public SprintTest() : base("SprintTest")
        {
        }
    }
}