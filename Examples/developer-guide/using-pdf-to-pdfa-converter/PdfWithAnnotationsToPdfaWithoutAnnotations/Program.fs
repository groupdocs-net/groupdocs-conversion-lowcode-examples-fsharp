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
        new PdfToPdfAConverter("with-annotations.pdf", fun options ->
            options.HidePdfAnnotations <- true
        )

    // Convert PDF to PDF/A
    converter.Convert("no-annotations.pdf")

    0 // return an integer exit code