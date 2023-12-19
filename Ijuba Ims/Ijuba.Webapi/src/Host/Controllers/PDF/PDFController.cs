using Ijuba.Webapi.Application.Catalog.Brands;
using Ijuba.Webapi.Application.IMS.Cash_Transaction;
using Ijuba.Webapi.Application.IMS.Customer;
using Ijuba.Webapi.Application.IMS.Interfaces;
using Ijuba.Webapi.Application.IMS.Invoice;
using Ijuba.Webapi.Application.IMS.Supplier;
using Ijuba.Webapi.Application.PDF;
using Ijuba.Webapi.Domain.IMS.Cash_Transaction;
using Ijuba.Webapi.Infrastructure.Persistence.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelectPdf;
using CsvHelper;
using System.Globalization;
using System.IO;

namespace Ijuba.Webapi.Host.Controllers.PDF;
[Route("api/[controller]")]
[ApiController]
public class PDFController : VersionNeutralApiController
{

    private readonly ApplicationDbContext _db;

    public PDFController(ApplicationDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    [Route("GetCashTillRecon")]
    [MustHavePermission(FSHAction.Search, FSHResource.PDF)]
    public async Task<PDFDto> GetCashTillRecon()
    {


        string pdf_page_size = "A4";
        PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
            pdf_page_size, true);


        string pdf_orientation = "Portrait";
        PdfPageOrientation pdfOrientation =
            (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
            pdf_orientation, true);

        int webPageWidth = 748;


        int webPageHeight = 0;

        PDFTemplate pdf = new PDFTemplate();

        var stringhtml = pdf.CashTillRecon();
        try
        {
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.MarginTop = 20;

            converter.Options.WebPageHeight = webPageHeight;
            converter.Options.ExternalLinksEnabled = true;

            converter.Options.EmbedFonts = true;
            converter.Options.KeepTextsTogether = true;

            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(stringhtml, "");
            doc.CompressionLevel = PdfCompressionLevel.NoCompression;

            MemoryStream stream = new MemoryStream();
            doc.Save(stream);

            doc.Close();
            stream.Position = 0;

            PDFDto dto = new PDFDto();
            dto.FileStreamResultArray = stream.ToArray();
            return dto;

        }
        catch (Exception ex)
        {

            throw ex;
        }

    }

    [HttpGet]
    [Route("GetReceiptPdf")]
    [MustHavePermission(FSHAction.Search, FSHResource.PDF)]
    public async Task<PDFDto> GetReceiptPdf()
    {


        string pdf_page_size = "A4";
        PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
            pdf_page_size, true);


        string pdf_orientation = "Portrait";
        PdfPageOrientation pdfOrientation =
            (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
            pdf_orientation, true);

        int webPageWidth = 748;


        int webPageHeight = 0;



        PDFTemplate pdf = new PDFTemplate();

