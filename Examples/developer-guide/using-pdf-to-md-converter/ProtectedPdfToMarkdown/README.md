# Convert Protected PDF to Markdown

The following example shows how to convert protected PDF file and save it to unprotected Markdown file.

In case you do not specify password for protected document [PasswordRequiredException](https://reference.groupdocs.net/conversion/GroupDocs.Conversion.Exceptions/PasswordRequiredException/) is going to be thrown.

## Code Example

```fsharp
open System
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main _ =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

    // Apply the license
    License.Set(publicKey, privateKey)

    // Create a converter from file path
    let converter = new PdfToMdConverter("protected.pdf", fun options ->
        options.Password <- "12345"
    )

    // Convert PDF to Markdown
    converter.Convert("unprotected.md")
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

- `protected.pdf`

## Learn More

- [Using PDF to MD Converter](https://docs.groupdocs.net/conversion/developer-guide/using-pdf-to-md-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
