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
    let converter = new PptToPdfConverter("presentation.ppt")

    // Convert to password-protected PDF
    converter.Convert("protected.pdf", fun convertOptions ->
        convertOptions.Password <- "12345"
    )

    0