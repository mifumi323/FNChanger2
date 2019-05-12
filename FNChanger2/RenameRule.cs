using System;
using System.IO;
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
            filename = filename.Replace("<random>", (Random ?? new Random()).Next(100000000).ToString("00000000"));
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
    }
}
