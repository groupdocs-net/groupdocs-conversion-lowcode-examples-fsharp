# Save to Stream

This example demonstrates how to save converted documents to a stream using GroupDocs.Conversion.LowCode.

## Overview

This console application shows how to save converted documents by writing to a file stream.

## Purpose

This example demonstrates the **stream saving method**:
- Saving converted documents using file streams
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

The saving logic in `Program.fs` demonstrates:
- License setup from environment variables
- Input stream creation: `File.OpenRead("business-plan.docx")`
- Output stream creation: `File.Create("business-plan.pdf")`
- Document loading using stream: `new DocxToPdfConverter(inputStream)`
- Saving to stream: `converter.Convert(outputStream)`
- Automatic resource disposal with `use` bindings

## Requirements

- .NET 6.0 or later
- GroupDocs.Conversion.LowCode package
- Valid GroupDocs license keys (Optional)

## Related Documentation

For more information about saving converted documents, see the [GroupDocs.Conversion.LowCode documentation](https://docs.groupdocs.net/conversion/developer-guide/saving-converted-documents/). 
