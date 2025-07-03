# Set Convert Options

This example demonstrates how to set convert options when saving converted documents using GroupDocs.Conversion.LowCode.

## Overview

This console application shows how to save converted documents with custom conversion options, specifically for converting specific pages.

## Purpose

This example demonstrates the **convert options configuration**:
- Setting specific pages for conversion
- Customizing conversion behavior
- Page range selection
- Basic DOCX to PDF conversion workflow

## Files

### Input Files
- `business-plan.docx` - Source document for conversion

### Output Files
- `pages-1-2-3.pdf` - Converted output document (first three pages only)

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
- Document loading using file path: `new DocxToPdfConverter("business-plan.docx")`
- Setting convert options: `converter.Convert("pages-1-2-3.pdf", fun convertOptions -> convertOptions.Pages <- List<int>([1; 2; 3]))`
- Page range configuration
- Basic conversion workflow

## Requirements

- .NET 6.0 or later
- GroupDocs.Conversion.LowCode package
- Valid GroupDocs license keys (Optional)

## Related Documentation

For more information about saving converted documents, see the [GroupDocs.Conversion.LowCode documentation](https://docs.groupdocs.net/conversion/developer-guide/saving-converted-documents/). 
