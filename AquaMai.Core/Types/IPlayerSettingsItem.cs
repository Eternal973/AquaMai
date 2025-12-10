namespace AquaMai.Core.Types;

/// <summary>
/// 加入选歌的设置界面的设置项
/// </summary>
public interface IPlayerSettingsItem
{
    public int Sort { get; }
    public string Name { get; }
    public string Detail { get; }

    /// <summary>
    /// 用于显示的“当前值”
    /// </summary>
    public string GetOptionValue(int player);
    /// <summary>
    /// 按下增加时调用
    /// 由于 patch 了 GetOptionValueIndex 和 GetOptionMax，点击屏幕的事件永远会被响应，所以这里面需要自己判断区间
    /// </summary>
    public void AddOption(int player);
    /// <summary>
    /// 按下减少时调用
    /// </summary>
    public void SubOption(int player);

    public string GetSpriteFile(int player);

    public bool GetIsLeftButtonActive(int player);
    public bool GetIsRightButtonActive(int player);

    // 这两个会用来判断按钮是否显示和是否可以点击
    public int GetOptionValueIndex(int player);
    public int GetOptionMax(int player);
}
