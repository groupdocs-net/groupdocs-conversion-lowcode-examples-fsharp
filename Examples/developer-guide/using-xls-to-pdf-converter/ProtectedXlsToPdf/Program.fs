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
    let converter = new XlsToPdfConverter("protected.xls", fun options ->
        options.Password <- "12345"
    )
    
    // Convert XLS to PDF
    converter.Convert("unprotected.pdf")
    0