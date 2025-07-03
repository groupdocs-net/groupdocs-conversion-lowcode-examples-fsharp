# Copy The Code Example

This example demonstrates how to perform a basic XLSX to PDF conversion using GroupDocs.Conversion.LowCode.

## Overview

This console application shows how to create a converter and perform a simple document conversion from XLSX to PDF format.

## Purpose

This example demonstrates the **basic conversion workflow**:
- License setup from environment variables
- Simple XLSX to PDF conversion
- Basic file input/output handling
- Straightforward conversion process

## Files

### Input Files
- `cost-analysis.xlsx` - Source document for conversion

### Output Files
- `cost-analysis.pdf` - Converted output document

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
- Document loading using file path: `new XlsxToPdfConverter("cost-analysis.xlsx")`
- Basic conversion workflow
- File output

## Requirements

- .NET 6.0 or later
- GroupDocs.Conversion.LowCode package
- Valid GroupDocs license keys (Optional)

## Related Documentation

For more information about document conversion, see the [GroupDocs.Conversion.LowCode documentation](https://docs.groupdocs.net/conversion/developer-guide/). 
