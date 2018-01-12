﻿using System.Collections.Generic;
using System.Text.RegularExpressions;
using PowerPointLabs.Tags;

namespace PowerPointLabs.TagMatchers
{
    public class NoEffectTagMatcher : ITagMatcher
    {
        public Regex Regex { get { return new Regex(@"\[\[.*\]\]", RegexOptions.IgnoreCase); } }

        public List<ITag> Matches(string text)
        {
            var foundMatches = new List<ITag>();

            MatchCollection regexMatches = Regex.Matches(text);
            foreach (Match match in regexMatches)
            {
                var matchStart = match.Index;
                var matchEnd = match.Index + match.Length - 1; // 0-based indices.
                NoEffectTag tag = new NoEffectTag(matchStart, matchEnd, match.Value);
                foundMatches.Add(tag);
            }

            return foundMatches;
        }
    }
}
