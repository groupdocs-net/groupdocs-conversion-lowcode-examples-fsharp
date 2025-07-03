open System
open System.IO
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main argv =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

    // Apply license
    License.Set(publicKey, privateKey)

    // Use 'use' bindings for automatic disposal
    use inputStream = File.OpenRead("business-plan.docx")
    use outputStream = File.Create("business-plan.pdf")

    // Create a converter from stream
    let converter = new DocxToPdfConverter(inputStream)

    // Convert DOCX to PDF
    converter.Convert(outputStream)

    0 // return exit code