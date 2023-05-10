using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QuestPDF.Helpers;

namespace QuestPDF_POC.Components
{
    public class Content
    {
        const string textColorPrimary = "#001F44";
        const string textColorSecondary = "#9e9e9e";
        const string textColorTertiary = "#1B8F3C";
        private TableCell _tableCell;

        public Content(TableCell tableCell)
        {
            _tableCell = tableCell;
        }
        public void ComposeContent(IContainer container)
        {
            container
                .PaddingTop(1, Unit.Centimetre)
                .Column(col =>
                {
                    col.Spacing(10);
                    /* Title + Note */
                    col.Item().Row(row =>
                    {
                        row.RelativeItem(2).Column(col =>
                        {
                            col.Item().Text("Introduction of automation in a company, study on its effects on the work and teh workers")
                                .FontColor(textColorPrimary)
                                .FontSize(16)
                                .ExtraBold();
                        });
                        row.RelativeItem().Border(1, Unit.Point).BorderColor(textColorPrimary).Row(note =>
                        {
                            note.RelativeItem().AlignCenter().PaddingTop(5, Unit.Millimetre)
                                .Text("Note finale")
                                .FontColor(textColorPrimary)
                                .FontSize(14);
                            note.RelativeItem().AlignCenter().PaddingTop(5, Unit.Millimetre)
                                .Text("15/20")
                                .FontColor(textColorPrimary)
                                .FontSize(14)
                                .ExtraBold();
                        });
                    });

                    /* Barème + Décision */
                    col.Item().Row(row =>
                    {
                        row.RelativeItem(2).AlignBottom().Text("1=Insufisant, 2=Faible, 3=Moyen, 4=Bien, 5=Très bien")
                                .FontColor(textColorSecondary)
                                .FontSize(12);
                        row.RelativeItem().Column(c =>
                        {
                            c.Item().Text("Décision du jury")
                                .FontColor(textColorSecondary)
                                .FontSize(12);
                            c.Item().Text("Soutenance validée")
                                .FontColor(textColorTertiary)
                                .FontSize(14)
                                .Bold();
                        });
                    });

                    /* Tableau */
                    col.Item().Row(row =>
                    {
                        // row.Spacing(15);
                        row.RelativeItem(2).PaddingRight(10, Unit.Millimetre).Table(qcm =>
                        {
                            qcm.ColumnsDefinition(col =>
                            {
                                col.RelativeColumn(300);
                                col.RelativeColumn(30);
                                col.RelativeColumn(30);
                                col.RelativeColumn(30);
                                col.RelativeColumn(30);
                                col.RelativeColumn(30);
                            });

                            /* Ligne 1 */
                            qcm.Cell().Row(1).Column(1).Text("Profil").FontColor(textColorPrimary).FontSize(14).ExtraBold();
                            qcm.Cell().Row(1).Column(2).AlignCenter().Text("1").FontColor(textColorPrimary).FontSize(14).ExtraBold();
                            qcm.Cell().Row(1).Column(3).AlignCenter().Text("2").FontColor(textColorPrimary).FontSize(14).ExtraBold();
                            qcm.Cell().Row(1).Column(4).AlignCenter().Text("3").FontColor(textColorPrimary).FontSize(14).ExtraBold();
                            qcm.Cell().Row(1).Column(5).AlignCenter().Text("4").FontColor(textColorPrimary).FontSize(14).ExtraBold();
                            qcm.Cell().Row(1).Column(6).AlignCenter().Text("5").FontColor(textColorPrimary).FontSize(14).ExtraBold();
                        
                            /* Ligne 2 */
                            qcm.Cell().Row(2).ColumnSpan(6).LineHorizontal(1, Unit.Point).LineColor(textColorPrimary);

                            /* Ligne 3 */
                            _tableCell.TableCellTitle(qcm, 3, "Ambition et complexité du projet");
                            _tableCell.TableCellContent(qcm, 3, 2, "assets\\Empty-square.png");
                            _tableCell.TableCellContent(qcm, 3, 3, "assets\\Empty-square.png");
                            _tableCell.TableCellContent(qcm, 3, 4, "assets\\Empty-square.png");
                            _tableCell.TableCellContent(qcm, 3, 5, "assets\\Empty-square.png");
                            _tableCell.TableCellContent(qcm, 3, 6, "assets\\Empty-square.png");

                            /* Ligne 4 */
                            qcm.Cell().Row(4).ColumnSpan(6).LineHorizontal(1, Unit.Point).LineColor(textColorSecondary);

                            /* Ligne 5 */
                            _tableCell.TableCellTitle(qcm, 5, "Capacité à juger de l’interêt et de la pertinence des problèmes soulevés (problématique)");
                            _tableCell.TableCellContent(qcm, 5, 2, "assets\\Empty-square.png");
                            _tableCell.TableCellContent(qcm, 5, 3, "assets\\Empty-square.png");
                            _tableCell.TableCellContent(qcm, 5, 4, "assets\\Empty-square.png");
                            _tableCell.TableCellContent(qcm, 5, 5, "assets\\Checked-square.png");
                            _tableCell.TableCellContent(qcm, 5, 6, "assets\\Empty-square.png");

                            /* Ligne 6 */
                            qcm.Cell().Row(6).ColumnSpan(6).LineHorizontal(1, Unit.Point).LineColor(textColorSecondary);

                            /* Ligne 7 */
                            _tableCell.TableCellTitle(qcm, 7, "Cohérence dans la démonstration et l’originalité de la méthodologie choisie");
                            _tableCell.TableCellContent(qcm, 7, 2, "assets\\Empty-square.png");
                            _tableCell.TableCellContent(qcm, 7, 3, "assets\\Empty-square.png");
                            _tableCell.TableCellContent(qcm, 7, 4, "assets\\Checked-square.png");
                            _tableCell.TableCellContent(qcm, 7, 5, "assets\\Empty-square.png");
                            _tableCell.TableCellContent(qcm, 7, 6, "assets\\Empty-square.png");

                            /* Ligne 8 */
                            qcm.Cell().Row(8).ColumnSpan(6).LineHorizontal(1, Unit.Point).LineColor(textColorSecondary);

                            /* Ligne 9 */
                            _tableCell.TableCellTitle(qcm, 9, "Capacité à mener à bien le projet de recherche de manière autonome");
                            _tableCell.TableCellContent(qcm, 9, 2, "assets\\Empty-square.png");
                            _tableCell.TableCellContent(qcm, 9, 3, "assets\\Empty-square.png");
                            _tableCell.TableCellContent(qcm, 9, 4, "assets\\Empty-square.png");
                            _tableCell.TableCellContent(qcm, 9, 5, "assets\\Empty-square.png");
                            _tableCell.TableCellContent(qcm, 9, 6, "assets\\Empty-square.png");

                            /* Ligne 10 */
                            qcm.Cell().Row(10).ColumnSpan(6).LineHorizontal(1, Unit.Point).LineColor(textColorSecondary);

                            /* Ligne 11 */
                            _tableCell.TableCellTitle(qcm, 11, "Capacité à aborder et traiter l’ensemble des aspects relatifs aux problèmes soulevés");
                            _tableCell.TableCellContent(qcm, 11, 2, "assets\\Empty-square.png");
                            _tableCell.TableCellContent(qcm, 11, 3, "assets\\Empty-square.png");
                            _tableCell.TableCellContent(qcm, 11, 4, "assets\\Empty-square.png");
                            _tableCell.TableCellContent(qcm, 11, 5, "assets\\Empty-square.png");
                            _tableCell.TableCellContent(qcm, 11, 6, "assets\\Empty-square.png");

                            /* Ligne 12 */
                            qcm.Cell().Row(12).ColumnSpan(6).LineHorizontal(1, Unit.Point).LineColor(textColorSecondary);

                            /* Ligne 13 */
                            _tableCell.TableCellTitle(qcm, 13, "Capacité de synthèse");
                            _tableCell.TableCellContent(qcm, 13, 2, "assets\\Empty-square.png");
                            _tableCell.TableCellContent(qcm, 13, 3, "assets\\Empty-square.png");
                            _tableCell.TableCellContent(qcm, 13, 4, "assets\\Empty-square.png");
                            _tableCell.TableCellContent(qcm, 13, 5, "assets\\Empty-square.png");
                            _tableCell.TableCellContent(qcm, 13, 6, "assets\\Empty-square.png");
                        });

                        row.RelativeItem().AlignMiddle().Column(col =>
                        {
                            col.Spacing(10);
                            col.Item().Column(c =>
                            {
                                c.Item()
                                    .Text("Commentaires et recommandations")
                                    .FontColor(textColorSecondary)
                                    .FontSize(12);
                                c.Item()
                                    .Text("La méthodologie utilisée est solide, mais il serait intéressant d'inclure des comparaisons avec des approches alternatives pour renforcer les résultats.")
                                    .FontSize(10);
                                c.Item()
                                    .Text("Les analyses statistiques pourraient être plus approfondies et mieux justifiées.")
                                    .FontSize(10);
                                c.Item()
                                    .Text("Les hypothèses sous-jacentes à l'analyse sont clairement définies et justifiées.")
                                    .FontSize(10);
                            });
                            col.Item().Column(c =>
                            {
                                c.Spacing(10);
                                c.Item()
                                    .Text("Noms, prénoms et signatures des membres du jury")
                                    .FontColor(textColorSecondary)
                                    .FontSize(12);
                                
                                c.Item().Row(r =>
                                {
                                    r.RelativeItem().Column(c =>
                                    {
                                        c.Item().Text("Jury 1").FontSize(12).FontColor(textColorSecondary);
                                        c.Item().Text(Placeholders.Name()).FontSize(10);
                                    });
                                    r.RelativeItem()
                                        .Border(1, Unit
                                        .Point)
                                        .BorderColor(textColorPrimary)
                                        .AlignCenter()
                                        .AlignMiddle()
                                        .Text("SIGNATURE")
                                        .FontColor(textColorPrimary)
                                        .FontSize(14);
                                });

                                c.Item().Row(r =>
                                {
                                    r.RelativeItem().Column(c =>
                                    {
                                        c.Item().Text("Jury 2").FontSize(12).FontColor(textColorSecondary);
                                        c.Item().Text(Placeholders.Name()).FontSize(10);
                                    });
                                    r.RelativeItem()
                                        .Border(1, Unit
                                        .Point)
                                        .BorderColor(textColorPrimary)
                                        .AlignCenter()
                                        .AlignMiddle()
                                        .Text("SIGNATURE")
                                        .FontColor(textColorPrimary)
                                        .FontSize(14);
                                });

                                c.Item().Row(r =>
                                {
                                    r.RelativeItem().Column(c =>
                                    {
                                        c.Item().Text("Jury 3").FontSize(12).FontColor(textColorSecondary);
                                        c.Item().Text(Placeholders.Name()).FontSize(10);
                                    });
                                    r.RelativeItem()
                                        .Border(1, Unit
                                        .Point)
                                        .BorderColor(textColorPrimary)
                                        .AlignCenter()
                                        .AlignMiddle()
                                        .Text("SIGNATURE")
                                        .FontColor(textColorPrimary)
                                        .FontSize(14);
                                });
                            });
                        });
                    });
                });
        }
    }
}