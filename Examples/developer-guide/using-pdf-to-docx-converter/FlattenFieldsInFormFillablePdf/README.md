# Flatten Fields in Form-Fillable PDF

The following example shows how to convert a form‑fillable PDF into static content by flattening form fields.

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

    // Flatten form fields through load options
    let converter = new PdfToDocxConverter("form-fields.pdf", fun options ->
        options.FlattenAllFields <- true
    )
    
    // Convert PDF to DOCX
    converter.Convert("flattened.docx")
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

- `form-fields.pdf`

## Learn More

- [Using PDF to DOCX Converter](https://docs.groupdocs.net/conversion/developer-guide/using-pdf-to-docx-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
