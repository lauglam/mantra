﻿// ReSharper disable once CheckNamespace

namespace Mantra;

/// <summary>
/// 应用视图模型
/// </summary>
internal class ApplicationViewModel : BaseViewModel
{
    private static readonly object CreateLock = new();
    private static ApplicationViewModel? _instance;

    public static ApplicationViewModel Current
    {
        get
        {
            // For Performance
            if (_instance == null)
            {
                lock (CreateLock)
                {
                    _instance ??= new ApplicationViewModel();
                }
            }

            return _instance;
        }
    }

    /// <summary>
    /// The current page of the application
    /// </summary>
    public ApplicationPage CurrentPage { get; private set; } = ApplicationPage.Upload;

    /// <summary>
    /// Push value to go to page
    /// </summary>
    public object? PushValue { get; private set; }

    /// <summary>
    /// True if the side menu should be shown
    /// </summary>
    public bool SideMenuVisible { get; set; }

    /// <summary>
    /// Navigates to the specified page
    /// </summary>
    /// <param name="page">The page to go to</param>
    /// <param name="pushValue">The value push to go to page</param>
    public void GoToPage(ApplicationPage page, object? pushValue = null)
    {
        // Set the current page
        CurrentPage = page;

        // Set push value
        PushValue = pushValue;

        // Show side menu or not?
        SideMenuVisible = page == ApplicationPage.Scanlation;
    }
}