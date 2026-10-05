# Convert PPT with Hidden Slides

By default hidden slides are not added to the converted PDF document.

The following example shows how to include hidden slides when converting PPT to PDF using the `ShowHiddenSlides` property.

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

    // Show hidden slides through load options
    let converter = new PptToPdfConverter("with-hidden-slides.ppt", fun options ->
        options.ShowHiddenSlides <- true
    )
    
    // Convert PPT to PDF
    converter.Convert("with-hidden-slides.pdf")
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

- `with-hidden-slides.ppt`

## Learn More

- [Using PPT to PDF Converter](https://docs.groupdocs.net/conversion/developer-guide/using-ppt-to-pdf-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