        string stringhtml = pdf.ReceiptPDF();
        try
        {
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.MarginTop = 20;

            converter.Options.WebPageHeight = webPageHeight;
            converter.Options.ExternalLinksEnabled = true;

            converter.Options.EmbedFonts = true;
            converter.Options.KeepTextsTogether = true;

            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(stringhtml, "");
            doc.CompressionLevel = PdfCompressionLevel.NoCompression;

            MemoryStream stream = new MemoryStream();
            doc.Save(stream);

            doc.Close();
            stream.Position = 0;
            PDFDto dto = new PDFDto();
            dto.FileStreamResultArray = stream.ToArray();
            return dto;
        }
        catch (Exception ex)
        {

            throw ex;
        }

    }


    [HttpGet]
    [Route("GetTaxInvoicePdf")]
    [MustHavePermission(FSHAction.Search, FSHResource.PDF)]
    public async Task<PDFDto> GetTaxInvoicePdf()
    {


        string pdf_page_size = "A4";
        PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
            pdf_page_size, true);


        string pdf_orientation = "Portrait";
        PdfPageOrientation pdfOrientation =
            (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
            pdf_orientation, true);

        int webPageWidth = 748;
        int webPageHeight = 0;

        PDFTemplate pdf = new PDFTemplate();

        var stringhtml = pdf.TaxInvoicePDF();
        try
        {
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.MarginTop = 20;

            converter.Options.WebPageHeight = webPageHeight;
            converter.Options.ExternalLinksEnabled = true;

            converter.Options.EmbedFonts = true;
            converter.Options.KeepTextsTogether = true;

            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(stringhtml, "");
            doc.CompressionLevel = PdfCompressionLevel.NoCompression;

            MemoryStream stream = new MemoryStream();
            doc.Save(stream);

            doc.Close();
            stream.Position = 0;

            PDFDto dto = new PDFDto();
            dto.FileStreamResultArray = stream.ToArray();
            return dto;

        }
        catch (Exception ex)
        {

            throw ex;
        }

    }


    [HttpGet]
    [Route("GetGoodsReceivedPdf")]
    [MustHavePermission(FSHAction.Search, FSHResource.PDF)]
    public async Task<PDFDto> GetGoodsReceivedPdf()
    {


        string pdf_page_size = "A4";
        PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
            pdf_page_size, true);


        string pdf_orientation = "Portrait";
        PdfPageOrientation pdfOrientation =
            (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
            pdf_orientation, true);

        int webPageWidth = 748;


        int webPageHeight = 0;

        PDFTemplate pdf = new PDFTemplate();

        var stringhtml = pdf.GoodsRecievedPDF();
        try
        {
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.MarginTop = 20;

            converter.Options.WebPageHeight = webPageHeight;
            converter.Options.ExternalLinksEnabled = true;

            converter.Options.EmbedFonts = true;
            converter.Options.KeepTextsTogether = true;

            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(stringhtml, "");
            doc.CompressionLevel = PdfCompressionLevel.NoCompression;

            MemoryStream stream = new MemoryStream();
            doc.Save(stream);
            doc.Close();
            stream.Position = 0;

            PDFDto dto = new PDFDto();
            dto.FileStreamResultArray = stream.ToArray();
            return dto;

        }
        catch (Exception ex)
        {

            throw ex;
        }

    }


    [HttpPost]
    [Route("GetReceiptPdfTemplate")]
    [MustHavePermission(FSHAction.Create, FSHResource.Invoice)]
    public async Task<PDFDto> GetReceiptPdfTemplate(CustomerReceiptDto customerreceipt)
    {


        string pdf_page_size = "A4";
        PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
            pdf_page_size, true);


        string pdf_orientation = "Portrait";
        PdfPageOrientation pdfOrientation =
            (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
            pdf_orientation, true);

        int webPageWidth = 748;


        int webPageHeight = 0;



        PDFTemplate pdf = new PDFTemplate();

        var stringhtml = pdf.ReceiptPDFTemplate(customerreceipt.lineitemsdto);

        stringhtml = stringhtml.Replace("@CompanyName", customerreceipt.customerdto.CompanyName.ToString());
        stringhtml = stringhtml.Replace("@AddressLine1", customerreceipt.customerdto.AddressLine1.ToString());
        stringhtml = stringhtml.Replace("@AddressLine2", customerreceipt.customerdto.AddressLine2.ToString());
        stringhtml = stringhtml.Replace("@Suburb", customerreceipt.customerdto.Suburb.ToString());
        stringhtml = stringhtml.Replace("@City", customerreceipt.customerdto.City.ToString());
        stringhtml = stringhtml.Replace("@PostalCode", customerreceipt.customerdto.PostalCode.ToString());
        stringhtml = stringhtml.Replace("@Province", customerreceipt.customerdto.Province.ToString());

        stringhtml = stringhtml.Replace("@AccountNo", customerreceipt.customerdto.AccountNumber.ToString());
        stringhtml = stringhtml.Replace("@OrderNo", customerreceipt.invoicedto.InvoiceNo.ToString());
        stringhtml = stringhtml.Replace("@SalesRep", customerreceipt.customerdto.CustomerContactName.ToString());
        stringhtml = stringhtml.Replace("@Date", System.DateTime.Now.ToString("d"));
        stringhtml = stringhtml.Replace("@VendorNo", customerreceipt.customerdto.AccountNo.ToString());
        stringhtml = stringhtml.Replace("@VatNo", customerreceipt.customerdto.CustomerVatRegNo.ToString());
        stringhtml = stringhtml.Replace("@Warehouse", "1");

        stringhtml = stringhtml.Replace("@TotalsAmount", customerreceipt.invoicedto.TotalsAmount.ToString());
        stringhtml = stringhtml.Replace("@TotalsDiscount", customerreceipt.invoicedto.TotalsDiscount.ToString());
        stringhtml = stringhtml.Replace("@Freight", customerreceipt.invoicedto.Freight.ToString());
        stringhtml = stringhtml.Replace("@TotalsVat", customerreceipt.invoicedto.TotalsVat.ToString());
        stringhtml = stringhtml.Replace("@TotalDue", customerreceipt.invoicedto.TotalDue.ToString());



        try
        {
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.MarginTop = 20;

            converter.Options.WebPageHeight = webPageHeight;
            converter.Options.ExternalLinksEnabled = true;

            converter.Options.EmbedFonts = true;
            converter.Options.KeepTextsTogether = true;

            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(stringhtml, "");
            doc.CompressionLevel = PdfCompressionLevel.NoCompression;

            MemoryStream stream = new MemoryStream();
            doc.Save(stream);

            doc.Close();
            stream.Position = 0;
            PDFDto dto = new PDFDto();
            dto.FileStreamResultArray = stream.ToArray();
            return dto;
        }
        catch (Exception ex)
        {

            throw ex;
        }

    }

    [HttpPost]
    [Route("GetCashTillReconPdfTemplate")]
    [MustHavePermission(FSHAction.Create, FSHResource.Invoice)]
    public async Task<PDFDto> GetCashTillReconPdfTemplate(PrintCashTillReconDto datesdto)
    {

    
    DateTime MORNING = new DateTime(datesdto.startdate.Value.Year, datesdto.startdate.Value.Month, datesdto.startdate.Value.Day, 1, 0, 0);
    DateTime AFTERNOON = new DateTime(datesdto.enddate.Value.Year, datesdto.enddate.Value.Month, datesdto.enddate.Value.Day, 23, 0, 0); 
   



    var lstCashTrans = (from ct in _db.CashTransaction
                           join ctt in _db.CashTransactionType
                           on ct.CashTransactionTypeId equals ctt.Id
                           select new
                           {
                               CashTransactionTypeId = ctt.Id,
                               CashTransactionName = ctt.Name,
                               SystemTransaction = ctt.SystemTransaction,
                               TransactionDate = ct.TransactionDate,
                               Amount = ct.Amount,
                               Ref_id = ct.Ref_Id

                           }).ToList();



        var cashtotals = lstCashTrans
            .Where(z => z.TransactionDate >= MORNING && z.TransactionDate <= AFTERNOON)
            .Where(t => new[] {"INT","SAL","BDP","MAN"}.Contains(t.CashTransactionName))
            .Sum(x => x.Amount);

        var refunds = lstCashTrans
            .Where(z => z.TransactionDate >= MORNING && z.TransactionDate <= AFTERNOON)
            .Where(t => new[] { "REF" }.Contains(t.CashTransactionName))
            .Sum(x => x.Amount);

        var cashfloat = lstCashTrans
           .Where(z => z.TransactionDate >= MORNING && z.TransactionDate <= AFTERNOON)
           .Where(t => new[] { "INT" }.Contains(t.CashTransactionName))
           .Sum(x => x.Amount);

        var electronictransfer = lstCashTrans
          .Where(z => z.TransactionDate >= MORNING && z.TransactionDate <= AFTERNOON)
          .Where(t => new[] { "BDP" }.Contains(t.CashTransactionName))
          .Sum(x => x.Amount);

        string pdf_page_size = "A4";
        PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
            pdf_page_size, true);


        string pdf_orientation = "Portrait";
        PdfPageOrientation pdfOrientation =
            (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
            pdf_orientation, true);

        int webPageWidth = 748;


        int webPageHeight = 0;



        PDFTemplate pdf = new PDFTemplate();

        var stringhtml = pdf.CashTillReconPDFTemplate();

        stringhtml = stringhtml.Replace("@DateToday", System.DateTime.Now.ToString("d"));
        stringhtml = stringhtml.Replace("@DateFrom", datesdto.startdate.Value.ToString("d"));
        stringhtml = stringhtml.Replace("@DateTo", datesdto.enddate.Value.ToString("d"));
        stringhtml = stringhtml.Replace("@CashTotal", Math.Round(cashtotals).ToString());
        stringhtml = stringhtml.Replace("@CashFloat", Math.Round(cashfloat).ToString());
        stringhtml = stringhtml.Replace("@ElectronicTransfers", Math.Round(electronictransfer).ToString());
        stringhtml = stringhtml.Replace("@TotalInTill", Math.Round(cashtotals).ToString());

        stringhtml = stringhtml.Replace("@TotalRefunds", Math.Round(refunds).ToString());
        



        try
        {
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.MarginTop = 20;

            converter.Options.WebPageHeight = webPageHeight;
            converter.Options.ExternalLinksEnabled = true;

            converter.Options.EmbedFonts = true;
            converter.Options.KeepTextsTogether = true;

            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(stringhtml, "");
            doc.CompressionLevel = PdfCompressionLevel.NoCompression;

            MemoryStream stream = new MemoryStream();
            doc.Save(stream);

            doc.Close();
            stream.Position = 0;
            PDFDto dto = new PDFDto();
            dto.FileStreamResultArray = stream.ToArray();
            return dto;
        }
        catch (Exception ex)
        {

            throw ex;
        }

    }

    [HttpPost]
    [Route("GetDeliveryNotePdfTemplate")]
    [MustHavePermission(FSHAction.Create, FSHResource.Invoice)]
    public async Task<PDFDto> GetDeliveryNotePdfTemplate(CustomerReceiptDto customerreceipt)
    {


        string pdf_page_size = "A4";
        PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
            pdf_page_size, true);


        string pdf_orientation = "Portrait";
        PdfPageOrientation pdfOrientation =
            (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
            pdf_orientation, true);

        int webPageWidth = 748;


        int webPageHeight = 0;



        PDFTemplate pdf = new PDFTemplate();

        var stringhtml = pdf.DeliveryNotePDFTemplate(customerreceipt.lineitemsdto);

        stringhtml = stringhtml.Replace("@CompanyName", customerreceipt.customerdto.CompanyName.ToString());
        stringhtml = stringhtml.Replace("@AddressLine1", customerreceipt.customerdto.AddressLine1.ToString());
        stringhtml = stringhtml.Replace("@AddressLine2", customerreceipt.customerdto.AddressLine2.ToString());
        stringhtml = stringhtml.Replace("@Suburb", customerreceipt.customerdto.Suburb.ToString());
        stringhtml = stringhtml.Replace("@City", customerreceipt.customerdto.City.ToString());
        stringhtml = stringhtml.Replace("@PostalCode", customerreceipt.customerdto.PostalCode.ToString());
        stringhtml = stringhtml.Replace("@Province", customerreceipt.customerdto.Province.ToString());

        stringhtml = stringhtml.Replace("@AccountNo", customerreceipt.customerdto.AccountNumber.ToString());
        stringhtml = stringhtml.Replace("@OrderNo", customerreceipt.invoicedto.InvoiceNo.ToString());
        stringhtml = stringhtml.Replace("@SalesRep", customerreceipt.customerdto.CustomerContactName.ToString());
        stringhtml = stringhtml.Replace("@Date", System.DateTime.Now.ToString("d"));
        stringhtml = stringhtml.Replace("@VendorNo", customerreceipt.customerdto.AccountNo.ToString());
        stringhtml = stringhtml.Replace("@VatNo", customerreceipt.customerdto.CustomerVatRegNo.ToString());
        stringhtml = stringhtml.Replace("@Warehouse", "1");


        try
        {
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.MarginTop = 20;

            converter.Options.WebPageHeight = webPageHeight;
            converter.Options.ExternalLinksEnabled = true;

            converter.Options.EmbedFonts = true;
            converter.Options.KeepTextsTogether = true;

            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(stringhtml, "");
            doc.CompressionLevel = PdfCompressionLevel.NoCompression;

            MemoryStream stream = new MemoryStream();
            doc.Save(stream);

            doc.Close();
            stream.Position = 0;
            PDFDto dto = new PDFDto();
            dto.FileStreamResultArray = stream.ToArray();
            return dto;
        }
        catch (Exception ex)
        {

            throw ex;
        }

    }


    [HttpPost]
    [Route("GenerateCSV")]
    [MustHavePermission(FSHAction.Create, FSHResource.Invoice)]
    public async Task<PDFDto> GenerateCSV(List<CashTransactionDto> lstCashTranTypes)
    {
        try
        {
            //using (var writer = new StreamWriter(@"C:\pdf\test.csv"))
            //using (var csv = new CsvWriter(writer, invC))
            //{
            //    csv.WriteRecords(lstCashTranTypes);
            //}

            CultureInfo invC = CultureInfo.InvariantCulture;

            using (var memoryStream = new MemoryStream())
            {
                using (var streamWriter = new StreamWriter(memoryStream))
                using (var csvWriter = new CsvWriter(streamWriter, invC))
                {
                    csvWriter.WriteRecords<CashTransactionDto>(lstCashTranTypes);
                    memoryStream.Position = 0;
                } // StreamWriter gets flushed here.

                
                PDFDto dto = new PDFDto();
                dto.FileStreamResultArray = memoryStream.ToArray();

                return dto;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }


        //string pdf_page_size = "A4";
        //PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
        //    pdf_page_size, true);


        //string pdf_orientation = "Portrait";
        //PdfPageOrientation pdfOrientation =
        //    (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
        //    pdf_orientation, true);

        //int webPageWidth = 748;


        //int webPageHeight = 0;



        //PDFTemplate pdf = new PDFTemplate();

        //var stringhtml = pdf.DeliveryNotePDFTemplate(customerreceipt.lineitemsdto);

        //stringhtml = stringhtml.Replace("@CompanyName", customerreceipt.customerdto.CompanyName.ToString());
        //stringhtml = stringhtml.Replace("@AddressLine1", customerreceipt.customerdto.AddressLine1.ToString());
        //stringhtml = stringhtml.Replace("@AddressLine2", customerreceipt.customerdto.AddressLine2.ToString());
        //stringhtml = stringhtml.Replace("@Suburb", customerreceipt.customerdto.Suburb.ToString());
        //stringhtml = stringhtml.Replace("@City", customerreceipt.customerdto.City.ToString());
        //stringhtml = stringhtml.Replace("@PostalCode", customerreceipt.customerdto.PostalCode.ToString());
        //stringhtml = stringhtml.Replace("@Province", customerreceipt.customerdto.Province.ToString());

        //stringhtml = stringhtml.Replace("@AccountNo", customerreceipt.customerdto.AccountNumber.ToString());
        //stringhtml = stringhtml.Replace("@OrderNo", customerreceipt.invoicedto.InvoiceNo.ToString());
        //stringhtml = stringhtml.Replace("@SalesRep", customerreceipt.customerdto.CustomerContactName.ToString());
        //stringhtml = stringhtml.Replace("@Date", System.DateTime.Now.ToString("d"));
        //stringhtml = stringhtml.Replace("@VendorNo", customerreceipt.customerdto.AccountNo.ToString());
        //stringhtml = stringhtml.Replace("@VatNo", customerreceipt.customerdto.CustomerVatRegNo.ToString());
        //stringhtml = stringhtml.Replace("@Warehouse", "1");


        //try
        //{
        //    SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();
        //    converter.Options.PdfPageSize = pageSize;
        //    converter.Options.PdfPageOrientation = pdfOrientation;
        //    converter.Options.WebPageWidth = webPageWidth;
        //    converter.Options.MarginTop = 20;

        //    converter.Options.WebPageHeight = webPageHeight;
        //    converter.Options.ExternalLinksEnabled = true;

        //    converter.Options.EmbedFonts = true;
        //    converter.Options.KeepTextsTogether = true;

        //    SelectPdf.PdfDocument doc = converter.ConvertHtmlString(stringhtml, "");
        //    doc.CompressionLevel = PdfCompressionLevel.NoCompression;

        //    MemoryStream stream = new MemoryStream();
        //    doc.Save(stream);

        //    doc.Close();
        //    stream.Position = 0;
        //    PDFDto dto = new PDFDto();
        //    dto.FileStreamResultArray = stream.ToArray();\


        //    return dto;
        //}
        //catch (Exception ex)
        //{

        //    throw ex;
        //}

    }

}
