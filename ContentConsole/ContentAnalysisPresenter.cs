﻿using System;
using NegativeContentService;

namespace ContentConsole
{
    public class ContentAnalysisPresenter
    {
        private readonly IDetectNegativeWordService _detectNegativeWordService;

        public ContentAnalysisPresenter(IDetectNegativeWordService detectNegativeWordService)
        {
            if (detectNegativeWordService == null)
                throw new ArgumentNullException(nameof(detectNegativeWordService));

            _detectNegativeWordService = detectNegativeWordService;
        }

        public string GetDetectedNegativeOutput(string content, bool isBadWordFilteringEnabled)
        {
            var result = _detectNegativeWordService.GetNegativeContentAnalysis(content);
            var outputContent = isBadWordFilteringEnabled ? result.SanitizedContent : result.OriginalContent;

            var consoleOutput = $"Scanned the text:\n{outputContent}\nTotal Number of negative words: {result.NumberOfBadWords}\nPress ANY key to exit.";

            return consoleOutput;
        }
    }
}
