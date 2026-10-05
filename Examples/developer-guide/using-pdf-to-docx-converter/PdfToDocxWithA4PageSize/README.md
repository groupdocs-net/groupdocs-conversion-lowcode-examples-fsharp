# Convert PDF to DOCX with A4 Page Size

You can specify the page size for the output DOCX file using the [SizeSettings](https://reference.groupdocs.net/conversion/GroupDocs.Conversion.Options.Convert/WordProcessingConvertOptions/SizeSettings/) property of the `WordProcessingConvertOptions` class, which takes a [PageSizeOptions](https://reference.groupdocs.net/conversion/GroupDocs.Conversion.Options/PageSizeOptions/) object.

The following example shows how to convert a PDF file to DOCX with A4 page size:

## Code Example

```fsharp
open System
open GroupDocs.Conversion.LowCode
open GroupDocs.Conversion.Options

[<EntryPoint>]
let main argv =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

    // Apply license
    License.Set(publicKey, privateKey)

    // Create the converter
    let converter = new PdfToDocxConverter("business-plan.pdf")

    // Convert to DOCX with A4 page size
    converter.Convert("a4-size.docx", fun convertOptions ->
        convertOptions.SizeSettings <- PageSizeOptions(PageSize = PageSize.A4)
    )

    0 // return exit code
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

- [Using PDF to DOCX Converter](https://docs.groupdocs.net/conversion/developer-guide/using-pdf-to-docx-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
