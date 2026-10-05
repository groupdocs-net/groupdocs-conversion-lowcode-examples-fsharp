open System
open GroupDocs.Conversion.LowCode
open GroupDocs.Conversion.Options

[<EntryPoint>]
let main argv =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

    // Apply license
    License.Set(publicKey, privateKey)

    // Create the converter
    let converter = new PdfToDocxConverter("business-plan.pdf")

    // Convert to DOCX with A4 page size
    converter.Convert("a4-size.docx", fun convertOptions ->
        convertOptions.SizeSettings <- PageSizeOptions(PageSize = PageSize.A4)
    )

    0 // return exit code
