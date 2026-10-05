# Convert Protected XLSX to PDF

The following example shows how to convert protected XLSX file and save it to unprotected PDF file.

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
    
    // Apply license
    License.Set(publicKey, privateKey)

    // Provide password through load options
    let converter = new XlsxToPdfConverter("protected.xlsx", fun options ->
        options.Password <- "12345"
    )
    
    // Convert XLSX to PDF
    converter.Convert("not-protected.pdf")
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

- `protected.xlsx`

## Learn More

- [Using XLSX to PDF Converter](https://docs.groupdocs.net/conversion/developer-guide/using-xlsx-to-pdf-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
