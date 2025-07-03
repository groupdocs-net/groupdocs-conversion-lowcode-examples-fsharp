open System
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main argv =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

    // Apply license
    License.Set(publicKey, privateKey)

    // Hide annotations using HidePdfAnnotations
    let converter = 
        new PdfToMdConverter("with-annotations.pdf", fun options ->
            options.HidePdfAnnotations <- true
        )

    // Convert PDF to Markdown
    converter.Convert("no-annotations.md")

    0 // return an integer exit code