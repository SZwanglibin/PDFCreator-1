﻿using System.Windows.Controls;
using pdfforge.PDFCreator.UI.Presentation.Helper;

namespace pdfforge.PDFCreator.UI.Presentation.UserControls.Profiles.Tabs
{
    public partial class MetadataTab : UserControl
    {
        public MetadataTab(MetadataViewModel viewModel)
        {
            DataContext = viewModel;
            TransposerHelper.Register(this, viewModel);
            InitializeComponent();
        }
    }
}
