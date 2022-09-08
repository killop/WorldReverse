﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PullRecentChatReq : MessageBase, IMessage<PullRecentChatReq> // TypeDefIndex: 22637
{
	// Fields
	private static readonly MessageParser<PullRecentChatReq> _parser; // 0x00
	public const int BeginSequenceFieldNumber = 1; // Metadata: 0x00B020BB
	private uint beginSequence_; // 0x18
	public const int PullNumFieldNumber = 2; // Metadata: 0x00B020BF
	private uint pullNum_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PullRecentChatReq> Parser { get => default; } // 0x0000000182D9F1E0-0x0000000182D9F270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182D9EED0-0x0000000182D9EF60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182D9EB20-0x0000000182D9EBA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182D9E5B0-0x0000000182D9E610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182D9F6B0-0x0000000182D9F7A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182D9F4E0-0x0000000182D9F540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182D9EF60-0x0000000182D9F050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182D9F660-0x0000000182D9F6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182D9ECE0-0x0000000182D9EDD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BeginSequence { get => default; set {} } // 0x0000000182D9F270-0x0000000182D9F310 0x0000000182D9EC40-0x0000000182D9ECE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PullNum { get => default; set {} } // 0x0000000182D9F140-0x0000000182D9F1E0 0x0000000182D9F3A0-0x0000000182D9F440

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22638
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22639
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4958
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PullRecentChatReq() {} // 0x0000000182D9FA60-0x0000000182D9FAC0
	static PullRecentChatReq() {} // 0x0000000182D9F9A0-0x0000000182D9FA60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PullRecentChatReq Clone() => default; // 0x0000000182D9F050-0x0000000182D9F140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PullRecentChatReq ShallowCopy() => default; // 0x0000000182D9EBA0-0x0000000182D9EC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182D9E740-0x0000000182D9E790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D9F440-0x0000000182D9F490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D9F490-0x0000000182D9F4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182D9E790-0x0000000182D9E800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182D9E800-0x0000000182D9E8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PullRecentChatReq other) => default; // 0x0000000182D9E8D0-0x0000000182D9E9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182D9EDD0-0x0000000182D9EED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182D9F7A0-0x0000000182D9F9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182D9F540-0x0000000182D9F660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182D9E9F0-0x0000000182D9EB20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PullRecentChatReq other) {} // 0x0000000182D9E610-0x0000000182D9E740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182D9E4B0-0x0000000182D9E5B0
}

