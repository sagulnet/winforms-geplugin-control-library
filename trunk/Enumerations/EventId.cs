﻿// <copyright file="EventId.cs" company="FC">
// Copyright (c) 2011 Fraser Chapman
// </copyright>
// <author>Fraser Chapman</author>
// <email>fraser.chapman@gmail.com</email>
// <date>2011-03-25</date>
// <summary>This file is part of FC.GEPluginCtrls
// FC.GEPluginCtrls is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// You should have received a copy of the GNU General Public License
// along with this program. If not, see http://www.gnu.org/licenses/.
// </summary>
namespace FC.GEPluginCtrls
{
    /// <summary>
    /// The various plugin event ids
    /// </summary>
    public enum EventId
    {
        #region mouse actions

        /// <summary>
        /// The click event id
        /// </summary>
        Click = 0,

        /// <summary>
        /// The double click event id
        /// </summary>
        DblClick = 1,

        /// <summary>
        /// The mouse over event id
        /// </summary>
        MouseOver = 2,

        /// <summary>
        /// The mouse down event id
        /// </summary>
        MouseDown = 3,

        /// <summary>
        /// The mouse up event id
        /// </summary>
        MouseUp = 4,

        /// <summary>
        /// The mouse out event id
        /// </summary>
        MouseOut = 5,

        /// <summary>
        /// The mouse move event id
        /// </summary>
        MouseMove = 6,

        #endregion

        #region plugin actions

        /// <summary>
        /// The frame end event id
        /// </summary>
        FrameEnd = 10,

        /// <summary>
        /// The balloon close event id
        /// </summary>
        BalloonClose = 11,

        /// <summary>
        /// The balloon opening event id
        /// </summary>
        BalloonOpening = 12,

        #endregion

        #region view actions

        /// <summary>
        /// The view change begin event id
        /// </summary>
        ViewChangeBegin = 20,

        /// <summary>
        /// The view change event id
        /// </summary>
        ViewChange = 21,

        /// <summary>
        /// The view change end event id
        /// </summary>
        ViewChangeEnd = 22

        #endregion
    }
}