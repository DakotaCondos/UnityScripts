# UnityScripts

Welcome to the UnityScripts repository! This is a collection of Unity scripts that I've created, which I believe will be useful to others in the Unity development community. I'll be periodically adding new scripts to this repository.

## Getting Started

To use the scripts in your Unity projects, follow these steps:

1. **Clone or download this repository.** You can do this by running `git clone https://github.com/yourusername/UnityScripts.git` in your terminal or command prompt, or by downloading the ZIP file directly from GitHub.

2. **Import the scripts into your Unity project.** Open your Unity project, navigate to the Assets menu, and choose Import Package > Custom Package. Select the script files you wish to use.

3. **Attach the scripts to your GameObjects.** In the Unity editor, select the GameObject you want to apply the script to, then drag the script file from your Assets onto the Inspector window.

## Scripts

### TextMeshProFormatter

The `TextMeshProFormatter` class provides an easy way to build rich text strings for TextMeshPro in Unity. It supports various formatting options, such as bold, italic, underline, strikethrough, color, size, font, and more.

#### Features

- **Text Formatting:** Apply bold, italic, underline, and strikethrough formatting.
- **Color and Size:** Set the text color and size.
- **Font:** Specify the font asset for the text.
- **Alignment and Opacity:** Adjust text alignment and opacity.
- **Gradient, Rotation, and More:** Create text with gradients, rotate text, and insert sprites.

#### Usage

Here's a simple example of how to use `TextMeshProFormatter`:

```csharp
TextMeshProFormatter formatter = new TextMeshProFormatter()
    .AppendText("Hello, World!")
    .Bold()
    .SetColor("FF0000")
    .SetSize(24);

string formattedText = formatter.ToString();
// Use formattedText with your TextMeshPro object
```

For more details on each method and how to use them, refer to the script documentation within the `TextMeshProFormatter.cs` file.

## Contributing

Contributions are welcome! If you have a script you'd like to share or improvements to existing scripts, please feel free to submit a pull request.

## License

This project is licensed under the MIT License - see the LICENSE file for details.

