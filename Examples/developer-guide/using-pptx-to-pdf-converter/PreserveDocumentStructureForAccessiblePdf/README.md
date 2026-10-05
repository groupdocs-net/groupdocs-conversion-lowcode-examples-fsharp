# Preserve Document Structure for Accessible PDF

The following example shows how to preserve the document structure when converting PPTX to PDF using the `PreserveDocumentStructure` property. When this option is enabled, the structure will be preserved for accessible PDF.

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

    // Preserve document structure through load options
    let converter = new PptxToPdfConverter("presentation.pptx", fun options ->
        options.PreserveDocumentStructure <- true
    )
    
    // Convert PPTX to PDF
    converter.Convert("accessible.pdf")
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

- `presentation.pptx`

## Learn More

- [Using PPTX to PDF Converter](https://docs.groupdocs.net/conversion/developer-guide/using-pptx-to-pdf-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
