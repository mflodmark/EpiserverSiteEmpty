﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.SpecializedProperties;
using EpiserverSite1.Business.SelectionFactories;

namespace EpiserverSite1.Models.Pages
{
    [ContentType(DisplayName = "Product", 
        GroupName = SiteGroupNames.Specialized,
        Description = "Use this for software products that Alloy sells")]
    [SiteCommerceIcon]
    public class ProductPage : StandardPage
    {
        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);

            Theme = "theme1";
        }

        [SelectOne(SelectionFactoryType = typeof(ThemeSelectionFactory))]
        [Display(Name = "Color theme", 
            GroupName = SystemTabNames.Content, 
            Order = 310)]
        public virtual string Theme { get; set; }

        [CultureSpecific]
        [Display(Name = "Unique selling points", 
            GroupName = SystemTabNames.Content, 
            Order = 320)] [Required]
        public virtual IList<string> UniqueSellingPoints { get; set; }
    }
}