﻿// ReSharper disable once CheckNamespace

namespace Mantra;

/// <summary>
/// 应用视图模型
/// </summary>
internal class ApplicationViewModel : BaseViewModel
{
    #region Singleton

    /// <summary>
    /// 创建锁
    /// </summary>
    private static readonly object CreateLock = new();

    /// <summary>
    /// 单例实例
    /// </summary>
    private static ApplicationViewModel? _instance;

    /// <summary>
    /// 当前单例
    /// </summary>
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

    #endregion

    /// <summary>
    /// The current page of the application
    /// </summary>
    public ApplicationCurrentPage CurrentPage { get; private set; } = new(ApplicationPage.Upload, false);

    /// <summary>
    /// Push value to go to page
    /// </summary>
    public object? PushValue { get; private set; }

    /// <summary>
    /// Navigates to the specified page
    /// </summary>
    /// <param name="page">The page to go to</param>
    /// <param name="pushValue">The value push to go to page</param>
    /// <param name="useCache">Indicate is go back</param>
    public void GoToPage(ApplicationPage page, object? pushValue = null, bool useCache = false)
    {
        // Set the current page
        CurrentPage = new ApplicationCurrentPage(page, useCache);

        // Set push value
        PushValue = pushValue;
    }
}