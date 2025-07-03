open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main argv =
    // The path to the license file. The path can be relative or absolute.
    let privateKey = "..."
    let publicKey = "..."

    // Check if keys are properly set
    if privateKey = "..." || publicKey = "..." || 
       System.String.IsNullOrWhiteSpace(privateKey) || 
       System.String.IsNullOrWhiteSpace(publicKey) then
        printfn "⚠️  WARNING: License keys are not properly configured!"
        printfn "Please set your private and public keys to use the full functionality."
        printfn "For more information, visit: https://docs.groupdocs.net/conversion/licensing/"
        printfn ""
    else
        // Set license keys
        License.Set(privateKey, publicKey)
        printfn "✅ License keys have been set successfully."
    
    0 // Return exit code