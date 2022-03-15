﻿using System.Collections.Generic;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace Mantra;

/// <summary>
/// 翻译接口
/// </summary>
internal interface ITranslator
{
    /// <summary>
    /// 单个翻译
    /// </summary>
    /// <param name="input"></param>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <returns></returns>
    string Translate(string input, string from, string to);

    /// <summary>
    /// 翻译组
    /// </summary>
    /// <param name="groupInput"></param>
    ///     /// <param name="from"></param>
    /// <param name="to"></param>
    /// <returns></returns>
    IEnumerable<string> TranslateGroup(IEnumerable<string> groupInput, string from, string to);

    /// <summary>
    /// 单个翻译
    /// </summary>
    /// <param name="input"></param>
    ///     /// <param name="from"></param>
    /// <param name="to"></param>
    /// <returns></returns>
    Task<string> TranslateAsync(string input, string from, string to);

    /// <summary>
    /// 翻译组
    /// </summary>
    /// <param name="groupInput"></param>
    ///     /// <param name="from"></param>
    /// <param name="to"></param>
    /// <returns></returns>
    Task<IEnumerable<string>> TranslateGroupAsync(IEnumerable<string> groupInput, string from, string to);
}