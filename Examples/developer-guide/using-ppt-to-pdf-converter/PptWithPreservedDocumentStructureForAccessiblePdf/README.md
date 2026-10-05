# Convert PPT with Preserved Document Structure for Accessible PDF

The following example shows how to convert a PPT file to an accessible PDF by preserving the document structure using the `PreserveDocumentStructure` property. This is useful for creating PDFs that are more accessible to screen readers and assistive technologies.

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

    // Preserve document structure for accessible PDF
    let converter = new PptToPdfConverter("presentation.ppt", fun options ->
        options.PreserveDocumentStructure <- true
    )
    
    // Convert PPT to accessible PDF
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

- `presentation.ppt`

## Learn More

- [Using PPT to PDF Converter](https://docs.groupdocs.net/conversion/developer-guide/using-ppt-to-pdf-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
