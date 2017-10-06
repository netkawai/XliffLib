﻿using Localization.Xliff.OM.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XliffLib.Utils
{
    public static class ListResourceStringContentExtensions
    {
        public static string ConvertToHtml(this IList<ResourceStringContent> xliffValue)
        {
            var sb = new StringBuilder();
            foreach (var item in xliffValue)
            {
                switch (item.GetType().Name)
                {
                    case nameof(PlainText):
                        var text = item as PlainText;
                        sb.Append(text.Text);
                        break;
                    case nameof(SpanningCode):
                        var pc = item as SpanningCode;
                        sb.Append(pc.Text);
                        break;
                }
            }
            return sb.ToString();
        }
    }
}