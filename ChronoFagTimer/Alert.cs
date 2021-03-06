﻿/*
 *  Copyright (C) 2017 HarpyWar <harpywar@gmail.com>
 *  
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace ChronoFagTimer
{
    public class Alert
    {
        /// <summary>
        /// Current elapsed time (do not set from config)
        /// </summary>
        public int Elapsed;
        public void Reset()
        {
            Elapsed = 0;
        }

        /// <summary>
        /// Time remaining in pomodoro (seconds)
        /// </summary>
        public int Remain;
        /// <summary>
        /// Duration of alert show
        /// </summary>
        public int Duration;

        /// <summary>
        /// File to play
        /// </summary>
        public string Sound;
    }
}
