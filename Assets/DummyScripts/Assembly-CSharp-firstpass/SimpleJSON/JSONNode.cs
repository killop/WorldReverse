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

namespace SimpleJSON
{
	public class JSONNode // TypeDefIndex: 10040
	{
		// Properties
		public virtual JSONNode this[int aIndex] { /* [IDTag] */ /* 0x0000000189911F90-0x0000000189911FD0 */ /* [XID] */ /* 0x0000000189911F90-0x0000000189911FD0 */ get => default; /* [XID] */ /* 0x000000018991CBC0-0x000000018991CC00 */ /* [IDTag] */ /* 0x000000018991CBC0-0x000000018991CC00 */ set {} } // 0x0000000186746590-0x0000000186746640 0x0000000186747160-0x0000000186747220
		public virtual JSONNode this[string aKey] { /* [XID] */ /* 0x0000000189927240-0x0000000189927280 */ /* [IDTag] */ /* 0x0000000189927240-0x0000000189927280 */ get => default; /* [XID] */ /* 0x0000000189931740-0x0000000189931780 */ /* [IDTag] */ /* 0x0000000189931740-0x0000000189931780 */ set {} } // 0x00000001867464E0-0x0000000186746590 0x00000001867470A0-0x0000000186747160
		public virtual string Value { /* [XID] */ /* 0x000000018993C190-0x000000018993C1B0 */ get => default; /* [XID] */ /* 0x0000000189943570-0x0000000189943590 */ set {} } // 0x0000000186746750-0x0000000186746800 0x0000000186747220-0x00000001867472D0
		public virtual int Count { /* [XID] */ /* 0x000000018994AC40-0x000000018994AC60 */ get => default; } // 0x0000000186745DE0-0x0000000186745E80 
		public virtual bool IsString { /* [XID] */ /* 0x00000001899525F0-0x0000000189952630 */ get; /* [XID] */ /* 0x000000018995CAA0-0x000000018995CAE0 */ set; } // 0x0000000186746390-0x00000001867463F0 0x0000000186747040-0x00000001867470A0
		public virtual IEnumerable<string> Keys { /* [XID] */ /* 0x0000000189999380-0x00000001899993A0 */ get => default; } // 0x0000000186746640-0x0000000186746750 
		public virtual IEnumerable<JSONNode> Childs { /* [XID] */ /* 0x0000000189AD5360-0x0000000189AD5380 */ get => default; } // 0x0000000186745CD0-0x0000000186745DE0 
		public IEnumerable<JSONNode> DeepChilds { /* [XID] */ /* 0x00000001899A8600-0x00000001899A8620 */ get => default; } // 0x0000000186745E80-0x0000000186745FA0 
		public virtual bool IsInt { /* [XID] */ /* 0x00000001899CF590-0x00000001899CF5B0 */ get => default; } // 0x00000001867462A0-0x0000000186746390 
		public virtual bool IsUInt { /* [XID] */ /* 0x00000001899D69B0-0x00000001899D69D0 */ get => default; } // 0x00000001867463F0-0x00000001867464E0 
		public virtual bool IsFloat { /* [XID] */ /* 0x0000000189670AE0-0x0000000189670B00 */ get => default; } // 0x00000001867461B0-0x00000001867462A0 
		public virtual bool IsDouble { /* [XID] */ /* 0x00000001899E5DE0-0x00000001899E5E00 */ get => default; } // 0x00000001867460B0-0x00000001867461B0 
		public virtual bool IsBool { /* [XID] */ /* 0x00000001899D1E20-0x00000001899D1E40 */ get => default; } // 0x0000000186745FA0-0x00000001867460B0 
		public virtual int AsInt { /* [XID] */ /* 0x00000001899F4C60-0x00000001899F4C80 */ get => default; /* [XID] */ /* 0x0000000189AB6680-0x0000000189AB66A0 */ set {} } // 0x0000000186745940-0x0000000186745A20 0x0000000186746DF0-0x0000000186746EB0
		public virtual uint AsUInt { /* [XID] */ /* 0x0000000189A036E0-0x0000000189A03700 */ get => default; /* [XID] */ /* 0x00000001899CDB20-0x00000001899CDB40 */ set {} } // 0x0000000186745B10-0x0000000186745BF0 0x0000000186746EB0-0x0000000186746F70
		public virtual ulong AsULong { /* [XID] */ /* 0x0000000189A124C0-0x0000000189A124E0 */ get => default; /* [XID] */ /* 0x0000000189A198D0-0x0000000189A198F0 */ set {} } // 0x0000000186745BF0-0x0000000186745CD0 0x0000000186746F70-0x0000000186747040
		public virtual float AsFloat { /* [XID] */ /* 0x0000000189A20F20-0x0000000189A20F40 */ get => default; /* [XID] */ /* 0x0000000189A01980-0x0000000189A019A0 */ set {} } // 0x0000000186745850-0x0000000186745940 0x0000000186746D20-0x0000000186746DF0
		public virtual double AsDouble { /* [XID] */ /* 0x0000000189AF7020-0x0000000189AF7040 */ get => default; /* [XID] */ /* 0x0000000189A37440-0x0000000189A37460 */ set {} } // 0x0000000186745760-0x0000000186745850 0x0000000186746C50-0x0000000186746D20
		public virtual bool AsBool { /* [XID] */ /* 0x0000000189A3EB50-0x0000000189A3EB70 */ get => default; /* [XID] */ /* 0x0000000189A46280-0x0000000189A462A0 */ set {} } // 0x0000000186745600-0x0000000186745760 0x0000000186746B70-0x0000000186746C50
		public virtual JSONArray AsArray { /* [XID] */ /* 0x0000000189A4D970-0x0000000189A4D990 */ get => default; } // 0x0000000186745510-0x0000000186745600 
		public virtual JSONClass AsObject { /* [XID] */ /* 0x0000000189A55230-0x0000000189A55250 */ get => default; } // 0x0000000186745A20-0x0000000186745B10 
	
