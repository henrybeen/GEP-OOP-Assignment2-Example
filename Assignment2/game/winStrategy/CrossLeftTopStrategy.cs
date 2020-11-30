﻿namespace Assignment2.game.winStrategy
{
    public class CrossLeftTopStrategy : IWinStrategy
    {
        private readonly IFieldAccessor _fieldAccessor;

        public CrossLeftTopStrategy(IFieldAccessor fieldAccessor)
        {
            _fieldAccessor = fieldAccessor;
        }

        public bool HasWinner()
        {
            return "XO".Contains(_fieldAccessor.GetField(0, 0)) 
                && _fieldAccessor.GetField(0, 0) == _fieldAccessor.GetField(1, 1)
                && _fieldAccessor.GetField(0, 0) == _fieldAccessor.GetField(2, 2);
        }

        public string GetWinner()
        {
            return _fieldAccessor.GetField(0, 0);
        }
    }
}
