# Convert DOC with Tracked Changes to PDF

By default, tracked changes are converted and displayed in the output PDF document. See this [tracked-changes.pdf](https://docs.groupdocs.net/conversion/_sample_files/developer-guide/using-doc-to-pdf-converter/tracked-changes.pdf) that includes the list of changes.

The following example shows how to convert a DOC file that contains tracked changes and save a clean PDF file without those revisions.

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

    // Hide tracked changes through load options
    let converter = new DocToPdfConverter("tracked-changes.doc", fun options ->
        options.HideWordTrackedChanges <- true
    )

    // Convert DOC to PDF
    converter.Convert("clean.pdf")
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

- `tracked-changes.doc`

## Learn More

- [Using DOC to PDF Converter](https://docs.groupdocs.net/conversion/developer-guide/using-doc-to-pdf-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
