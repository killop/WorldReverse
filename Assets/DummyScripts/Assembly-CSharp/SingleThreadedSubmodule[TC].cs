﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class SingleThreadedSubmodule<TC> : Submodule // TypeDefIndex: 11401
	where TC : CommandThreadFunctionalities
{
	// Fields
	private readonly TC _commandThread;

	// Properties
	public TC commandThread { get; }

	// Constructors
	protected SingleThreadedSubmodule() {} // Dummy constructor
	public SingleThreadedSubmodule(CommandThreadContext commandThreadContext) {}

	// Methods
	public override void CommandInit() {}
	public override void CommandTick(float deltaTime) {}
	public override void CommandEnterHomeWorld(bool firstTime) {}
	public override void CommandExitHomeWorld() {}
	public override void CommandExitGameWorld() {}
	public override void CommandCreateLevel() {}
	public override void CommandEnterLevel() {}
	public override void CommandExitLevel() {}
	public override void CommandDestroy() {}
	protected abstract TC CreateCommandThreadFunctionalities(CommandThreadContext commandThreadContext);
}

