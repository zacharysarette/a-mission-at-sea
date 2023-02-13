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
    private Button choiceButtonPrefab;
    private VisualElement storyContainer;
    private VisualElement textContainer;

    private void OnEnable()
    {
        VisualElement root = document.rootVisualElement;
        storyContainer = root.Q<VisualElement>("storyContainer");
        textContainer = storyContainer.Q<VisualElement>("textContainer");
        Button continueButton = root.Q<Button>("continueButton");
        continueButton.clicked += Continue;
    }

    private void Start()
    {
        StartStory();
    }

    void StartStory()
    {
        story = new Story(inkJSONAsset.text);
        if (OnCreateStory != null) OnCreateStory(story);
        // story.ChooseChoiceIndex(0);
        RefreshView();
    }

    private void RefreshView()
    {
        textContainer.Clear();

        if (story.canContinue)
        {
            string text = story.Continue();
            Debug.Log(text);
            textContainer.Add(new Label(text));
        }
        else if (story.currentChoices.Count > 0)
        {
            Debug.Log(story.currentChoices.Count);
            foreach (Choice choice in story.currentChoices)
            {
                Debug.Log(choice.text);
                Button choiceButton = new Button();
                choiceButton.text = choice.text.Trim();
                choiceButton.clicked += () => OnClickChoice(choice);
                storyContainer.Add(choiceButton);
            }
        }
        else
        {
            textContainer.Add(new Label("End of story."));
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
