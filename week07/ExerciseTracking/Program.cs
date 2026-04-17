using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("17 Apr 2026", 29, 2.0));
        activities.Add(new Bicycle("13 Apr 2026", 34, 13.5));
        activities.Add(new Swimming("11 Apr 2026", 23, 24));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}