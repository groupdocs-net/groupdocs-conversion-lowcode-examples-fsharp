open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main argv =
    // The path to the license file. The path can be relative or absolute.
    let licensePath = "./GroupDocs.Conversion.LowCode.lic"

    // Apply the license.
    License.Set(licensePath)

    0 // Return exit code
