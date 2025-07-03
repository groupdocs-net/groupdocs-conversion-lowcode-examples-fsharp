# Load from Stream

This example demonstrates how to load source documents from a stream using GroupDocs.Conversion.LowCode.

## Overview

This console application shows how to create a converter by loading the source document from a file stream.

## Purpose

This example demonstrates the **stream loading method**:
- Loading documents using file streams
- Memory-efficient approach for large files
- Suitable for processing files in memory
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
- File stream creation: `File.OpenRead("business-plan.docx")`
- Document loading using stream: `new DocxToPdfConverter(stream)`
- Basic conversion workflow
- File output

## Requirements

- .NET 6.0 or later
- GroupDocs.Conversion.LowCode package
- Valid GroupDocs license keys (Optional)

## Related Documentation

For more information about loading source documents, see the [GroupDocs.Conversion.LowCode documentation](https://docs.groupdocs.net/conversion/developer-guide/loading-source-documents/). 
