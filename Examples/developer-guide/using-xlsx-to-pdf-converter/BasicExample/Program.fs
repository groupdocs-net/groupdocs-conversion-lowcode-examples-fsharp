open System
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main _ =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

    // Apply the license
    License.Set(publicKey, privateKey)

    // Create a converter from file path
    let converter = new XlsxToPdfConverter("cost-analysis.xlsx")

    // Convert XLSX to PDF
    converter.Convert("cost-analysis.pdf")
    0