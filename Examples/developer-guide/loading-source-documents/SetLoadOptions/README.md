# Set Load Options

This example demonstrates how to set load options when loading source documents using GroupDocs.Conversion.LowCode.

## Overview

This console application shows how to create a converter with custom load options, specifically for handling password-protected documents.

## Purpose

This example demonstrates the **load options configuration**:
- Setting password for protected documents
- Customizing document loading behavior
- Handling encrypted files
- Basic DOCX to PDF conversion workflow

## Files

### Input Files
- `protected.docx` - Password-protected source document for conversion

### Output Files
- `not-protected.pdf` - Converted output document

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
- Document loading with load options: `new DocxToPdfConverter("protected.docx", fun options -> options.Password <- "12345")`
- Password configuration for protected documents
- Basic conversion workflow
- File output

## Requirements

- .NET 6.0 or later
- GroupDocs.Conversion.LowCode package
- Valid GroupDocs license keys (Optional)

## Related Documentation

For more information about loading source documents, see the [GroupDocs.Conversion.LowCode documentation](https://docs.groupdocs.net/conversion/developer-guide/loading-source-documents/). 
