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

    // Convert only specific sheets through load options
    let converter = new XlsToPdfConverter("invoice-tracker.xls", fun options ->
        options.SheetIndexes <- List<int>([0; 2]) // Convert first and third sheets
    )
    
    // Convert XLS to PDF
    converter.Convert("specific-sheets.pdf")
    0