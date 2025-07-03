open System
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main _ =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

    // Apply license
    License.Set(publicKey, privateKey)

    // Create the converter
    let converter = new PdfToMdConverter("business-plan.pdf")

    // Convert to Markdown without embedding images as base64
    converter.Convert("without-images.md", fun convertOptions ->
        convertOptions.MarkdownOptions.ExportImagesAsBase64 <- false
    )

    0