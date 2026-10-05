# Set License Keys

As an alternative option you can set the license keys that you can find within your license file.
The following sample demonstrates how to set license keys.

## Code Example

```fsharp
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main argv =
    // The public and private keys from your license.
    let publicKey = "..."
    let privateKey = "..."

    // Set license keys
    License.Set(publicKey, privateKey)

    0 // Return exit code
```

## How to Run

1. Install the .NET SDK for `net10.0`.
2. Edit `Program.fs` so that it uses your license: the path to your license file, or your public and private keys.
3. Open this directory and run the example:
   ```bash
   dotnet run
   ```

## Learn More

- [Licensing](https://docs.groupdocs.net/conversion/licensing/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
