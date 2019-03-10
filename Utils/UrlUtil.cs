using ExportProductsToExcelFiles.BiggBrands;
using System;
using System.Text.RegularExpressions;

namespace ExportProductsToExcelFiles.Utils
{
    public static class UrlUtil
    {
        public static UrlRecord CreateUrlRecordByEntityIdEntityName(int entityId, string entityName, string slugValue)
        {
            return new UrlRecord()
            {
                EntityId = entityId,
                EntityName = entityName,
                Slug = UrlUtil.ModifyUrl(slugValue),
                IsActive = true,
                LanguageId = 0,
            };
        }

        public static string ModifyUrl(string url)
        {
            url = url.ToLower();
            url = url.Trim();
            url = url.Replace(" ", "-");
            // url = url.Replace((char)13, (char)0).Replace((char)10, (char)0).Replace((char)9, (char)0);
            url = Regex.Replace(url, @"\t|\n|\r", "");
            url = url.Replace("/", "-");
            url = url.Replace("ı", "i");
            url = url.Replace("ç", "c");
            url = url.Replace("ğ", "g");
            url = url.Replace("ö", "o");
            url = url.Replace("ş", "s");
            url = url.Replace("ü", "u");
            url = url.Replace("\\", "-");
            url = url.Replace("^", "");
            url = url.Replace("&", "-");
            url = url.Replace("~", "");
            url = url.Replace("@", "");
            url = url.Replace("<", "");
            url = url.Replace(">", "");
            url = url.Replace("?", "_");
            url = url.Replace("(", "_");
            url = url.Replace(")", "_");
            url = url.Replace("{", "_");
            url = url.Replace("}", "_");
            url = url.Replace("[", "_");
            url = url.Replace("]", "_");
            url = url.Replace("%", "");
            url = url.Replace("|", "");
            url = url.Replace("\"", "");
            url = url.Replace("'", "");
            url = url.Replace("*", "");
            url = url.Replace("+", "");
            url = url.Replace(":", "-");
            url = url.Replace(";", "-");
            url = url.Replace(".", "-");
            url = url.Replace(",", "-");
            url = url.Trim();
            return url;
        }
    }
}
