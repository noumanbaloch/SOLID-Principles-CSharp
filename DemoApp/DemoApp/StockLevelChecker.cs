﻿namespace DemoApp
{
    public class StockLevelChecker
    {
        public bool StockLevel(StockChecker stockChecker)
        {
            return stockChecker.StockLevel < 5;
        }
    }

}
