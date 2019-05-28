﻿using Kentico.PageBuilder.Web.Mvc;

namespace Models.Widgets
{
    /// <summary>
    /// Properties for Text widget.
    /// </summary>
    public class TextWidgetProperties : IWidgetProperties
    {
        /// <summary>
        /// HTML formatted text.
        /// </summary>
        public string Text { get; set; }
    }
}