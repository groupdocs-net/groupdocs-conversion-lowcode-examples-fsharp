# Save to FilePath

This example demonstrates how to save converted documents to a file path using GroupDocs.Conversion.LowCode.

## Overview

This console application shows how to save converted documents by specifying the output file path.

## Purpose

This example demonstrates the **file path saving method**:
- Saving converted documents using a file path string
- Simple and straightforward approach
- Suitable for local file storage
- Basic DOCX to PDF conversion workflow

## Files

### Input Files
- `business-plan.docx` - Source document for conversion

### Output Files
- `business-plan.pdf` - Converted output document

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

The saving logic in `Program.fs` demonstrates:
- License setup from environment variables
- Document loading using file path: `new DocxToPdfConverter("business-plan.docx")`
- Saving to file path: `converter.Convert("business-plan.pdf")`
- Basic conversion workflow

## Requirements

- .NET 6.0 or later
- GroupDocs.Conversion.LowCode package
- Valid GroupDocs license keys (Optional)

## Related Documentation

For more information about saving converted documents, see the [GroupDocs.Conversion.LowCode documentation](https://docs.groupdocs.net/conversion/developer-guide/saving-converted-documents/). 
