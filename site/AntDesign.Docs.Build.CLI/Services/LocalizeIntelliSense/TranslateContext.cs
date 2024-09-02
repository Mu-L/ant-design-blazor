﻿using System.Globalization;

namespace IntelliSenseLocalizer.ThirdParty;

public class TranslateContext
{
    #region Public 属性

    public ContentCompareType ContentCompareType { get; }

    public IContentTranslator ContentTranslator { get; }

    public string FilePath { get; set; }

    public bool IsPatch { get; }

    public string OutputPath { get; }

    public int ParallelCount { get; set; } = 2;

    public string? SeparateLine { get; }

    public CultureInfo SourceCultureInfo { get; }

    public CultureInfo TargetCultureInfo { get; }

    #endregion Public 属性

    #region Public 构造函数

    public TranslateContext(string filePath, ContentCompareType contentCompareType, string? separateLine, string outputPath, CultureInfo sourceCultureInfo, CultureInfo targetCultureInfo, IContentTranslator contentTranslator, bool isPatch)
    {
        if (string.IsNullOrWhiteSpace(filePath))
        {
            throw new ArgumentException($"“{nameof(filePath)}”不能为 null 或空白。", nameof(filePath));
        }

        if (string.IsNullOrWhiteSpace(outputPath))
        {
            throw new ArgumentException($"“{nameof(outputPath)}”不能为 null 或空白。", nameof(outputPath));
        }

        FilePath = filePath;
        ContentCompareType = contentCompareType;
        OutputPath = outputPath;
        SeparateLine = separateLine;
        SourceCultureInfo = sourceCultureInfo ?? throw new ArgumentNullException(nameof(sourceCultureInfo));
        TargetCultureInfo = targetCultureInfo ?? throw new ArgumentNullException(nameof(targetCultureInfo));
        ContentTranslator = contentTranslator;
        IsPatch = isPatch;
    }

    #endregion Public 构造函数
}
