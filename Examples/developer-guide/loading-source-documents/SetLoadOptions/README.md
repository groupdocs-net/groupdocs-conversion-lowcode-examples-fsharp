# Example 3: Set Load Options

You can use the optional constructor parameter to apply custom load options such as passwords for protected files.

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
    let converter = new DocxToPdfConverter("protected.docx", fun options ->
        options.Password <- "12345"
    )
    
    // Convert DOCX to PDF
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

- `protected.docx`

## Learn More

- [Loading Source Documents](https://docs.groupdocs.net/conversion/developer-guide/loading-source-documents/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
