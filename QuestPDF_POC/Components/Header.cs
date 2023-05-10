using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QuestPDF.Helpers;

namespace QuestPDF_POC.Components
{
    public class Header
    {
        const string textColorPrimary = "#001F44";

        public void ComposeHeader(IContainer container)
        {
            container
                .Column(col =>
                {
                    col.Spacing(10);
                    col.Item().Row(row =>
                    {
                        row.RelativeItem(3).AlignMiddle().Text(text =>
                        {
                            text.Span("Mémoire / ").FontSize(20).FontColor(textColorPrimary);
                            text.Span("Evaluation de la soutenance").ExtraBold().FontSize(20).FontColor(textColorPrimary);
                        });
                        row.RelativeItem().Image("assets\\Logo-IESEG.png", ImageScaling.FitArea);
                    });
                    col.Item().Row(row =>
                    {
                        row.RelativeItem(6).Text(Placeholders.Name())
                            .FontSize(14)
                            .Bold()
                            .FontColor(textColorPrimary);
                        row.RelativeItem(4).Text(Placeholders.ShortDate())
                            .FontSize(14)
                            .FontColor(textColorPrimary);
                    });
                });
        }
    }
}