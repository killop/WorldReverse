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
	public class CAgentStaticMethod<T, P1> : CAgentMethodBase<T> // TypeDefIndex: 27274
	{
		// Fields
		private FunctionPointer _fp;
		private IInstanceMember _p1;
	
		// Nested types
		public delegate T FunctionPointer(P1 p1); // TypeDefIndex: 27275; 0x00000000-0x00000000
	
		// Constructors
		public CAgentStaticMethod() {} // Dummy constructor
		public CAgentStaticMethod(FunctionPointer f) {}
		public CAgentStaticMethod(CAgentStaticMethod<T, P1> rhs) {}
	
		// Methods
		public override IMethod Clone() => default;
		public override void Load(string instance, string[] paramStrs) {}
		public override void Run(Agent self) {}
		public override IValue GetIValue(Agent self, IInstanceMember firstParam) => default;
		public override void SetTaskParams(Agent self, BehaviorTreeTask treeTask) {}
	}
}
