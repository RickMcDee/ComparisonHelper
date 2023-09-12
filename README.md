# ComparisonHelper
Helps you to update properties

[![NuGet version (ComparisonHelper)](https://img.shields.io/nuget/v/ComparisonHelper.svg?style=flat-square)](https://www.nuget.org/packages/ComparisonHelper/)

## Usage

```cs
var testObject = new TestModel
    {
        IntProperty = 1,
        StringProperty = "Yolo",
    };

testObject.IntProperty = ComparisonHelper.TakeNewValueIfChanged(testObject.IntProperty, 7);
testObject.StringProperty = ComparisonHelper.TakeNewValueIfChanged(testObject.StringProperty, "Swag");
```

## Changelog
### 1.0.0
- Initial Release