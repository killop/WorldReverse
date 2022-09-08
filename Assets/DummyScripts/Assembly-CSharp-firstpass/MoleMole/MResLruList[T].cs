﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class MResLruList<T> : HashList<T> // TypeDefIndex: 10590
	{
		// Fields
		protected const float TARGET_MAX_PROCESS_TIME = 0.033f; // Metadata: 0x00AE7B96
		private Dictionary<T, long> _timeDict;
		private long _retireMillSeconds;
		private int _retireSize;
		private int _capcity;
		private bool _autoRetire;
		private Action<T> _onRetire;
		private int _shareWatch;
	
		// Properties
		public int Capacity { get => default; }
		public int RetireSize { get => default; }
		public float RetireSeconds { get => default; }
		public bool idle { get => default; }
	
		// Constructors
		public MResLruList() {}
	
		// Methods
		public void Init(int capcity, int retireSize, float retireSeconds, Action<T> onRetire, bool autoRetire = false /* Metadata: 0x00AE7B91 */, float maxTickTimeLimit = 1f /* Metadata: 0x00AE7B92 */) {}
		public void Uninit() {}
		public void Resize(int capcity, int retireSize, float retireSeconds) {}
		public override ListNode<T> Add(T data) => default;
		public override ListNode<T> AddTail(T data) => default;
		public override void Clear() {}
		public override void Delete(T data) {}
		public void RetireAll() {}
		protected override void add(ListNode<T> newNode, ListNode<T> prev, ListNode<T> next) {}
		private void RetireAllWithTime() {}
		public void TryToRetire() {}
	}
}
