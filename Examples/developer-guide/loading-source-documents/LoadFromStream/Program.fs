open System
open System.IO
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main _ =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

    // Apply license
    License.Set(publicKey, privateKey)

    // Load stream
    use stream = File.OpenRead("business-plan.docx")

    // Create a converter from stream
    let converter = new DocxToPdfConverter(stream)

    // Convert DOCX to PDF
    converter.Convert("business-plan.pdf")
    0