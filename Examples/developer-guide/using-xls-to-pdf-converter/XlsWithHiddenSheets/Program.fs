open System
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main _ =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")
    
    // Apply license
    License.Set(publicKey, privateKey)

    // Show hidden sheets through load options
    let converter = new XlsToPdfConverter("hidden-sheets.xls", fun options ->
        options.ShowHiddenSheets <- true
    )
    
    // Convert XLS to PDF
    converter.Convert("with-hidden-sheets.pdf")
    0