# DOC to PDF - Basic Example

This example demonstrates how to perform a basic DOC to PDF conversion using GroupDocs.Conversion.LowCode.

## Overview

This console application shows how to create a DOC to PDF converter and perform a simple document conversion.

## Purpose

This example demonstrates the **basic DOC to PDF conversion workflow**:
- Loading DOC documents using file path
- Simple DOC to PDF conversion
- Basic file input/output handling
- Straightforward conversion process

## Files

### Input Files
- `business-plan.doc` - Source DOC document for conversion

### Output Files
- `business-plan.pdf` - Converted PDF output document

## Running the Example

1. Ensure you have .NET 6.0 or later installed
2. Set your GroupDocs license keys as environment variables:
   - `GD_PUBLIC_KEY`
   - `GD_PRIVATE_KEY`
3. Navigate to this directory
4. Run the example:
   ```bash
   dotnet run
   ```

## Code Overview

The conversion logic in `Program.fs` demonstrates:
- License setup from environment variables
- Document loading using file path: `new DocToPdfConverter("business-plan.doc")`
- Basic conversion workflow
- File output

## Requirements

- .NET 6.0 or later
- GroupDocs.Conversion.LowCode package
- Valid GroupDocs license keys (Optional)

## Related Documentation

For more information about DOC to PDF conversion, see the [GroupDocs.Conversion.LowCode documentation](https://docs.groupdocs.net/conversion/developer-guide/). 
