using HarmonyLib;

namespace WishUtil.Test
{
    [HarmonyPatch(typeof(EnemyJournalManager), "RecordKillToJournalData")]
    public static class EnemyJournalManager_RecordKillToJournalData
    {
        [HarmonyPostfix]
        public static void Postfix()
        {
            if (!TestData.testMode)
            {
                return;
            }

            TestData.killCount++;
            TestData.deliveryTest.Update();
            TestData.donateTest.Update();
            TestData.gatherTest.Update();
            TestData.grandHuntTest.Update();
            TestData.huntTest.Update();
            TestData.learnTest.Update();
            TestData.sprintTest.Update();
            TestData.steelTest.Update();
            TestData.wayfarerTest.Update();
            TestData.witnessTest.Update();

            if (TestData.killCount > 2)
            {
                if (!TestData.deliveryTest.IsAccepted)
                {
                    TestData.deliveryTest.Accept();
                }
                else
                {
                    TestData.deliveryTest.Update();
                }
            }

            if (TestData.killCount > 4)
            {
                TestData.deliveryTest.Complete();
            }

            if (TestData.killCount > 5)
            {
                TestData.donateTest.Complete();
            }

            if (TestData.killCount > 6)
            {
                TestData.gatherTest.Complete();
            }

            if (TestData.killCount > 7)
            {
                TestData.grandHuntTest.Complete();
            }

            if (TestData.killCount > 8)
            {
                TestData.huntTest.Complete();
            }

            if (TestData.killCount > 9)
            {
                TestData.learnTest.Complete();
            }

            if (TestData.killCount > 10)
            {
                TestData.sprintTest.Complete();
            }

            if (TestData.killCount > 11)
            {
                TestData.steelTest.Complete();
            }

            if (TestData.killCount > 12)
            {
                TestData.wayfarerTest.Complete();
            }

            if (TestData.killCount > 13)
            {
                TestData.witnessTest.Complete();
            }
        }
    }
}