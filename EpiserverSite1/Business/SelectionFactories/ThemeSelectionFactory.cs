﻿using EPiServer.Shell.ObjectEditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiserverSite1.Business.SelectionFactories
{
    public class ThemeSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return new List<SelectItem> {
                new SelectItem { Value = "theme1", Text = "Orange" },
                new SelectItem { Value = "theme2", Text = "Purple" },
                new SelectItem { Value = "theme3", Text = "Green" } };
        }
    }
}