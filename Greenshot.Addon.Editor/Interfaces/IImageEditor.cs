﻿//  Greenshot - a free and open source screenshot tool
//  Copyright (C) 2007-2017 Thomas Braun, Jens Klingen, Robin Krom
// 
//  For more information see: http://getgreenshot.org/
//  The Greenshot project is hosted on GitHub: https://github.com/greenshot
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 1 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

#region Usings

using System.Windows.Forms;

#endregion

namespace Greenshot.Addon.Interfaces.Forms
{
	/// <summary>
	///     The IImageEditor is the Interface that the Greenshot ImageEditor has to implement
	/// </summary>
	public interface IImageEditor
	{
		ISurface Surface { get; set; }

		/// <summary>
		///     Return the IWin32Window, this way Plugins have access to the HWND handles wich can be used with Win32 API calls.
		/// </summary>
		IWin32Window WindowHandle { get; }

		/// <summary>
		///     Get the File ToolStripMenuItem
		/// </summary>
		/// <returns>ToolStripMenuItem</returns>
		ToolStripMenuItem GetFileMenuItem();

		/// <summary>
		///     Get the ToolStripMenuItem where plugins can place their Menu entrys
		/// </summary>
		/// <returns>ToolStripMenuItem</returns>
		ToolStripMenuItem GetPluginMenuItem();
	}
}