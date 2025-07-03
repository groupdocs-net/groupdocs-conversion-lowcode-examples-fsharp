open System
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main _ =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

    // Apply license
    License.Set(publicKey, privateKey)

    // Hide tracked changes through load options
    let converter = new PdfToPdfAConverter("form-fields.pdf", fun options ->
        options.FlattenAllFields <- true
    )

    // Convert PDF to PDF/A
    converter.Convert("flattened.pdf")
    0