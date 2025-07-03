open System
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main _ =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")
    
    // Apply license
    License.Set(publicKey, privateKey)

    // Skip external resources through load options
    let converter = new HtmlToPdfConverter("with-image.html", fun options ->
        options.SkipExternalResources <- true
    )
    
    // Convert HTML to PDF
    converter.Convert("without-image.pdf")
    0