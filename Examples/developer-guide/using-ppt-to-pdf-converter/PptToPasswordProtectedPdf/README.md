# Convert PPT to Password-Protected PDF

You can protect the output PDF with a password by setting the [Password](https://reference.groupdocs.net/conversion/GroupDocs.Conversion.Options.Convert/PdfConvertOptions/Password/) property in `PdfConvertOptions` class.

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
    let converter = new PptToPdfConverter("presentation.ppt")

    // Convert to password-protected PDF
    converter.Convert("protected.pdf", fun convertOptions ->
        convertOptions.Password <- "12345"
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

- `presentation.ppt`

## Learn More

- [Using PPT to PDF Converter](https://docs.groupdocs.net/conversion/developer-guide/using-ppt-to-pdf-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
