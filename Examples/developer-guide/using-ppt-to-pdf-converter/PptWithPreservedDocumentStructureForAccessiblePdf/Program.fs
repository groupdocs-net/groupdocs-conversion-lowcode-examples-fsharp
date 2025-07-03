open System
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main _ =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")
    
    // Apply license
    License.Set(publicKey, privateKey)

    // Preserve document structure for accessible PDF
    let converter = new PptToPdfConverter("presentation.ppt", fun options ->
        options.PreserveDocumentStructure <- true
    )
    
    // Convert PPT to accessible PDF
    converter.Convert("accessible.pdf")
    0