﻿using System;
using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using Bumblebee.KendoUI;
using Bumblebee.Setup;

using OpenQA.Selenium;

namespace Bumblebee.IntegrationTests.Shared.Pages.KendoUI
{
    public class KendoNumericTextBoxDemoPage : WebBlock
    {
        public KendoNumericTextBoxDemoPage(Session session)
            : base(session, TimeSpan.FromSeconds(10))
        {
        }

        public INumericField<KendoNumericTextBoxDemoPage> Price
        {
            get { return new KendoNumericTextBox<KendoNumericTextBoxDemoPage>(this, By.Id("currency")); }
        }

        public INumericField<KendoNumericTextBoxDemoPage> Discount
        {
            get { return new KendoNumericTextBox<KendoNumericTextBoxDemoPage>(this, By.Id("percentage")); }
        }
    }
}
