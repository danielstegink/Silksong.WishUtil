namespace WishUtil.Test
{
    internal class SteelTest : TestQuest
    {
        public override bool GiveAtStart => true;

        public override QuestType QuestType => GetQuestType.GetType(QuestTypeEnum.Steel);

        public SteelTest() : base("SteelTest")
        {
        }
    }
}