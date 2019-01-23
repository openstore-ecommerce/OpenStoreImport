﻿using System;
using System.Globalization;

namespace ZIndex.DNN.OpenStoreImport.Extensions
{
    public static class CommonExtensions
    {
        /// <summary>
        /// Returns an Xsd datetime
        /// </summary>
        /// <param name="now"></param>
        /// <returns></returns>
        public static string ToXsdDatetime(this DateTime now)
        {
            return now.ToString("yyyy-MM-ddThh:mm:ss.ff");
        }

        /// <summary>
        /// Returns the value formated as UnitCost
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToUniCost(this decimal value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }

    }
}
