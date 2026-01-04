namespace WishUtil.Test
{
    internal class DonateTest : TestQuest
    {
        public override bool GiveAtStart => true;

        public override QuestType QuestType => GetQuestType.GetType(QuestTypeEnum.Donate);

        public DonateTest() : base("DonateTest")
        {
        }
    }
}