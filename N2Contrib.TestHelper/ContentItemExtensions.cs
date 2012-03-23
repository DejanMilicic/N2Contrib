﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using N2;

namespace N2Contrib.TestHelper
{
    public static class ContentItemExtensions
    {
        public static T AddChildren<T>(this T page, params ContentItem [] children)
            where T : ContentItem
        {
            if (children == null)
                throw new ArgumentNullException("children");

            foreach (var child in children)
                page.Children.Add(child);

            return page;
        }

        public static T AddChild<T>(this T page, ContentItem child)
            where T : ContentItem
        {
            page.Children.Add(child);
            return page;
        }
    }
}