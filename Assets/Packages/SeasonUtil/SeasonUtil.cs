public static class SeasonUtil
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    public static Season SeasonFromSystemDateMonthInJapaneseMeteorology
    {
        // NOTE:
        // 12,  1,  2 = Winter
        //  3,  4,  5 = Spring
        //  6,  7,  8 = Summer
        //  9, 10, 11 = Autumn
        // EX:
        // DateTimeNowMonth = 12 -> 10 = Winter
        //                  =  3 ->  1 = Spring
        //                  =  7 ->  5 = Summer

        get
        {
            var month = System.DateTime.Now.Month - 2;

            if (month <= 0)
            {
                month += 12;
            }

            return SeasonFromMonthInLunisolarCalendar(month);
        }
    }

    public static Season SeasonFromSystemDateMonthInLunisolarCalendar
        => SeasonFromMonthInLunisolarCalendar(System.DateTime.Now.Month);

    public static Season SeasonFromMonthInLunisolarCalendar(int month)
    {
        // NOTE:
        // Lunisolar-Calendar is a traditional calendar mainly used in Asia like Japan, China or any other.

        switch (month)
        {
            case 1:
            case 2:
            case 3:
                return Season.Spring;
            case 4:
            case 5:
            case 6:
                return Season.Summer;
            case 7:
            case 8:
            case 9:
                return Season.Autumn;
            case 10:
            case 11:
            case 12:
            default:
                return Season.Winter;
        }
    }
}