﻿/*
All code in this file Copyright(c) 2016 Nate West

The MIT License (MIT)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeControl;

namespace TimeControl.Testing
{
    static internal class TestDateTimeDisplay
    { 
        internal static void RunDateTimeDisplayTest(double d = 1d)
        {
            Log.Trace(String.Format("Formatter Type: {0}", KSPUtil.dateTimeFormatter.GetType()));

            Log.Trace(String.Format("Year: {0}", KSPUtil.dateTimeFormatter.Year));
            Log.Trace(String.Format("Day: {0}", KSPUtil.dateTimeFormatter.Day));
            Log.Trace(String.Format("Hour: {0}", KSPUtil.dateTimeFormatter.Hour));
            Log.Trace(String.Format("Minute: {0}", KSPUtil.dateTimeFormatter.Minute));

            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDate(d, true, true): {0}", KSPUtil.dateTimeFormatter.PrintDate(d, true, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDate(d, true, false): {0}", KSPUtil.dateTimeFormatter.PrintDate(d, true, false)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDate(d, false, true): {0}", KSPUtil.dateTimeFormatter.PrintDate(d, false, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDate(d, false, false): {0}", KSPUtil.dateTimeFormatter.PrintDate(d, false, false)));

            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDateCompact(d, true, true): {0}", KSPUtil.dateTimeFormatter.PrintDateCompact(d, true, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDateCompact(d, true, false): {0}", KSPUtil.dateTimeFormatter.PrintDateCompact(d, true, false)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDateCompact(d, false, true): {0}", KSPUtil.dateTimeFormatter.PrintDateCompact(d, false, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDateCompact(d, false, false): {0}", KSPUtil.dateTimeFormatter.PrintDateCompact(d, false, false)));

            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDateDelta(d, true, true, true): {0}", KSPUtil.dateTimeFormatter.PrintDateDelta(d, true, true, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDateDelta(d, true, true, false): {0}", KSPUtil.dateTimeFormatter.PrintDateDelta(d, true, true, false)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDateDelta(d, true, false, true): {0}", KSPUtil.dateTimeFormatter.PrintDateDelta(d, true, false, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDateDelta(d, true, false, false): {0}", KSPUtil.dateTimeFormatter.PrintDateDelta(d, true, false, false)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDateDelta(d, false, true, true): {0}", KSPUtil.dateTimeFormatter.PrintDateDelta(d, false, true, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDateDelta(d, false, true, false): {0}", KSPUtil.dateTimeFormatter.PrintDateDelta(d, false, true, false)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDateDelta(d, false, false, true): {0}", KSPUtil.dateTimeFormatter.PrintDateDelta(d, false, false, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDateDelta(d, false, false, false): {0}", KSPUtil.dateTimeFormatter.PrintDateDelta(d, false, false, false)));

            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDateDeltaCompact(d, true, true, true): {0}", KSPUtil.dateTimeFormatter.PrintDateDeltaCompact(d, true, true, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDateDeltaCompact(d, true, true, false): {0}", KSPUtil.dateTimeFormatter.PrintDateDeltaCompact(d, true, true, false)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDateDeltaCompact(d, true, false, true): {0}", KSPUtil.dateTimeFormatter.PrintDateDeltaCompact(d, true, false, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDateDeltaCompact(d, true, false, false): {0}", KSPUtil.dateTimeFormatter.PrintDateDeltaCompact(d, true, false, false)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDateDeltaCompact(d, false, true, true): {0}", KSPUtil.dateTimeFormatter.PrintDateDeltaCompact(d, false, true, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDateDeltaCompact(d, false, true, false): {0}", KSPUtil.dateTimeFormatter.PrintDateDeltaCompact(d, false, true, false)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDateDeltaCompact(d, false, false, true): {0}", KSPUtil.dateTimeFormatter.PrintDateDeltaCompact(d, false, false, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDateDeltaCompact(d, false, false, false): {0}", KSPUtil.dateTimeFormatter.PrintDateDeltaCompact(d, false, false, false)));

            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDateNew(d, true): {0}", KSPUtil.dateTimeFormatter.PrintDateNew(d, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintDateNew(d, false): {0}", KSPUtil.dateTimeFormatter.PrintDateNew(d, false)));

            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTime(d, 0, true): {0}", KSPUtil.dateTimeFormatter.PrintTime(d, 0, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTime(d, 1, true): {0}", KSPUtil.dateTimeFormatter.PrintTime(d, 1, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTime(d, 2, true): {0}", KSPUtil.dateTimeFormatter.PrintTime(d, 2, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTime(d, 3, true): {0}", KSPUtil.dateTimeFormatter.PrintTime(d, 3, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTime(d, 4, true): {0}", KSPUtil.dateTimeFormatter.PrintTime(d, 4, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTime(d, 5, true): {0}", KSPUtil.dateTimeFormatter.PrintTime(d, 5, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTime(d, 6, true): {0}", KSPUtil.dateTimeFormatter.PrintTime(d, 6, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTime(d, 0, false): {0}", KSPUtil.dateTimeFormatter.PrintTime(d, 0, false)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTime(d, 1, false): {0}", KSPUtil.dateTimeFormatter.PrintTime(d, 1, false)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTime(d, 2, false): {0}", KSPUtil.dateTimeFormatter.PrintTime(d, 2, false)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTime(d, 3, false): {0}", KSPUtil.dateTimeFormatter.PrintTime(d, 3, false)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTime(d, 4, false): {0}", KSPUtil.dateTimeFormatter.PrintTime(d, 4, false)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTime(d, 5, false): {0}", KSPUtil.dateTimeFormatter.PrintTime(d, 5, false)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTime(d, 6, false): {0}", KSPUtil.dateTimeFormatter.PrintTime(d, 6, false)));

            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTimeCompact(d, true): {0}", KSPUtil.dateTimeFormatter.PrintTimeCompact(d, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTimeCompact(d, false): {0}", KSPUtil.dateTimeFormatter.PrintTimeCompact(d, false)));

            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTimeCompact(d): {0}", KSPUtil.dateTimeFormatter.PrintTimeLong(d)));

            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTimeStamp(d, true, true): {0}", KSPUtil.dateTimeFormatter.PrintTimeStamp(d, true, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTimeStamp(d, true, false): {0}", KSPUtil.dateTimeFormatter.PrintTimeStamp(d, true, false)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTimeStamp(d, false, true): {0}", KSPUtil.dateTimeFormatter.PrintTimeStamp(d, false, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTimeStamp(d, false, false): {0}", KSPUtil.dateTimeFormatter.PrintTimeStamp(d, false, false)));

            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTimeStampCompact(d, true, true): {0}", KSPUtil.dateTimeFormatter.PrintTimeStampCompact(d, true, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTimeStampCompact(d, true, false): {0}", KSPUtil.dateTimeFormatter.PrintTimeStampCompact(d, true, false)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTimeStampCompact(d, false, true): {0}", KSPUtil.dateTimeFormatter.PrintTimeStampCompact(d, false, true)));
            Log.Trace(String.Format("KSPUtil.dateTimeFormatter.PrintTimeStampCompact(d, false, false): {0}", KSPUtil.dateTimeFormatter.PrintTimeStampCompact(d, false, false)));            
        }
    }
}
