# Example 3: Set Convert Options

You can use optional convert options to adjust the output according to your requirements. Each converter has its own corresponding convert options.

The following code example shows how to set convert options to convert the first three pages of a DOCX document to a PDF file.

## Code Example

```fsharp
open System
open System.Collections.Generic
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main argv =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

    // Apply license
    License.Set(publicKey, privateKey)

    // Create the converter
    let converter = new DocxToPdfConverter("business-plan.docx")

    // Save first three pages to PDF
    converter.Convert("pages-1-2-3.pdf", fun convertOptions ->
        convertOptions.Pages <- List<int>([1; 2; 3])
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

- `business-plan.docx`

## Learn More

- [Saving Converted Documents](https://docs.groupdocs.net/conversion/developer-guide/saving-converted-documents/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
