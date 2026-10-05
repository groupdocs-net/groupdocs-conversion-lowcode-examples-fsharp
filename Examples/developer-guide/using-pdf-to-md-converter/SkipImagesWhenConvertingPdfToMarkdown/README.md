# Skip Images when converting PDF to Markdown

By default, images are converted to base64 strings and embedded directly in the Markdown file. You can control this behavior using the [ExportImagesAsBase64](https://reference.groupdocs.net/conversion/GroupDocs.Conversion.Options.Convert/MarkdownOptions/ExportImagesAsBase64/) property in `MarkdownOptions` class. When set to `false`, images are not included into final Markdown file.

## Code Example

```fsharp
open System
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main _ =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

    // Apply license
    License.Set(publicKey, privateKey)

    // Create the converter
    let converter = new PdfToMdConverter("business-plan.pdf")

    // Convert to Markdown without embedding images as base64
    converter.Convert("without-images.md", fun convertOptions ->
        convertOptions.MarkdownOptions.ExportImagesAsBase64 <- false
    )

    0
```

## How to Run

1. Install the .NET SDK for `net10.0`.
2. Set the `GD_PUBLIC_KEY` and `GD_PRIVATE_KEY` environment variables to your license keys.
3. Open this directory and run the example:
   ```bash
   dotnet run
   ```

## Input Files

- `business-plan.pdf`

## Learn More

- [Using PDF to MD Converter](https://docs.groupdocs.net/conversion/developer-guide/using-pdf-to-md-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
