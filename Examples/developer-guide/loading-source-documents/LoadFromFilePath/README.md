# Load from FilePath

This example demonstrates how to load source documents from a file path using GroupDocs.Conversion.LowCode.

## Overview

This console application shows how to create a converter by specifying the source document's file path.

## Purpose

This example demonstrates the **file path loading method**:
- Loading documents using a file path string
- Simple and straightforward approach
- Suitable for local file access
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

The loading logic in `Program.fs` demonstrates:
- License setup from environment variables
- Document loading using file path: `new DocxToPdfConverter("business-plan.docx")`
- Basic conversion workflow
- File output

## Requirements

- .NET 6.0 or later
- GroupDocs.Conversion.LowCode package
- Valid GroupDocs license keys (Optional)

## Related Documentation

For more information about loading source documents, see the [GroupDocs.Conversion.LowCode documentation](https://docs.groupdocs.net/conversion/developer-guide/loading-source-documents/). 
