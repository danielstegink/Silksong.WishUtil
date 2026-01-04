using BepInEx;
using HarmonyLib;
using WishUtil.Test;

namespace WishUtil;

[BepInAutoPlugin(id: "io.github.danielstegink.wishutil")]
[BepInDependency("org.silksong-modding.i18n")]
public partial class WishUtil : BaseUnityPlugin
{
    internal static WishUtil instance;

    private void Awake()
    {
        // Put your initialization logic here
        instance = this;

        Log($"Plugin {Name} ({Id}) has loaded!");
    }

    private void Start()
    {
        Harmony harmony = new Harmony(Id);
        harmony.PatchAll();

        GetQuestType.BuildQuestTypes();
        Log("Quest Type templates constructed");

        if (TestData.testMode)
        {
            TestData.deliveryTest = new DeliveryTest();
            QuestData.AddQuest(TestData.deliveryTest);
            TestData.donateTest = new DonateTest();
            QuestData.AddQuest(TestData.donateTest);
            TestData.gatherTest = new GatherTest();
            QuestData.AddQuest(TestData.gatherTest);
            TestData.grandHuntTest = new GrandHuntTest();
            QuestData.AddQuest(TestData.grandHuntTest);
            TestData.huntTest = new HuntTest();
            QuestData.AddQuest(TestData.huntTest);
            TestData.learnTest = new LearnTest();
            QuestData.AddQuest(TestData.learnTest);
            TestData.sprintTest = new SprintTest();
            QuestData.AddQuest(TestData.sprintTest);
            TestData.steelTest = new SteelTest();
            QuestData.AddQuest(TestData.steelTest);
            TestData.wayfarerTest = new WayfarerTest();
            QuestData.AddQuest(TestData.wayfarerTest);
            TestData.witnessTest = new WitnessTest();
            QuestData.AddQuest(TestData.witnessTest);
        }
    }

    /// <summary>
    /// Shared logger for external classes
    /// </summary>
    /// <param name="message"></param>
    internal void Log(string message)
    {
        Logger.LogInfo(message);
    }
}