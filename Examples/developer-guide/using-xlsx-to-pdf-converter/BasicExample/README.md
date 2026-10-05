# Basic Example

The following example shows the most common use case for converting XLSX document to PDF. The source XLSX file is loaded from a current folder. The converted file is saved to the same folder.

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
    let converter = new XlsxToPdfConverter("cost-analysis.xlsx")

    // Convert XLSX to PDF
    converter.Convert("cost-analysis.pdf")
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

- `cost-analysis.xlsx`

## Learn More

- [Using XLSX to PDF Converter](https://docs.groupdocs.net/conversion/developer-guide/using-xlsx-to-pdf-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
