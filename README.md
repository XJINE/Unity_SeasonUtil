# Unity_SeasonUtil

Utility to handle season.

## Importing

You can use Package Manager or import it directly.

```
https://github.com/XJINE/Unity_SeasonUtil.git?path=Assets/Packages/SeasonUtil
```

## How to Use

There are some properties and functions to get season from month.

```csharp
public enum Season { Spring, Summer, Autumn, Winter }

public static Season SeasonFromSystemDateMonthInJapaneseMeteorology
public static Season SeasonFromSystemDateMonthInLunisolarCalendar
public static Season SeasonFromMonthInLunisolarCalendar(int month)
```