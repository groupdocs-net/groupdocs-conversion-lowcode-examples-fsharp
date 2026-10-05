# Convert DOCX with Comments to PDF without Comments

By default, comments are added to the output PDF file, see this [with-comments.pdf](https://docs.groupdocs.net/conversion/_sample_files/developer-guide/using-docx-to-pdf-converter/with-comments.pdf) as an example of PDF file with comments.

The following example shows how to convert a DOCX file that contains comments and save a PDF file without comments.

## Code Example

```fsharp
open System
open GroupDocs.Conversion.LowCode
open GroupDocs.Conversion.Options.Load

[<EntryPoint>]
let main _ =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

    // Apply license
    License.Set(publicKey, privateKey)

    // Hide comments using CommentDisplayMode
    let converter = new DocxToPdfConverter("with-comments.docx", fun options ->
        options.CommentDisplayMode <- WordProcessingCommentDisplay.Hidden
    )

    // Convert DOCX to PDF
    converter.Convert("no-comments.pdf")
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

- `with-comments.docx`

## Learn More

- [Using DOCX to PDF Converter](https://docs.groupdocs.net/conversion/developer-guide/using-docx-to-pdf-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
