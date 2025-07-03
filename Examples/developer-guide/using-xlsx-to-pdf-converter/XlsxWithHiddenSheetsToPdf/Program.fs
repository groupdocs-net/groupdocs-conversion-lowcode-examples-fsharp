open System
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main _ =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")
    
    // Apply license
    License.Set(publicKey, privateKey)

    // Include hidden sheets in conversion
    let converter = new XlsxToPdfConverter("hidden-worksheets.xlsx", fun options ->
        options.ShowHiddenSheets <- true
    )
    
    // Convert XLSX to PDF
    converter.Convert("with-hidden-sheets.pdf")
    0