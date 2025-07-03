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
    let converter = new DocToPdfConverter("tracked-changes.doc", fun options ->
        options.HideWordTrackedChanges <- true
    )

    // Convert DOC to PDF
    converter.Convert("clean.pdf")
    0