open System
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main _ =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

    // Apply license
    License.Set(publicKey, privateKey)

    // Apply custom CSS styling through load options
    let converter = new HtmlToPdfConverter("sample.html", fun options ->
        options.CustomCssStyle <- "body { font-family: Arial, sans-serif; font-size: 14px; color: #333; }"
    )
    
    // Convert HTML to PDF
    converter.Convert("styled-sample.pdf")
    0