﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector
{
	public interface ISerializedObject // TypeDefIndex: 4816
	{
		// Properties
		bool IsRestored { get; set; }
		List<UnityEngine.Object> SerializedObjectReferences { get; set; }
		List<string> SerializedStateKeys { get; set; }
		List<string> SerializedStateValues { get; set; }
	
		// Methods
		void RestoreState();
		void SaveState();
	}
}
