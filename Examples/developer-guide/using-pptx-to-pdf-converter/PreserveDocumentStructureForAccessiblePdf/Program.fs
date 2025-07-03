open System
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main _ =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")
    
    // Apply license
    License.Set(publicKey, privateKey)

    // Preserve document structure through load options
    let converter = new PptxToPdfConverter("presentation.pptx", fun options ->
        options.PreserveDocumentStructure <- true
    )
    
    // Convert PPTX to PDF
    converter.Convert("accessible.pdf")
    0