open System
open GroupDocs.Conversion.LowCode
open GroupDocs.Conversion.Options.Convert

[<EntryPoint>]
let main argv =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

    // Apply license
    License.Set(publicKey, privateKey)

    // Create the converter
    let converter = new XlsToPdfConverter("cost-analysis.xls")

    // Convert to PDF/A-1b format for archiving
    converter.Convert("converted.pdf", fun convertOptions ->
        convertOptions.PdfOptions.PdfFormat <- PdfFormats.PdfA_1B
    )

    0 // return exit code