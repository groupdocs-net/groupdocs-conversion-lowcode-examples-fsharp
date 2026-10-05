# Convert Specific Sheets from XLS to PDF

The following example shows how to convert only specific sheets from an XLS file to PDF using the `SheetIndexes` property.

## Code Example

```fsharp
open System
open System.Collections.Generic
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main _ =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")
    
    // Apply license
    License.Set(publicKey, privateKey)

    // Convert only specific sheets through load options
    let converter = new XlsToPdfConverter("invoice-tracker.xls", fun options ->
        options.SheetIndexes <- List<int>([0; 2]) // Convert first and third sheets
    )
    
    // Convert XLS to PDF
    converter.Convert("specific-sheets.pdf")
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

- `invoice-tracker.xls`

## Learn More

- [Using XLS to PDF Converter](https://docs.groupdocs.net/conversion/developer-guide/using-xls-to-pdf-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
