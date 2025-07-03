open System
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main _ =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")
    
    // Apply license
    License.Set(publicKey, privateKey)

    // Show hidden slides through load options
    let converter = new PptxToPdfConverter("with-hidden-slides.pptx", fun options ->
        options.ShowHiddenSlides <- true
    )
    
    // Convert PPTX to PDF
    converter.Convert("with-hidden-slides.pdf")
    0