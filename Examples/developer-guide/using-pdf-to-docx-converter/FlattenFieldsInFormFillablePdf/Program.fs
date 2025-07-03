open System
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main _ =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")
    
    // Apply license
    License.Set(publicKey, privateKey)

    // Flatten form fields through load options
    let converter = new PdfToDocxConverter("form-fields.pdf", fun options ->
        options.FlattenAllFields <- true
    )
    
    // Convert PDF to DOCX
    converter.Convert("flattened.docx")
    0