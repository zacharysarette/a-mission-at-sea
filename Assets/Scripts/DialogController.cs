using System;
using UnityEngine;
using UnityEngine.UIElements;
using Ink.Runtime;

public class DialogController : MonoBehaviour
{
    public static event Action<Story> OnCreateStory;

    [SerializeField]
    private TextAsset inkJSONAsset = null;
    public Story story;
    [SerializeField]
    private UIDocument document;
    private Button continueButton;
    private VisualElement buttonContainer;
    private VisualElement storyContainer;
    private VisualElement textContainer;

    private Label textLabel;

    private void Awake()
    {
        setupUI();
    }

    private void setupUI()
    {
        VisualElement root = document.rootVisualElement;
        storyContainer = root.Q<VisualElement>("storyContainer");
        continueButton = storyContainer.Q<Button>("continueButton");
        continueButton.clicked += Continue;
        continueButton.style.display = DisplayStyle.None;
        textContainer = storyContainer.Q<VisualElement>("textContainer");
        buttonContainer = storyContainer.Q<VisualElement>("buttonContainer");
        textLabel = textContainer.Q<Label>("textLabel");
    }

    private void Start()
    {
        StartStory();
    }

    void StartStory()
    {
        story = new Story(inkJSONAsset.text);
        if (OnCreateStory != null) OnCreateStory(story);
        RefreshView();
    }

    private void RefreshView()
    {
        textLabel.Clear();

        if (story.canContinue)
        {
            string text = story.Continue();
            Debug.Log(text);
            textLabel.text = text;
            continueButton.style.display = DisplayStyle.Flex;
            buttonContainer.Clear();
        }
        else if (story.currentChoices.Count > 0)
        {
            continueButton.style.display = DisplayStyle.None;
            Debug.Log(story.currentChoices.Count);
            foreach (Choice choice in story.currentChoices)
            {
                Debug.Log(choice.text);
                Button choiceButton = new Button();
                choiceButton.text = choice.text.Trim();
                choiceButton.clicked += () => OnClickChoice(choice);
                buttonContainer.Add(choiceButton);
            }
        }
        else
        {
            textLabel.text = "End Story";
        }
    }

    private void AddButton(string text)
    {
        // Create a button instance
        Button button = new Button();

        // Apply the button style
        // button.styleSheets.Add(buttonStyle);

        // Set the button's text
        button.text = text;

        // Add the button to the UI
        storyContainer.Add(button);
    }

    private void Continue()
    {
        RefreshView();
    }

    private void OnClickChoice(Choice choice)
    {
        story.ChooseChoiceIndex(choice.index);
        RefreshView();
    }
}
