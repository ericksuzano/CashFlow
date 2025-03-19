using MigraDoc.DocumentObjectModel;
using PdfSharp.Fonts;
using System.Reflection;

namespace CashFlow.Application.UseCases.Reports.Pdf.Fonts;
public class ExpensesReportFontResolver : IFontResolver
{
    public byte[]? GetFont(string faceName)
    {
        var stream = ReadFontFile(faceName);

        stream ??= ReadFontFile(FontHelper.DEFAULT_FONT); // "??=" faz o trabalho do IF

        var length = (int)stream!.Length;

        var data = new byte[length];

        stream.Read(buffer: data, offset: 0, count: length);

        return data;
    }

    public FontResolverInfo? ResolveTypeface(string familyName, bool bold, bool italic)
    {
        new Font
        {
            Name = FontHelper.RALEWAY_REGULAR

        };
        return new FontResolverInfo(familyName); // o hashtag "#" é para definir se você quer a fonte em Negrito/bold (#b), itálico/italic (#i) ou negrito e itálico (#bi)
    }

    private Stream? ReadFontFile(string faceName)
    {
        var assembly = Assembly.GetExecutingAssembly();

        return assembly.GetManifestResourceStream($"CashFlow.Application.UseCases.Reports.Pdf.Fonts{faceName}.ttf");
    }
}
