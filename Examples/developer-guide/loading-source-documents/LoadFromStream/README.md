# Example 2: Load from Stream

This example demonstrates how to load a document from a stream (e.g., memory or custom storage provider).

## Code Example

```fsharp
open System
open System.IO
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main _ =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

    // Apply license
    License.Set(publicKey, privateKey)

    // Load stream
    use stream = File.OpenRead("business-plan.docx")

    // Create a converter from stream
    let converter = new DocxToPdfConverter(stream)

    // Convert DOCX to PDF
    converter.Convert("business-plan.pdf")
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

- `business-plan.docx`

## Learn More

- [Loading Source Documents](https://docs.groupdocs.net/conversion/developer-guide/loading-source-documents/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
