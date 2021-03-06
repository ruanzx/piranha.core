﻿/*
 * Copyright (c) 2016 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * https://github.com/piranhacms/piranha.core
 * 
 */

namespace Piranha
{
	/// <summary>
	/// The app config used at initialization.
	/// </summary>
    public sealed class AppConfig
    {
		/// <summary>
		/// The configured storage factory.
		/// </summary>
		public Server.IStorageFactory Storage;
    }
}
