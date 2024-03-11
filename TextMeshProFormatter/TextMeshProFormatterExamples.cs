using System;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

public class TextMeshProFormatterExamples : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI formatedText;
    [SerializeField] TextMeshProUGUI rawText;

    TextMeshProFormatter formatter = new();

    public const string black = "000000";
    public const string blue = "3498db";
    public const string green = "2ecc71";
    public const string red = "e74c3c";
    public const string purple = "9b59b6";
    public const string white = "ffffff";
    public const string yellow = "f1c40f";

    private void Awake()
    {
        formatedText.richText = true;
        rawText.richText = false;
    }

    private void DisplayString(string text)
    {
        formatedText.text = text;

        rawText.text = text;
    }

    public void DefaultText()
    {
        DisplayString("Default Text");
    }

    public void FontStylesExample()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Font styles can be ");
        sb.Append(formatter.AppendText("Bold ").Bold().GetFormattedText());
        sb.Append(formatter.AppendText("Strikethrough ").Strikethrough().GetFormattedText());
        sb.Append(formatter.AppendText("Underline ").Underline().GetFormattedText());
        sb.Append(formatter.AppendText("Italicize").Italicize().GetFormattedText());
        DisplayString(sb.ToString());
    }

    private string GetRandomColor()
    {
        string[] colors = { black, blue, green, red, purple, white, yellow };
        int index = UnityEngine.Random.Range(0, colors.Length);
        return colors[index];
    }

    public void ColorsExample()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(formatter.AppendText("Here ").SetColor(GetRandomColor()).GetFormattedText());
        sb.Append(formatter.AppendText("are ").SetColor(GetRandomColor()).GetFormattedText());
        sb.Append(formatter.AppendText("some ").SetColor(GetRandomColor()).GetFormattedText());
        sb.Append(formatter.AppendText("different ").SetColor(GetRandomColor()).GetFormattedText());
        sb.Append(formatter.AppendText("colored ").SetColor(GetRandomColor()).GetFormattedText());
        sb.Append(formatter.AppendText("strings! ").SetColor(GetRandomColor()).GetFormattedText());
        DisplayString(sb.ToString());
    }

    public void SizeExample()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(formatter.AppendText("Here ").SetSize(40).GetFormattedText());
        sb.Append(formatter.AppendText("are ").SetSize(60).GetFormattedText());
        sb.Append(formatter.AppendText("some ").SetSize(80).GetFormattedText());
        sb.Append(formatter.AppendText("different ").SetSize(50).GetFormattedText());
        sb.Append(formatter.AppendText("sized ").SetSize(100).GetFormattedText());
        sb.Append(formatter.AppendText("strings!").SetSize(90).GetFormattedText());
        DisplayString(sb.ToString());
    }

    public void AdvancedExample()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Default text\n");
        sb.Append(formatter.AppendText("Decreasing ").SetOpacity(.5f).GetFormattedText());
        sb.Append(formatter.AppendText("Text ").SetOpacity(.25f).GetFormattedText());
        sb.Append(formatter.AppendText("Alpha\n").SetOpacity(.1f).GetFormattedText());
        sb.Append(formatter.AppendText("Rotated ").Rotate(30).GetFormattedText());
        sb.Append(formatter.AppendText("Text ").Rotate(-30).GetFormattedText());
        DisplayString(sb.ToString());
    }

    public void CombinedExample()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(formatter.AppendText("Example Title\n")
            .Bold()
            .Underline()
            .SetSize(85)
            .SetColor(red)
            .GetFormattedText());

        sb.AppendLine(formatter.AppendText("Subject: ")
            .SetOpacity(0.5f)
            .AppendText("Example Subject\n")
            .Italicize()
            .SetSize(45)
            .GetFormattedText());

        sb.Append(formatter.AppendText("Here is an example of a message.\n This message has multiple lines.\n End of message.").SetSize(35).GetFormattedText());
        DisplayString(sb.ToString());
    }


}
