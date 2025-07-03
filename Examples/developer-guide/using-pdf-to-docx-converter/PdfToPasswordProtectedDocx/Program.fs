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
    let converter = new PdfToDocxConverter("business-plan.pdf")

    // Convert to password-protected DOCX
    converter.Convert("protected.docx", fun convertOptions ->
        convertOptions.Password <- "12345"
    )

    0