using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using QuestPDF_POC.Components;

public class MyPDF
{
    private Header _header;
    private Content _content;
    public MyPDF(Header header, Content content)
    {
        _header = header;
        _content = content;
    }
    
    public void CreatePDF()
    {
        Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4.Landscape());
                page.Margin(1, Unit.Centimetre);
                page.PageColor(Colors.White);
                page.DefaultTextStyle(x => x.FontSize(12));

                page.Header().Element(_header.ComposeHeader);
                page.Content().Element(_content.ComposeContent);
            });
        }).ShowInPreviewer();
        // .GeneratePdf("DATEJOUR_NOM_PRENOM_SOUTENANCE.pdf");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        var tableCell = new TableCell();
        var header = new Header();
        var content = new Content(tableCell);
        var myPDF = new MyPDF(header, content);

        myPDF.CreatePDF();
    }
}