open GroupDocs.Conversion.LowCode
open System.IO

[<EntryPoint>]
let main argv =
    // The path to the license file. The path can be relative or absolute.
    let licensePath = "./GroupDocs.Conversion.LowCode.lic"

    // Check if the license file exists
    if File.Exists(licensePath) then
        // Apply the license.
        License.Set(licensePath)
        printfn "License applied successfully from file: %s" licensePath
    else
        printfn "Warning: License file not found at path: %s" licensePath
        printfn "Please ensure the license file exists or visit the documentation for licensing information:"
        printfn "https://docs.groupdocs.net/conversion/licensing/"
    
    0