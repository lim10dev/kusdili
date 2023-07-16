using System.Text;

namespace kusdili_winforms
{
    internal class KuşDiliÇevirici
    {
        public static readonly char[] SesliHarfler = { 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };

        public static string KuşDilineÇevir(string çevrilen, string araHarfler)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < çevrilen.Length; i++)
            {
                var harf = çevrilen[i];
                var harfBüyükMü = char.IsUpper(harf);
                var sonrakiHarfBüyükMü = (i + 1 < çevrilen.Length) ? char.IsUpper(çevrilen[i + 1]) || !char.IsLetterOrDigit(çevrilen[i + 1]) : true;

                var sesliHarfMi = SesliHarfMi(harf);

                if (sesliHarfMi)
                {
                    /*
                        AA -> AGAAGA, harfBüyükMü: true,  sonrakiHarfBüyükMü: true
                        Aa -> Agaaga, harfBüyükMü: true,  sonrakiHarfBüyükMü: false
                        aA -> agaAGA, harfBüyükMü: false, sonrakiHarfBüyükMü: true
                        aa -> agaaga, harfBüyükMü: false, sonrakiHarfBüyükMü: false
                     */
                    var sonuç = $"{harf}{araHarfler}{harf}";

                    if (!harfBüyükMü) { sb.Append(sonuç.ToLower()); continue; }

                    if (sonrakiHarfBüyükMü) { sb.Append(sonuç.ToUpper()); continue; }

                    var sb2 = new StringBuilder(sonuç.ToLower());
                    sb2.Remove(0, 1).Insert(0, harf);
                    sb.Append(sb2);
                }
                else
                {
                    sb.Append(harf);
                }


            }

            return sb.ToString();
        }

        public static string KuşDilindenÇevir(string çevrilen, string araHarfler)
        {
            var sb = new StringBuilder();
            var araHarfUzunluğu = araHarfler.Length;

            for (int i = 0; i < çevrilen.Length; i++)
            {
                var harf = çevrilen[i];

                sb.Append(harf);

                if (SesliHarfMi(harf))
                {
                    i += araHarfUzunluğu + 1;
                }
            }

            return sb.ToString();
        }

        public static bool SesliHarfMi(char harf)
        {
            return char.IsLetterOrDigit(harf) && Array.Exists(SesliHarfler, x => x == char.ToLower(harf));
        }
    }
}
