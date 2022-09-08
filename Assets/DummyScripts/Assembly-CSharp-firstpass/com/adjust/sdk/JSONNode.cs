﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace com.adjust.sdk
{
	public class JSONNode // TypeDefIndex: 6707
	{
		// Properties
		public virtual JSONNode this[int aIndex] { /* [XID] */ /* 0x0000000189B78150-0x0000000189B78190 */ /* [IDTag] */ /* 0x0000000189B78150-0x0000000189B78190 */ get => default; /* [XID] */ /* 0x0000000189B829D0-0x0000000189B82A10 */ /* [IDTag] */ /* 0x0000000189B829D0-0x0000000189B82A10 */ set {} } // 0x00000001866A4B60-0x00000001866A4C10 0x00000001866A5350-0x00000001866A5410
		public virtual JSONNode this[string aKey] { /* [IDTag] */ /* 0x0000000189B8CA10-0x0000000189B8CA50 */ /* [XID] */ /* 0x0000000189B8CA10-0x0000000189B8CA50 */ get => default; /* [IDTag] */ /* 0x0000000189B97020-0x0000000189B97060 */ /* [XID] */ /* 0x0000000189B97020-0x0000000189B97060 */ set {} } // 0x00000001866A4AB0-0x00000001866A4B60 0x00000001866A5410-0x00000001866A54D0
		public virtual string Value { /* [XID] */ /* 0x0000000189BA15D0-0x0000000189BA15F0 */ get => default; /* [XID] */ /* 0x00000001898E7FA0-0x00000001898E7FC0 */ set {} } // 0x00000001866A4C10-0x00000001866A4CB0 0x00000001866A54D0-0x00000001866A5570
		public virtual int Count { /* [XID] */ /* 0x00000001898F6FF0-0x00000001898F7010 */ get => default; } // 0x00000001866A4930-0x00000001866A49D0 
		public virtual IEnumerable<JSONNode> Childs { /* [XID] */ /* 0x000000018992B940-0x000000018992B960 */ get => default; } // 0x00000001866A4860-0x00000001866A4930 
		public IEnumerable<JSONNode> DeepChilds { /* [XID] */ /* 0x0000000189886AE0-0x0000000189886B00 */ get => default; } // 0x00000001866A49D0-0x00000001866A4AB0 
		public virtual int AsInt { /* [XID] */ /* 0x000000018960B120-0x000000018960B140 */ get => default; /* [XID] */ /* 0x0000000189612540-0x0000000189612560 */ set {} } // 0x00000001866A4690-0x00000001866A4770 0x00000001866A5290-0x00000001866A5350
		public virtual float AsFloat { /* [XID] */ /* 0x0000000189949550-0x0000000189949570 */ get => default; /* [XID] */ /* 0x0000000189950DD0-0x0000000189950DF0 */ set {} } // 0x00000001866A45A0-0x00000001866A4690 0x00000001866A51C0-0x00000001866A5290
		public virtual double AsDouble { /* [XID] */ /* 0x0000000189628BE0-0x0000000189628C00 */ get => default; /* [XID] */ /* 0x00000001896304B0-0x00000001896304D0 */ set {} } // 0x00000001866A44C0-0x00000001866A45A0 0x00000001866A50F0-0x00000001866A51C0
		public virtual bool AsBool { /* [XID] */ /* 0x0000000189638110-0x0000000189638130 */ get => default; /* [XID] */ /* 0x000000018963F370-0x000000018963F390 */ set {} } // 0x00000001866A4370-0x00000001866A44C0 0x00000001866A5010-0x00000001866A50F0
		public virtual JSONArray AsArray { /* [XID] */ /* 0x000000018996E760-0x000000018996E780 */ get => default; } // 0x00000001866A4280-0x00000001866A4370 
		public virtual JSONClass AsObject { /* [XID] */ /* 0x000000018964E460-0x000000018964E480 */ get => default; } // 0x00000001866A4770-0x00000001866A4860 
	
		// Constructors
		public JSONNode() {} // 0x00000001866A4220-0x00000001866A4280
	
		// Methods
		// [IDTag] // 0x0000000189B6DAB0-0x0000000189B6DAF0
		// [XID] // 0x0000000189B6DAB0-0x0000000189B6DAF0
		public virtual void Add(string aKey, JSONNode aItem) {} // 0x00000001866A20E0-0x00000001866A21A0
		// [IDTag] // 0x0000000189BB75B0-0x0000000189BB75F0
		// [XID] // 0x0000000189BB75B0-0x0000000189BB75F0
		public virtual void Add(JSONNode aItem) {} // 0x00000001866A21A0-0x00000001866A2260
		// [IDTag] // 0x0000000189BC2620-0x0000000189BC2660
		// [XID] // 0x0000000189BC2620-0x0000000189BC2660
		public virtual JSONNode Remove(string aKey) => default; // 0x00000001866A39F0-0x00000001866A3AA0
		// [IDTag] // 0x0000000189BCCE40-0x0000000189BCCE80
		// [XID] // 0x0000000189BCCE40-0x0000000189BCCE80
		public virtual JSONNode Remove(int aIndex) => default; // 0x00000001866A3940-0x00000001866A39F0
		// [IDTag] // 0x0000000189BD70B0-0x0000000189BD70F0
		// [XID] // 0x0000000189BD70B0-0x0000000189BD70F0
		public virtual JSONNode Remove(JSONNode aNode) => default; // 0x00000001866A3AA0-0x00000001866A3B50
		// [IDTag] // 0x00000001895F60A0-0x00000001895F60E0
		// [XID] // 0x00000001895F60A0-0x00000001895F60E0
		public override string ToString() => default; // 0x00000001866A4020-0x00000001866A40C0
		// [IDTag] // 0x00000001896003E0-0x0000000189600420
		// [XID] // 0x00000001896003E0-0x0000000189600420
		public virtual string ToString(string aPrefix) => default; // 0x00000001866A3F70-0x00000001866A4020
		// [IDTag] // 0x0000000189655CE0-0x0000000189655D20
		// [XID] // 0x0000000189655CE0-0x0000000189655D20
		public static implicit operator JSONNode(string s) => default; // 0x00000001866A4E90-0x00000001866A4F50
		// [IDTag] // 0x0000000189660100-0x0000000189660140
		// [XID] // 0x0000000189660100-0x0000000189660140
		public static implicit operator string(JSONNode d) => default; // 0x00000001866A4DC0-0x00000001866A4E90
		// [XID] // 0x000000018966AB80-0x000000018966ABA0
		public static bool operator ==(JSONNode a, object b) => default; // 0x00000001866A4CB0-0x00000001866A4DC0
		// [XID] // 0x0000000189994980-0x00000001899949A0
		public static bool operator !=(JSONNode a, object b) => default; // 0x00000001866A4F50-0x00000001866A5010
		// [XID] // 0x000000018967A0C0-0x000000018967A0E0
		public override bool Equals(object obj) => default; // 0x00000001866A2630-0x00000001866A26F0
		// [XID] // 0x0000000189681760-0x0000000189681780
		public override int GetHashCode() => default; // 0x00000001866A2A10-0x00000001866A2AB0
		// [XID] // 0x0000000189689220-0x0000000189689240
		internal static string Escape(string aText) => default; // 0x00000001866A26F0-0x00000001866A2A10
		// [XID] // 0x00000001899AB690-0x00000001899AB6B0
		public static JSONNode Parse(string aJSON) => default; // 0x00000001866A2FA0-0x00000001866A3940
		// [XID] // 0x00000001899B3010-0x00000001899B3030
		public virtual void Serialize(BinaryWriter aWriter) {} // 0x00000001866A3ED0-0x00000001866A3F70
		// [XID] // 0x00000001899BA1B0-0x00000001899BA1D0
		public void SaveToStream(Stream aData) {} // 0x00000001866A3DE0-0x00000001866A3ED0
		// [XID] // 0x00000001896A6CA0-0x00000001896A6CC0
		public void SaveToCompressedStream(Stream aData) {} // 0x00000001866A3D00-0x00000001866A3DE0
		// [XID] // 0x00000001899C9160-0x00000001899C9180
		public void SaveToCompressedFile(string aFileName) {} // 0x00000001866A3C20-0x00000001866A3D00
		// [XID] // 0x00000001896B5A20-0x00000001896B5A40
		public string SaveToCompressedBase64() => default; // 0x00000001866A3B50-0x00000001866A3C20
		// [XID] // 0x00000001899D0D10-0x00000001899D0D30
		public static JSONNode Deserialize(BinaryReader aReader) => default; // 0x00000001866A2260-0x00000001866A2630
		// [XID] // 0x00000001899D8070-0x00000001899D8090
		public static JSONNode LoadFromCompressedFile(string aFileName) => default; // 0x00000001866A2CA0-0x00000001866A2D70
		// [XID] // 0x00000001899DF680-0x00000001899DF6A0
		public static JSONNode LoadFromCompressedStream(Stream aData) => default; // 0x00000001866A2D70-0x00000001866A2E40
		// [XID] // 0x00000001896D2C50-0x00000001896D2C70
		public static JSONNode LoadFromCompressedBase64(string aBase64) => default; // 0x00000001866A2BD0-0x00000001866A2CA0
		// [XID] // 0x00000001899EE650-0x00000001899EE670
		public static JSONNode LoadFromStream(Stream aData) => default; // 0x00000001866A2E40-0x00000001866A2FA0
		// [XID] // 0x00000001899F5EC0-0x00000001899F5EE0
		public static JSONNode LoadFromBase64(string aBase64) => default; // 0x00000001866A2AB0-0x00000001866A2BD0
	}
}
