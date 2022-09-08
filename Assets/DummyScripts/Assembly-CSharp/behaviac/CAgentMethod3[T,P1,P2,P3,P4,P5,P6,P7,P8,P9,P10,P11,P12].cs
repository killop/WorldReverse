﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace behaviac
{
	public class CAgentMethod<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11, P12> : CAgentMethodBase<T> // TypeDefIndex: 27266
	{
		// Fields
		private FunctionPointer _fp;
		private IInstanceMember _p1;
		private IInstanceMember _p2;
		private IInstanceMember _p3;
		private IInstanceMember _p4;
		private IInstanceMember _p5;
		private IInstanceMember _p6;
		private IInstanceMember _p7;
		private IInstanceMember _p8;
		private IInstanceMember _p9;
		private IInstanceMember _p10;
		private IInstanceMember _p11;
		private IInstanceMember _p12;
	
		// Nested types
		public delegate T FunctionPointer(Agent a, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9, P10 p10, P11 p11, P12 p12); // TypeDefIndex: 27267; 0x00000000-0x00000000
	
		// Constructors
		public CAgentMethod() {} // Dummy constructor
		public CAgentMethod(FunctionPointer f) {}
		public CAgentMethod(CAgentMethod<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11, P12> rhs) {}
	
		// Methods
		public override IMethod Clone() => default;
		public override void Load(string instance, string[] paramStrs) {}
		public override void Run(Agent self) {}
		public override void SetTaskParams(Agent self, BehaviorTreeTask treeTask) {}
	}
}
