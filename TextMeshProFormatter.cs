using System.Globalization;
using System.Text;

/// <summary>
/// A formatter class for building rich text strings for TextMeshPro.
/// </summary>
public class TextMeshProFormatter
{
    private StringBuilder formattedText;

    /// <summary>
    /// Specifies the alignment of text.
    /// </summary>
    public enum Alignment
    {
        Left,
        Right,
        Center,
        Justified,
    }

    /// <summary>
    /// Initializes a new instance of the TextMeshProFormatter class.
    /// </summary>
    public TextMeshProFormatter()
    {
        formattedText = new StringBuilder();
    }

    /// <summary>
    /// Appends text to the formatter.
    /// </summary>
    /// <param name="text">The text to append.</param>
    /// <returns>The current instance of the formatter.</returns>
    public TextMeshProFormatter AppendText(string text)
    {
        formattedText.Append(text);
        return this;
    }

    /// <summary>
    /// Applies bold formatting to the text.
    /// </summary>
    /// <returns>The current instance of the formatter.</returns>
    public TextMeshProFormatter Bold()
    {
        formattedText.Insert(0, "<b>").Append("</b>");
        return this;
    }

    /// <summary>
    /// Applies italic formatting to the text.
    /// </summary>
    /// <returns>The current instance of the formatter.</returns>
    public TextMeshProFormatter Italicize()
    {
        formattedText.Insert(0, "<i>").Append("</i>");
        return this;
    }

    /// <summary>
    /// Applies underline formatting to the text.
    /// </summary>
    /// <returns>The current instance of the formatter.</returns>
    public TextMeshProFormatter Underline()
    {
        formattedText.Insert(0, "<u>").Append("</u>");
        return this;
    }

    /// <summary>
    /// Applies strikethrough formatting to the text.
    /// </summary>
    /// <returns>The current instance of the formatter.</returns>
    public TextMeshProFormatter Strikethrough()
    {
        formattedText.Insert(0, "<s>").Append("</s>");
        return this;
    }

    /// <summary>
    /// Sets the color of the text.
    /// </summary>
    /// <param name="colorHexCode">The color hex code to apply to the text.</param>
    /// <returns>The current instance of the formatter.</returns>
    public TextMeshProFormatter SetColor(string colorHexCode)
    {
        formattedText.Insert(0, $"<color=#{colorHexCode}>").Append("</color>");
        return this;
    }

    /// <summary>
    /// Sets the size of the text.
    /// </summary>
    /// <param name="size">The font size to apply to the text.</param>
    /// <returns>The current instance of the formatter.</returns>
    public TextMeshProFormatter SetSize(int size)
    {
        formattedText.Insert(0, $"<size={size}>").Append("</size>");
        return this;
    }

    /// <summary>
    /// Sets the font of the text.
    /// </summary>
    /// <param name="fontAssetName">The name of the font asset to apply to the text.</param>
    /// <returns>The current instance of the formatter.</returns>
    public TextMeshProFormatter SetFont(string fontAssetName)
    {
        formattedText.Insert(0, $"<font={fontAssetName}>").Append("</font>");
        return this;
    }

    /// <summary>
    /// Inserts a sprite into the text.
    /// </summary>
    /// <param name="spriteIndex">The index of the sprite to insert.</param>
    /// <returns>The current instance of the formatter.</returns>
    public TextMeshProFormatter InsertSprite(int spriteIndex)
    {
        formattedText.Append($"<sprite={spriteIndex}>");
        return this;
    }

    /// <summary>
    /// Sets the opacity of the text.
    /// </summary>
    /// <param name="opacity">The opacity value to apply to the text (0.0 - 1.0).</param>
    /// <returns>The current instance of the formatter.</returns>
    public TextMeshProFormatter SetOpacity(float opacity)
    {
        formattedText.Insert(0, $"<alpha=#{opacity:F2}>").Append("</alpha>");
        return this;
    }

    /// <summary>
    /// Aligns the text according to the specified alignment.
    /// </summary>
    /// <param name="alignment">The alignment to apply to the text.</param>
    /// <returns>The current instance of the formatter.</returns>
    public TextMeshProFormatter Align(Alignment alignment)
    {
        string alignTag = alignment switch
        {
            Alignment.Left => "left",
            Alignment.Right => "right",
            Alignment.Center => "center",
            Alignment.Justified => "justified",
            _ => "left" // Default to left if an unknown value is passed
        };

        formattedText.Insert(0, $"<align={alignTag}>").Append("</align>");
        return this;
    }

    /// <summary>
    /// Applies a gradient effect to the text.
    /// </summary>
    /// <param name="color1">The starting color of the gradient.</param>
    /// <param name="color2">The ending color of the gradient.</param>
    /// <param name="angle">The angle of the gradient (default is 0).</param>
    /// <returns>The current instance of the formatter.</returns>
    public TextMeshProFormatter Gradient(string color1, string color2, float angle = 0)
    {
        formattedText.Insert(0, $"<gradient=#{color1},#{color2}>").Append("</gradient>");
        return this;
    }

    /// <summary>
    /// Rotates the text by a specified angle.
    /// </summary>
    /// <param name="angle">The angle to rotate the text.</param>
    /// <returns>The current instance of the formatter.</returns>
    public TextMeshProFormatter Rotate(float angle)
    {
        formattedText.Insert(0, $"<rotate={angle}>").Append("</rotate>");
        return this;
    }

    /// <summary>
    /// Converts the entire text to uppercase.
    /// </summary>
    /// <returns>The current instance of the formatter.</returns>
    public TextMeshProFormatter Uppercase()
    {
        string upperText = formattedText.ToString().ToUpper(CultureInfo.InvariantCulture);
        formattedText.Clear().Append(upperText);
        return this;
    }

    /// <summary>
    /// Returns the formatted text as a string.
    /// </summary>
    /// <returns>The formatted text.</returns>
    public override string ToString()
    {
        return formattedText.ToString();
    }
}
