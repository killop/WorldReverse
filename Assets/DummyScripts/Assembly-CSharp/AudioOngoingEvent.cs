﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct AudioOngoingEvent // TypeDefIndex: 11283
{
	// Properties
	public int ordinal { /* [XID] */ /* 0x00000001897022C0-0x0000000189702300 */ get; /* [XID] */ /* 0x000000018970C860-0x000000018970C8A0 */ set; } // 0x0000000184C344A0-0x0000000184C34500 0x0000000184C349E0-0x0000000184C34C60
	public uint eventId { /* [XID] */ /* 0x0000000189716DF0-0x0000000189716E30 */ get; /* [XID] */ /* 0x0000000189721660-0x00000001897216A0 */ set; } // 0x0000000184C33AC0-0x0000000184C33B80 0x0000000184C345F0-0x0000000184C346C0
	public uint playingId { /* [XID] */ /* 0x000000018972BC60-0x000000018972BCA0 */ get; /* [XID] */ /* 0x0000000189736550-0x0000000189736590 */ set; } // 0x0000000184C33C40-0x0000000184C33EB0 0x0000000184C34920-0x0000000184C349E0
	public object cookie { /* [XID] */ /* 0x0000000189BC0640-0x0000000189BC0680 */ get; /* [XID] */ /* 0x000000018974B8D0-0x000000018974B910 */ set; } // 0x0000000184C343E0-0x0000000184C344A0 0x0000000184C347A0-0x0000000184C34860
	public AkCallbackType callbackType { /* [XID] */ /* 0x0000000189755E60-0x0000000189755EA0 */ get; /* [XID] */ /* 0x0000000189760430-0x0000000189760470 */ set; } // 0x0000000184C34D10-0x0000000184C34F20 0x0000000184C33A60-0x0000000184C33AC0
	public EventCallback callback { /* [XID] */ /* 0x000000018976AB30-0x000000018976AB70 */ get; /* [XID] */ /* 0x0000000189774DE0-0x0000000189774E20 */ set; } // 0x0000000184C34860-0x0000000184C34920 0x0000000184C33F40-0x0000000184C34000
	public bool fromCommand { /* [XID] */ /* 0x000000018977F580-0x000000018977F5C0 */ get; /* [XID] */ /* 0x0000000189789D50-0x0000000189789D90 */ set; } // 0x0000000184C34000-0x0000000184C34370 0x0000000184C33B80-0x0000000184C33C40
	public SyncId syncId { /* [XID] */ /* 0x0000000189794200-0x0000000189794240 */ get; /* [XID] */ /* 0x000000018979F590-0x000000018979F5D0 */ set; } // 0x0000000184C34500-0x0000000184C345F0 0x0000000184C346C0-0x0000000184C347A0

	// Methods
	// [XID] // 0x00000001897A9A00-0x00000001897A9A20
	public EventInstance GetEventInstance() => default; // 0x0000000184C33EB0-0x0000000184C33F40
	// [XID] // 0x0000000189621290-0x00000001896212B0
	public void InvokeCallback(AkCallbackType type, MmoronCallbackInfo info) {} // 0x0000000184C34C60-0x0000000184C34D10
	// [XID] // 0x0000000189630410-0x0000000189630430
	public void Clear() {} // 0x0000000184C34370-0x0000000184C343E0
}

