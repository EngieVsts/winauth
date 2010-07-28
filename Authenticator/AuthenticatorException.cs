﻿/* Copyright (C) 2010 Colin Mackie.
 * This software is distributed under the terms of the GNU General Public License.
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsAuthenticator
{
	/// <summary>
	/// Base Authenticator exception class
	/// </summary>
	public class AuthenticatorException : ApplicationException
	{
		public AuthenticatorException()
			: base()
		{
		}

		public AuthenticatorException(string msg)
			: base(msg)
		{
		}

		public AuthenticatorException(string msg, Exception ex)
			: base(msg, ex)
		{
		}
	}

	/// <summary>
	/// Exception for reading invalid config data
	/// </summary>
	public class InvalidConfigDataException : AuthenticatorException
	{
		public InvalidConfigDataException() : base() {}
	}

	/// <summary>
	/// Exception for error or unexpected return from server for enroll
	/// </summary>
	public class InvalidEnrollResponseException : AuthenticatorException
	{
		public InvalidEnrollResponseException(string msg) : base(msg) { }
	}

	/// <summary>
	/// Exception for error or unexpected return from server for sync
	/// </summary>
	public class InvalidSyncResponseException : AuthenticatorException
	{
		public InvalidSyncResponseException(string msg) : base(msg) { }
	}
}