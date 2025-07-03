open System
open System.Collections.Generic
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main _ =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")
    
    // Apply license
    License.Set(publicKey, privateKey)

    // Convert only specific sheets (first and third sheets)
    let converter = new XlsxToPdfConverter("invoice-tracker.xlsx", fun options ->
        options.SheetIndexes <- List<int>([0; 2]) // 0-based indexing
    )
    
    // Convert XLSX to PDF
    converter.Convert("specific-sheets.pdf")
    0