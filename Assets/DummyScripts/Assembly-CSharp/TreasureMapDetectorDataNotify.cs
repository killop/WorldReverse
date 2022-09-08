﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TreasureMapDetectorDataNotify : MessageBase, IMessage<TreasureMapDetectorDataNotify> // TypeDefIndex: 25856
{
	// Fields
	private static readonly MessageParser<TreasureMapDetectorDataNotify> _parser; // 0x00
	public const int DataFieldNumber = 1; // Metadata: 0x00B09B93
	private TreasureMapDetectorData data_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TreasureMapDetectorDataNotify> Parser { get => default; } // 0x0000000182824960-0x00000001828249F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182824650-0x00000001828246E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001828242F0-0x0000000182824370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182823BC0-0x0000000182823C20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182824D10-0x0000000182824E00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182824B80-0x0000000182824BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001828246E0-0x00000001828247D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182824CC0-0x0000000182824D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182824410-0x0000000182824500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapDetectorData Data { get => default; set {} } // 0x0000000182824100-0x00000001828241A0 0x00000001828248C0-0x0000000182824960

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25857
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25858
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4271
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapDetectorDataNotify() {} // 0x0000000182825010-0x0000000182825070
	static TreasureMapDetectorDataNotify() {} // 0x0000000182824F50-0x0000000182825010

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapDetectorDataNotify Clone() => default; // 0x00000001828247D0-0x00000001828248C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapDetectorDataNotify ShallowCopy() => default; // 0x0000000182824370-0x0000000182824410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182823D80-0x0000000182823E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182824A80-0x0000000182824B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182824B00-0x0000000182824B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182823E00-0x0000000182823F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182823F20-0x0000000182823FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TreasureMapDetectorDataNotify other) => default; // 0x0000000182823FF0-0x0000000182824100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182824500-0x0000000182824650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182824E00-0x0000000182824F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182824BE0-0x0000000182824CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001828241A0-0x00000001828242F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TreasureMapDetectorDataNotify other) {} // 0x0000000182823C20-0x0000000182823D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182823AB0-0x0000000182823BC0
}

