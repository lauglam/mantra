﻿using System.Windows;

// ReSharper disable once CheckNamespace
namespace Mantra;

internal partial class UploadPage : BasePage
{
    private UploadViewModel ViewModel => (DataContext as UploadViewModel)!;

    public UploadPage()
    {
        InitializeComponent();
        DataContext = new UploadViewModel();
    }

    private void Grid_OnDrop(object sender, DragEventArgs e)
    {
        ViewModel.DropHandler(sender, e);
    }
}