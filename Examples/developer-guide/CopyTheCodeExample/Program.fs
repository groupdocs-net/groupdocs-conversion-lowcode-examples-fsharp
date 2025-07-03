open System
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main _ =
    let publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
    let privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

    License.Set(publicKey, privateKey)

    let converter = new XlsxToPdfConverter("cost-analysis.xlsx")
    converter.Convert("cost-analysis.pdf")
    0