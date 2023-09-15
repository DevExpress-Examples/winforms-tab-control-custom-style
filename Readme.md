<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128619657/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2775)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Tab Control - Create a custom style

This example demonstrates how to create a custom style to paint the WinForms Tab Control as needed:

```csharp
public Form1() {
    InitializeComponent();
    PaintStyleCollection.DefaultPaintStyles.Add(new MyRegistrator());
    xtraTabControl1.PaintStyleName = "MyStyle";
}
```


## Files to Review

* [MyRegistrator.cs](./CS/WindowsApplication1/Custom%20style/MyRegistrator.cs) (VB: [MyRegistrator.vb](./VB/WindowsApplication1/Custom%20style/MyRegistrator.vb))
* [MySkinTabPainter.cs](./CS/WindowsApplication1/Custom%20style/MySkinTabPainter.cs) (VB: [MySkinTabPainter.vb](./VB/WindowsApplication1/Custom%20style/MySkinTabPainter.vb))
* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
