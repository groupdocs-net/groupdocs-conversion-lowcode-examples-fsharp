# GroupDocs.Conversion.LowCode - F# Code Examples

This repository contains **69+ complete, runnable examples** demonstrating various features of [GroupDocs.Conversion.LowCode](https://nuget.org/packages/GroupDocs.Conversion.LowCode) for F# (.NET 6.0+). These examples provide practical implementations for document conversion scenarios.

## 📋 Overview

- **Package**: [GroupDocs.Conversion.LowCode](https://nuget.org/packages/GroupDocs.Conversion.LowCode)
- **Language**: F# (.NET 6.0+)
- **Docs**: https://docs.groupdocs.net/conversion/

## 📁 Directory Structure

The examples are organized to mirror the official documentation structure:

```
groupdocs-conversion-lowcode-examples-fsharp/
├── 📂 Examples/
│   ├── 📂 developer-guide/
│   │   ├── 📂 CopyTheCodeExample/
│   │   ├── 📂 loading-source-documents/
│   │   │   ├── 📂 LoadFromFilePath/
│   │   │   ├── 📂 LoadFromStream/
│   │   │   └── 📂 SetLoadOptions/
│   │   ├── 📂 saving-converted-documents/
│   │   │   ├── 📂 SaveToFilePath/
│   │   │   ├── 📂 SaveToStream/
│   │   │   └── 📂 SetConvertOptions/
│   │   ├── 📂 using-doc-to-pdf-converter/
│   │   │   ├── 📂 BasicExample/
│   │   │   ├── 📂 DocToPasswordProtectedPdf/
│   │   │   ├── 📂 DocToPdfaFormat/
│   │   │   ├── 📂 DocWithCommentsToPdfWithoutComments/
│   │   │   ├── 📂 DocWithTrackedChangesToPdf/
│   │   │   ├── 📂 ProtectedDocToPdf/
│   │   │   └── 📂 SpecificDocPagesToPdf/
│   │   ├── 📂 using-docx-to-pdf-converter/
│   │   │   ├── 📂 BasicExample/
│   │   │   ├── 📂 DocxToPasswordProtectedPdf/
│   │   │   ├── 📂 DocxWithCommentsToPdfWithoutComments/
│   │   │   ├── 📂 DocxWithTrackedChangesToPdf/
│   │   │   ├── 📂 ProtectedDocxToPdf/
│   │   │   └── 📂 SpecificDocxPagesToPdf/
│   │   ├── 📂 using-html-to-pdf-converter/
│   │   │   ├── 📂 BasicExample/
│   │   │   ├── 📂 HtmlToPasswordProtectedPdf/
│   │   │   ├── 📂 HtmlToPdfWithSpecificPdfFormat/
│   │   │   ├── 📂 HtmlWithCustomCssStyling/
│   │   │   ├── 📂 HtmlWithZoomLevel/
│   │   │   └── 📂 SkipExternalResourcesReferencedInHtml/
│   │   ├── 📂 using-pdf-to-docx-converter/
│   │   │   ├── 📂 BasicExample/
│   │   │   ├── 📂 FlattenFieldsInFormFillablePdf/
│   │   │   ├── 📂 PdfToDocxWithA4PageSize/
│   │   │   ├── 📂 PdfToPasswordProtectedDocx/
│   │   │   ├── 📂 PdfWithAnnotationsToDocxWithoutAnnotations/
│   │   │   └── 📂 ProtectedPdfToDocx/
│   │   ├── 📂 using-pdf-to-md-converter/
│   │   │   ├── 📂 BasicExample/
│   │   │   ├── 📂 FlattenFieldsInFormFillablePdf/
│   │   │   ├── 📂 PdfWithAnnotationsToMarkdownWithoutAnnotations/
│   │   │   ├── 📂 ProtectedPdfToMarkdown/
│   │   │   └── 📂 SkipImagesWhenConvertingPdfToMarkdown/
│   │   ├── 📂 using-pdf-to-pdfa-converter/
│   │   │   ├── 📂 BasicExample/
│   │   │   ├── 📂 FlattenFieldsInFormFillablePdf/
│   │   │   ├── 📂 PdfToPasswordProtectedPdfa/
│   │   │   ├── 📂 PdfWithAnnotationsToPdfaWithoutAnnotations/
│   │   │   ├── 📂 ProtectedPdfToPdfa/
│   │   │   └── 📂 SpecificPdfPagesToPdfa/
│   │   ├── 📂 using-ppt-to-pdf-converter/
│   │   │   ├── 📂 BasicExample/
│   │   │   ├── 📂 PptToPasswordProtectedPdf/
│   │   │   ├── 📂 PptWithHiddenSlides/
│   │   │   ├── 📂 PptWithPreservedDocumentStructureForAccessiblePdf/
│   │   │   ├── 📂 ProtectedPptToPdf/
│   │   │   └── 📂 SpecificPptSlidesToPdf/
│   │   ├── 📂 using-pptx-to-pdf-converter/
│   │   │   ├── 📂 BasicExample/
│   │   │   ├── 📂 PptxToPasswordProtectedPdf/
│   │   │   ├── 📂 PptxWithHiddenSlides/
│   │   │   ├── 📂 PreserveDocumentStructureForAccessiblePdf/
│   │   │   ├── 📂 ProtectedPptxToPdf/
│   │   │   └── 📂 SpecificPptxSlidesToPdf/
│   │   ├── 📂 using-xls-to-pdf-converter/
│   │   │   ├── 📂 BasicExample/
│   │   │   ├── 📂 ProtectedXlsToPdf/
│   │   │   ├── 📂 SpecificSheetsFromXlsToPdf/
│   │   │   ├── 📂 XlsToPasswordProtectedPdf/
│   │   │   ├── 📂 XlsToPdfWithSpecificPdfFormat/
│   │   │   └── 📂 XlsWithHiddenSheets/
│   │   └── 📂 using-xlsx-to-pdf-converter/
│   │       ├── 📂 BasicExample/
│   │       ├── 📂 ProtectedXlsxToPdf/
│   │       ├── 📂 SpecificSheetsFromXlsxToPdf/
│   │       ├── 📂 XlsxToPasswordProtectedPdf/
│   │       ├── 📂 XlsxToPdfWithSpecificPdfFormat/
│   │       └── 📂 XlsxWithHiddenSheetsToPdf/
│   └── 📂 licensing/
│       ├── 📂 SetLicenseFromFile/
│       └── 📂 SetLicenseKeys/
├── 📄 GroupDocs.Conversion.LowCode.Examples.sln
├── 📄 LICENSE
├── 📄 README.md
├── 🚀 run_all_examples.bat
├── 🚀 run_all_examples.ps1
└── 🚀 run_all_examples.sh
```

## 🎯 Example Categories

### **Licensing**
- **Set License Keys**: Programmatic license setup using keys
- **Set License From File**: License setup using license file

### **Developer Guide**

#### **Document Loading**
- **Load From FilePath**: Load documents using file paths
- **Load From Stream**: Load documents using file streams
- **Set Load Options**: Configure document loading options

#### **Document Saving**
- **Save To FilePath**: Save converted documents to file paths
- **Save To Stream**: Save converted documents to streams
- **Set Convert Options**: Configure conversion options

#### **Document Converters**
- **DOC to PDF**: Convert legacy Word documents to PDF
- **DOCX to PDF**: Convert modern Word documents to PDF
- **HTML to PDF**: Convert HTML files to PDF
- **PDF to DOCX**: Convert PDF to Word documents
- **PDF to Markdown**: Convert PDF to Markdown format
- **PDF to PDF/A**: Convert PDF to archival format
- **PPT to PDF**: Convert PowerPoint presentations to PDF
- **PPTX to PDF**: Convert modern PowerPoint presentations to PDF
- **XLS to PDF**: Convert legacy Excel spreadsheets to PDF
- **XLSX to PDF**: Convert modern Excel spreadsheets to PDF

## 🚀 How to Run Code Examples

### **Prerequisites**
- **.NET 6.0 or later** installed on your system
- **Valid GroupDocs license** (trial or commercial)
- **Sample files** (automatically included with examples)

### **Setup License**

#### **Option 1: Environment Variables (Recommended)**

```bash
# Windows
set GD_PUBLIC_KEY=your-public-key
set GD_PRIVATE_KEY=your-private-key

# Linux/macOS
export GD_PUBLIC_KEY=your-public-key
export GD_PRIVATE_KEY=your-private-key
```

#### **Option 2: Direct in Code**

Edit the `Program.fs` file and replace placeholder values:
```fsharp
let publicKey = "your-public-key"
let privateKey = "your-private-key"
```

> **Note:** Learn more about licensing at https://docs.groupdocs.net/conversion/licensing/.

### **Running Individual Examples**

1. **Navigate to any example directory:**
   ```bash
   cd Examples/developer-guide/using-docx-to-pdf-converter/BasicExample
   ```

2. **Restore dependencies (first time only):**
   ```bash
   dotnet restore
   ```

3. **Run the example:**
   ```bash
   dotnet run
   ```

4. **Check the output:**
   - Look for generated files in the example directory (or an `output` subfolder, if present)
   - Check console output for any errors or success messages

### **Running All Examples**

Use the provided scripts to run all examples sequentially:

#### **Windows (Command Prompt)**
```bash
run_all_examples.bat
```

#### **Windows (PowerShell)**
```powershell
./run_all_examples.ps1
```

#### **Linux/macOS**
```bash
./run_all_examples.sh
```

## 📝 Notes

- Examples are generated automatically from documentation
- Some examples may require specific sample files to be present
- Make sure to handle any exceptions that may occur during conversion
- Check the individual README files in each example directory for specific details

## 🆘 Support

For issues with the examples or GroupDocs.Conversion.LowCode, please refer to:
- [Documentation](https://docs.groupdocs.net/conversion/)
- [API Reference](https://reference.groupdocs.net/conversion/)
- [Free Suport Forum](https://forum.groupdocs.net/)
