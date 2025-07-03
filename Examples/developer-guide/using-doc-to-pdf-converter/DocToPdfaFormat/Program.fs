open System
open GroupDocs.Conversion.Options.Convert
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main _ =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

    // Apply license
    License.Set(publicKey, privateKey)

    // Create the converter
    let converter = new DocToPdfConverter("business-plan.doc")

    // Convert to PDF/A format
    converter.Convert("archived.pdf", fun convertOptions ->
        convertOptions.PdfOptions.PdfFormat <- PdfFormats.PdfA_1A
    )

    0