using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Ink.Runtime;

public class Dialog : MonoBehaviour
{
    public Story story;
    public Button continueButton;
    public Button choiceButtonPrefab;
    public VisualElement storyContainer;

    private void Start()
    {
        continueButton.clicked += Continue;
        StartStory();
    }

    private void StartStory()
    {
        story.ChooseChoiceIndex(0);
        RefreshView();
    }

    private void RefreshView()
    {
        storyContainer.Clear();

        if (story.canContinue)
        {
            string text = story.Continue();
            storyContainer.Add(new Label(text));
        }
        else if (story.currentChoices.Count > 0)
        {
            foreach (Choice choice in story.currentChoices)
            {
                Button choiceButton = new Button();
                choiceButton.text = choice.text.Trim();
                choiceButton.clicked += () => OnClickChoice(choice);
                storyContainer.Add(choiceButton);
            }
        }
        else
        {
            storyContainer.Add(new Label("End of story."));
        }
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
