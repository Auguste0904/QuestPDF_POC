using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace QuestPDF_POC.Components
{
    public class TableCell
    {
        const string textColorPrimary = "#001F44";

        public void TableCellTitle(TableDescriptor qcm, ushort nbRow, string title)
        {
            qcm.Cell().Row(nbRow).Column(1).Text(title).FontColor(textColorPrimary).FontSize(12);
        }

        public void TableCellContent(TableDescriptor qcm, ushort nbRow, ushort nbColumn, string imgPath)
        {
            qcm.Cell().Row(nbRow).Column(nbColumn).AlignCenter().AlignMiddle().MaxWidth(5, Unit.Millimetre).Image(imgPath, ImageScaling.FitArea);
            qcm.Cell().Row(nbRow).Column(nbColumn).AlignCenter().AlignMiddle().MaxWidth(5, Unit.Millimetre).Image(imgPath, ImageScaling.FitArea);
            qcm.Cell().Row(nbRow).Column(nbColumn).AlignCenter().AlignMiddle().MaxWidth(5, Unit.Millimetre).Image(imgPath, ImageScaling.FitArea);
            qcm.Cell().Row(nbRow).Column(nbColumn).AlignCenter().AlignMiddle().MaxWidth(5, Unit.Millimetre).Image(imgPath, ImageScaling.FitArea);
            qcm.Cell().Row(nbRow).Column(nbColumn).AlignCenter().AlignMiddle().MaxWidth(5, Unit.Millimetre).Image(imgPath, ImageScaling.FitArea);
        }
    }
}