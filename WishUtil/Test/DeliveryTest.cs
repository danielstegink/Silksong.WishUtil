namespace WishUtil.Test
{
    internal class DeliveryTest : TestQuest
    {
        public override bool GiveAtStart => false;

        public override QuestType QuestType => GetQuestType.GetType(QuestTypeEnum.Delivery);

        public DeliveryTest() : base("DeliveryTest")
        {
        }
    }
}