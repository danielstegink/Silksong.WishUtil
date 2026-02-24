using TeamCherry.Localization;
using UnityEngine;

namespace WishUtil
{
    public abstract class CustomQuest : FullQuestBase
    {
        /// <summary>
        /// Whether or not the player should have the quest automatically
        /// </summary>
        public abstract bool GiveAtStart { get; }

        /// <summary>
        /// The Wish's description as seen in the Task journal.
        /// </summary>
        /// <returns></returns>
        public abstract string GetDescription();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">In-game ID for the Wish</param>
        /// <param name="displayName">The name displayed in the Task journal</param>
        /// <param name="location">The location where the Wish is acquired. Putting Pharloom should be sufficent.</param>
        public CustomQuest(string name, LocalisedString displayName, LocalisedString location)
        {
            this.name = name;
            this.displayName = displayName;
            this.location = location;
            inventoryDescription = new LocalisedString($"Mods.{WishUtil.Id}", "QUEST_DESC");

            overrideFontSize = new TeamCherry.SharedUtils.OverrideFloat()
            {
                IsEnabled = false
            };

            overrideParagraphSpacing = new TeamCherry.SharedUtils.OverrideFloat()
            {
                IsEnabled = false
            };

            overrideParagraphSpacingShort = new TeamCherry.SharedUtils.OverrideFloat() 
            { 
                IsEnabled = false 
            };

            targets = new QuestTarget[0];

            customPickupDisplay = new UIMsgDisplay()
            {
                Name = GlobalSettings.UI.QuestContinuePopup,
                Icon = QuestType.Icon,
                IconScale = 1f,
                RepresentingObject = this,
            };
        }

        public override bool IsHidden => false;

        /// <summary>
        /// Accepts the Wish, adding it to the player's list
        /// </summary>
        public void Accept()
        {
            BeginQuest(new System.Action(() => { }));
        }

        /// <summary>
        /// UI trigger for the Wish updating
        /// </summary>
        public void Update()
        {
            if (Completion.IsCompleted)
            {
                return;
            }

            CollectableUIMsg.Spawn(customPickupDisplay, Color.white);
        }

        /// <summary>
        /// Tells the game that you've accomplished the Wish
        /// </summary>
        public void Complete()
        {
            if (Completion.IsCompleted)
            {
                return;
            }

            QuestCompletionData.Completion data = PlayerData.instance.QuestCompletionData.GetData(name);
            data.SetCompleted();
            Completion = data;
            ShowQuestCompleted(new System.Action(() => { }));
        }
    }
}