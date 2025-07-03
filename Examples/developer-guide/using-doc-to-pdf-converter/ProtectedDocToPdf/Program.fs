open System
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main _ =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")
    
    // Apply license
    License.Set(publicKey, privateKey)

    // Provide password through load options
    let converter = new DocToPdfConverter("protected.doc", fun options ->
        options.Password <- "12345"
    )
    
    // Convert DOC to PDF
    converter.Convert("not-protected.pdf")
    0