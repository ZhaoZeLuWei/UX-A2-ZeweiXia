using UnityEngine;
using UnityEngine.UI;

public class ButtonImageToggle : MonoBehaviour
{
    public Sprite image1;  // 初始图片
    public Sprite image2;  // 切换后的图片
    private bool isToggled = false;  // 跟踪图片切换状态
    private Image buttonImage;  // 按钮的Image组件

    void Start()
    {
        buttonImage = GetComponent<Image>();  // 获取按钮的Image组件
        buttonImage.sprite = image1;  // 设置初始图片
    }

    public void ToggleImage()
    {
        isToggled = !isToggled;
        buttonImage.sprite = isToggled ? image2 : image1;  // 根据状态切换图片
    }
}

