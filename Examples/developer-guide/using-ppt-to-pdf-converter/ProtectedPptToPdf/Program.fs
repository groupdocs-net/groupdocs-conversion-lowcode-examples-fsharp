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
    let converter = new PptToPdfConverter("protected.ppt", fun options ->
        options.Password <- "12345"
    )
    
    // Convert PPT to PDF
    converter.Convert("unprotected.pdf")
    0