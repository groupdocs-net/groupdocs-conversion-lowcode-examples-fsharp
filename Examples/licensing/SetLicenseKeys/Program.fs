open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main argv =
    // The public and private keys from your license.
    let publicKey = "..."
    let privateKey = "..."

    // Set license keys
    License.Set(publicKey, privateKey)

    0 // Return exit code
