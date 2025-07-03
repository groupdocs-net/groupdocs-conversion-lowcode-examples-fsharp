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
    let converter = new PptToPdfConverter("presentation.ppt")

    // Save first three slides to PDF
    converter.Convert("slides-1-2-3.pdf", fun convertOptions ->
        convertOptions.Pages <- List<int>([1; 2; 3])
    )

    0 // return exit code