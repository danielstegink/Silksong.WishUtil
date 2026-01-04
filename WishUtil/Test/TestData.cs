namespace WishUtil.Test
{
    internal static class TestData
    {
        internal static bool testMode = false;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        internal static DeliveryTest deliveryTest;

        internal static DonateTest donateTest;

        internal static GatherTest gatherTest;

        internal static GrandHuntTest grandHuntTest;

        internal static HuntTest huntTest;

        internal static LearnTest learnTest;

        internal static SprintTest sprintTest;

        internal static SteelTest steelTest;

        internal static WayfarerTest wayfarerTest;

        internal static WitnessTest witnessTest;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

        internal static int killCount = 0;
    }
}
