open System
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main _ =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")
    
    // Apply license
    License.Set(publicKey, privateKey)

    // Set zoom level to 150% through load options
    let converter = new HtmlToPdfConverter("sample.html", fun options ->
        options.Zoom <- 150 // 150% zoom level
    )
    
    // Convert HTML to PDF
    converter.Convert("zoomed-sample.pdf")
    0