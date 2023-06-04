using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace FNChanger2
{
    public class RenameRule
    {
        public enum CaseRule
        {
            None,
            Word,
            Upper,
            Lower,
        }
        public enum DirectoryRule
        {
            None,
            ApplyToItself,
            ApplyToFiles,
            ApplyToFilesInSubDirectory,
        }

        public bool WithExtension { get; set; }
        public bool WithDirectory { get; set; }
        public int RemoveLeftLength { get; set; }
        public string AddLeft { get; set; }
        public int RemoveRightLength { get; set; }
        public string AddRight { get; set; }
        public string ReplaceFrom { get; set; }
        public string ReplaceTo { get; set; }
        public bool ReplaceRegex { get; set; }
        public Random Random { get; set; }
        public CaseRule Case { get; set; }
        public DirectoryRule Directory { get; set; }

        public int DefaultRandomDigits { get; set; } = 8;

        public string Apply(string filePath)
        {
            var folder = Path.GetDirectoryName(filePath);
            var filename = Path.GetFileNameWithoutExtension(filePath);
            var extension = Path.GetExtension(filePath);
            if (WithExtension)
            {
                filename += extension;
                extension = "";
            }
            if (WithDirectory)
            {
                filename = Path.Combine(folder, filename);
                folder = "";
            }
            if (RemoveLeftLength > 0 && filename.Length >= RemoveLeftLength)
            {
                filename = filename.Substring(RemoveLeftLength);
            }
            if (!string.IsNullOrEmpty(AddLeft))
            {
                filename = AddLeft + filename;
            }
            if (RemoveRightLength > 0 && filename.Length >= RemoveRightLength)
            {
                filename = filename.Substring(0, filename.Length - RemoveRightLength);
            }
            if (!string.IsNullOrEmpty(AddRight))
            {
                filename += AddRight;
            }
            if (!string.IsNullOrEmpty(ReplaceFrom))
            {
                if (!ReplaceRegex)
                {
                    filename = filename.Replace(ReplaceFrom, ReplaceTo);
                }
                else
                {
                    filename = Regex.Replace(filename, ReplaceFrom, ReplaceTo);
                }
            }
            filename = ReplaceRandomTags(filename, Random ?? new Random());
            switch (Case)
            {
                case CaseRule.None:
                    // 何もしない
                    break;
                case CaseRule.Word:
                    filename = Regex.Replace(filename, @"\w+", (Match m) =>
                    {
                        var match = m.Value;
                        return match.Substring(0, 1).ToUpper() + match.Substring(1).ToLower();
                    });
                    break;
                case CaseRule.Upper:
                    filename = filename.ToUpper();
                    break;
                case CaseRule.Lower:
                    filename = filename.ToLower();
                    break;
                default:
                    throw new InvalidOperationException("RenameRule.Caseが不正です。");
            }
            var newPath = Path.Combine(folder, filename + extension);
            return newPath;
        }

        public string ReplaceRandomTags(string filename, Random random)
        {
            int GetDigits(Match match)
            {
                var group = match.Groups["digits"];
                return group.Success ? int.Parse(group.Value) : DefaultRandomDigits;
            }

            var regex = new Regex(@"<random(-(?<digits>[1-9][0-9]?))?>");
            var matches = regex.Matches(filename);
            if (matches.Count == 0)
            {
                return filename;
            }

            var maxDigits = 0;
            foreach (Match match in matches)
            {
                var digits = GetDigits(match);
                if (digits > maxDigits)
                {
                    maxDigits = digits;
                }
            }

            var sb = new StringBuilder(maxDigits);
            for (int i = 0; i < maxDigits; i += 9)
            {
                sb.Append(random.Next(1000000000).ToString("000000000"));
            }
            var randomString = sb.ToString();

            return regex.Replace(filename, match => randomString.Substring(0, GetDigits(match)));
        }
    }
}
