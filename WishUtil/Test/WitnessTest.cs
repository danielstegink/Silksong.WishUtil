namespace WishUtil.Test
{
    internal class WitnessTest : TestQuest
    {
        public override bool GiveAtStart => true;

        public override QuestType QuestType => GetQuestType.GetType(QuestTypeEnum.Witness);

        public WitnessTest() : base("WitnessTest")
        {
        }
    }
}