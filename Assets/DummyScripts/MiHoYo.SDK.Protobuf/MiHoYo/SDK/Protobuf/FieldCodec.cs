﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf
{
	public static class FieldCodec // TypeDefIndex: 5074
	{
		// Methods
		public static FieldCodec<string> ForString(uint tag) => default; // 0x00000001864FB930-0x00000001864FBB30
		public static FieldCodec<int> ForInt32(uint tag) => default; // 0x00000001864FB730-0x00000001864FB930
		public static FieldCodec<T> ForMessage<T>(uint tag, MessageParser<T> parser)
			where T : IMessage<T> => default;
	}
}
