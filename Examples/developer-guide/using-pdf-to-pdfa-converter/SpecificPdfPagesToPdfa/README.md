# Convert Specific PDF Pages to PDF/A

To convert only a portion of the document instead of all pages. You can specify which pages to include in the output PDF using the [Pages](https://reference.groupdocs.net/conversion/GroupDocs.Conversion.Options.Convert/IPagedConvertOptions/PageNumber/) property of `PdfConvertOptions` class.

As an alternative you can use `PageNumber` to specify the page number to start conversion from and `PagesCount` to set number of pages to convert starting from `PageNumber`. 

The following example shows how to convert the first three pages of a PDF file to PDF/A:

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
    let converter = new PdfToPdfAConverter("business-plan.pdf")

    // Save first three pages to PDF/A
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

- `business-plan.pdf`

## Learn More

- [Using PDF to PDF/A Converter](https://docs.groupdocs.net/conversion/developer-guide/using-pdf-to-pdfa-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
