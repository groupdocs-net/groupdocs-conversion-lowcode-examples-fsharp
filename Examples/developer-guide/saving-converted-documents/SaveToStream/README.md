# Example 2: Save to Stream

This example demonstrates how to save the converted file to a `Stream`.

## Code Example

```fsharp
open System
open System.IO
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main argv =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

    // Apply license
    License.Set(publicKey, privateKey)

    // Use 'use' bindings for automatic disposal
    use inputStream = File.OpenRead("business-plan.docx")
    use outputStream = File.Create("business-plan.pdf")

    // Create a converter from stream
    let converter = new DocxToPdfConverter(inputStream)

    // Convert DOCX to PDF
    converter.Convert(outputStream)

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

- `business-plan.docx`

## Learn More

- [Saving Converted Documents](https://docs.groupdocs.net/conversion/developer-guide/saving-converted-documents/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
