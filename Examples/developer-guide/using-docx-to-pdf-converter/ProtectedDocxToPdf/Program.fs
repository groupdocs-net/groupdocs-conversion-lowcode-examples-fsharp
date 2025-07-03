open System
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main _ =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

    // Apply the license
    License.Set(publicKey, privateKey)

    // Provide password through load options
    let converter = new DocxToPdfConverter("protected.docx", fun options ->
        options.Password <- "12345"
    )
    
    // Convert DOCX to PDF
    converter.Convert("not-protected.pdf")
    0