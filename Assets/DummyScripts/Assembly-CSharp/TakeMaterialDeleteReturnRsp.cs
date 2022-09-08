﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeMaterialDeleteReturnRsp : MessageBase, IMessage<TakeMaterialDeleteReturnRsp> // TypeDefIndex: 23739
{
	// Fields
	private static readonly MessageParser<TakeMaterialDeleteReturnRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B04B97
	private int retcode_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeMaterialDeleteReturnRsp> Parser { get => default; } // 0x0000000184B47D20-0x0000000184B47DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184B47AB0-0x0000000184B47B40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184B477C0-0x0000000184B47840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184B47190-0x0000000184B471F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184B48070-0x0000000184B48160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184B47EE0-0x0000000184B47F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184B47B40-0x0000000184B47C30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184B48020-0x0000000184B48070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184B478E0-0x0000000184B479D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184B47720-0x0000000184B477C0 0x0000000184B473C0-0x0000000184B47460

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23740
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23741
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 653
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeMaterialDeleteReturnRsp() {} // 0x0000000184B48390-0x0000000184B483F0
	static TakeMaterialDeleteReturnRsp() {} // 0x0000000184B482D0-0x0000000184B48390

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeMaterialDeleteReturnRsp Clone() => default; // 0x0000000184B47C30-0x0000000184B47D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeMaterialDeleteReturnRsp ShallowCopy() => default; // 0x0000000184B47840-0x0000000184B478E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184B47300-0x0000000184B47350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B47E40-0x0000000184B47E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B47E90-0x0000000184B47EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184B47350-0x0000000184B473C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184B47560-0x0000000184B47630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeMaterialDeleteReturnRsp other) => default; // 0x0000000184B47460-0x0000000184B47560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184B479D0-0x0000000184B47AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184B48160-0x0000000184B482D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184B47F40-0x0000000184B48020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184B47630-0x0000000184B47720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeMaterialDeleteReturnRsp other) {} // 0x0000000184B471F0-0x0000000184B47300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184B470B0-0x0000000184B47190
}

