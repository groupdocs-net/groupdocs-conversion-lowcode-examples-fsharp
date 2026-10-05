# Set License from File

The following code demonstrates setting a license from a file:

## Code Example

```fsharp
open GroupDocs.Conversion.LowCode

[<EntryPoint>]
let main argv =
    // The path to the license file. The path can be relative or absolute.
    let licensePath = "./GroupDocs.Conversion.LowCode.lic"

    // Apply the license.
    License.Set(licensePath)

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