		// Constructors
		public JSONNode() {} // 0x00000001867454B0-0x0000000186745510
	
		// Methods
		// [IDTag] // 0x0000000189907720-0x0000000189907760
		// [XID] // 0x0000000189907720-0x0000000189907760
		public virtual void Add(string aKey, JSONNode aItem) {} // 0x00000001867422F0-0x00000001867423B0
		// [IDTag] // 0x0000000189967550-0x0000000189967590
		// [XID] // 0x0000000189967550-0x0000000189967590
		public virtual void Add(JSONNode aItem) {} // 0x0000000186742220-0x00000001867422F0
		// [XID] // 0x0000000189861890-0x00000001898618B0
		public virtual bool ContainsKey(string aKey) => default; // 0x00000001867423B0-0x0000000186742460
		// [IDTag] // 0x0000000189979920-0x0000000189979960
		// [XID] // 0x0000000189979920-0x0000000189979960
		public virtual JSONNode Remove(string aKey) => default; // 0x0000000186744780-0x0000000186744830
		// [IDTag] // 0x0000000189983D50-0x0000000189983D90
		// [XID] // 0x0000000189983D50-0x0000000189983D90
		public virtual JSONNode Remove(int aIndex) => default; // 0x00000001867448E0-0x0000000186744990
		// [IDTag] // 0x000000018998E5A0-0x000000018998E5E0
		// [XID] // 0x000000018998E5A0-0x000000018998E5E0
		public virtual JSONNode Remove(JSONNode aNode) => default; // 0x0000000186744830-0x00000001867448E0
		// [IDTag] // 0x00000001899AFDB0-0x00000001899AFDF0
		// [XID] // 0x00000001899AFDB0-0x00000001899AFDF0
		public override string ToString() => default; // 0x00000001867451E0-0x0000000186745290
		// [IDTag] // 0x00000001899BA300-0x00000001899BA340
		// [XID] // 0x00000001899BA300-0x00000001899BA340
		public virtual string ToString(string aPrefix) => default; // 0x0000000186745290-0x0000000186745350
		// [IDTag] // 0x00000001899C4E30-0x00000001899C4E70
		// [XID] // 0x00000001899C4E30-0x00000001899C4E70
		public virtual string ToString(bool escape) => default; // 0x0000000186745120-0x00000001867451E0
		// [IDTag] // 0x0000000189A5CA60-0x0000000189A5CAA0
		// [XID] // 0x0000000189A5CA60-0x0000000189A5CAA0
		public static implicit operator JSONNode(string s) => default; // 0x00000001867469E0-0x0000000186746AB0
		// [IDTag] // 0x0000000189A67490-0x0000000189A674D0
		// [XID] // 0x0000000189A67490-0x0000000189A674D0
		public static implicit operator string(JSONNode d) => default; // 0x0000000186746910-0x00000001867469E0
		// [XID] // 0x0000000189AEFB40-0x0000000189AEFB60
		public static bool operator ==(JSONNode a, object b) => default; // 0x0000000186746800-0x0000000186746910
		// [XID] // 0x0000000189695DB0-0x0000000189695DD0
		public static bool operator !=(JSONNode a, object b) => default; // 0x0000000186746AB0-0x0000000186746B70
		// [XID] // 0x0000000189A80B80-0x0000000189A80BA0
		public override bool Equals(object obj) => default; // 0x0000000186742870-0x0000000186742930
		// [XID] // 0x0000000189BB0C50-0x0000000189BB0C70
		public override int GetHashCode() => default; // 0x0000000186742C50-0x0000000186742D00
		// [XID] // 0x0000000189A8FED0-0x0000000189A8FEF0
		internal static string Escape(string aText) => default; // 0x0000000186742930-0x0000000186742C50
		// [XID] // 0x0000000189A97650-0x0000000189A97670
		public static JSONNode Parse(string aJSON) => default; // 0x0000000186743340-0x0000000186744780
		// [XID] // 0x000000018999C130-0x000000018999C150
		public virtual void Serialize(BinaryWriter aWriter) {} // 0x0000000186745070-0x0000000186745120
		// [XID] // 0x0000000189AA6320-0x0000000189AA6340
		public void SaveToStream(Stream aData) {} // 0x0000000186744F80-0x0000000186745070
		// [XID] // 0x00000001895E82F0-0x00000001895E8310
		public void SaveToCompressedStream(Stream aData) {} // 0x0000000186744D00-0x0000000186744DE0
		// [XID] // 0x0000000189AB5150-0x0000000189AB5170
		public void SaveToCompressedFile(string aFileName) {} // 0x0000000186744C20-0x0000000186744D00
		// [XID] // 0x0000000189ABCDC0-0x0000000189ABCDE0
		public string SaveToCompressedBase64() => default; // 0x0000000186744B50-0x0000000186744C20
		// [XID] // 0x0000000189AC4730-0x0000000189AC4750
		public void SaveToFile(string aFileName) {} // 0x0000000186744DE0-0x0000000186744F80
		// [XID] // 0x0000000189ACBDE0-0x0000000189ACBE00
		public string SaveToBase64() => default; // 0x0000000186744990-0x0000000186744B50
		// [XID] // 0x0000000189AC19B0-0x0000000189AC19D0
		public static JSONNode Deserialize(BinaryReader aReader) => default; // 0x0000000186742460-0x0000000186742870
		// [XID] // 0x0000000189A10940-0x0000000189A10960
		public static JSONNode LoadFromCompressedFile(string aFileName) => default; // 0x0000000186742EF0-0x0000000186742FC0
		// [XID] // 0x0000000189AE2AA0-0x0000000189AE2AC0
		public static JSONNode LoadFromCompressedStream(Stream aData) => default; // 0x0000000186742FC0-0x0000000186743090
		// [XID] // 0x0000000189AEA540-0x0000000189AEA560
		public static JSONNode LoadFromCompressedBase64(string aBase64) => default; // 0x0000000186742E20-0x0000000186742EF0
		// [XID] // 0x000000018964A490-0x000000018964A4B0
		public static JSONNode LoadFromStream(Stream aData) => default; // 0x00000001867431E0-0x0000000186743340
		// [XID] // 0x0000000189AF9960-0x0000000189AF9980
		public static JSONNode LoadFromFile(string aFileName) => default; // 0x0000000186743090-0x00000001867431E0
		// [XID] // 0x000000018974DC10-0x000000018974DC30
		public static JSONNode LoadFromBase64(string aBase64) => default; // 0x0000000186742D00-0x0000000186742E20
	}
}
