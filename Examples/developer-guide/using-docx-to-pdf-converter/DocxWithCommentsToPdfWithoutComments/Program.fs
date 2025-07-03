open System
open GroupDocs.Conversion.LowCode
open GroupDocs.Conversion.Options.Load

[<EntryPoint>]
let main _ =
    // Load license keys
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

    // Apply license
    License.Set(publicKey, privateKey)

    // Hide comments using CommentDisplayMode
    let converter = new DocxToPdfConverter("with-comments.docx", fun options ->
        options.CommentDisplayMode <- WordProcessingCommentDisplay.Hidden
    )

    // Convert DOCX to PDF
    converter.Convert("no-comments.pdf")
    0