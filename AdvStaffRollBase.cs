using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

// Token: 0x02000922 RID: 2338
[Token(Token = "0x200061F")]
public class AdvStaffRollBase : MonoBehaviour
{
	// Token: 0x06003D40 RID: 15680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600337E")]
	[Address(RVA = "0x2434290", Offset = "0x2434391", VA = "0x2434290")]
	private void Start()
	{
	}

	// Token: 0x06003D41 RID: 15681 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600337F")]
	[Address(RVA = "0x24342C0", Offset = "0x24343C1", VA = "0x24342C0")]
	private void Update()
	{
	}

	// Token: 0x06003D42 RID: 15682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003380")]
	[Address(RVA = "0x2434640", Offset = "0x2434741", VA = "0x2434640")]
	private void OnDestroy()
	{
	}

	// Token: 0x06003D43 RID: 15683 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003381")]
	[Address(RVA = "0x2434650", Offset = "0x2434751", VA = "0x2434650")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A6C40", Offset = "0x1A6D41")]
	private IEnumerator createPrefab(int prefabNo)
	{
		return null;
	}

	// Token: 0x06003D44 RID: 15684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003382")]
	[Address(RVA = "0x2434710", Offset = "0x2434811", VA = "0x2434710")]
	public void StartStaffRoll(int type, float time)
	{
	}

	// Token: 0x06003D45 RID: 15685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003383")]
	[Address(RVA = "0x2434830", Offset = "0x2434931", VA = "0x2434830")]
	public void EndStaffRoll()
	{
	}

	// Token: 0x06003D46 RID: 15686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003384")]
	[Address(RVA = "0x2434970", Offset = "0x2434A71", VA = "0x2434970")]
	public AdvStaffRollBase()
	{
	}

	// Token: 0x06003D47 RID: 15687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003385")]
	[Address(RVA = "0x2434980", Offset = "0x2434A81", VA = "0x2434980")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6CB0", Offset = "0x1A6DB1")]
	private void <createPrefab>b__7_0(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x04007F8F RID: 32655
	[Token(Token = "0x4007315")]
	[FieldOffset(Offset = "0x18")]
	private int step;

	// Token: 0x04007F90 RID: 32656
	[Token(Token = "0x4007316")]
	[FieldOffset(Offset = "0x20")]
	private AdvStaffRollControl SRCntl;

	// Token: 0x04007F91 RID: 32657
	[Token(Token = "0x4007317")]
	[FieldOffset(Offset = "0x28")]
	private int prefabNo;

	// Token: 0x04007F92 RID: 32658
	[Token(Token = "0x4007318")]
	[FieldOffset(Offset = "0x2C")]
	private float scroll_time;

	// Token: 0x02000923 RID: 2339
	[Token(Token = "0x2001285")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158E40", Offset = "0x158F41")]
	private sealed class <createPrefab>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003D48 RID: 15688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074A6")]
		[Address(RVA = "0x24346E0", Offset = "0x24347E1", VA = "0x24346E0")]
		[DebuggerHidden]
		public <createPrefab>d__7(int <>1__state)
		{
		}

		// Token: 0x06003D49 RID: 15689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074A7")]
		[Address(RVA = "0x2434AD0", Offset = "0x2434BD1", VA = "0x2434AD0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003D4A RID: 15690 RVA: 0x000153F0 File Offset: 0x000135F0
		[Token(Token = "0x60074A8")]
		[Address(RVA = "0x2434AE0", Offset = "0x2434BE1", VA = "0x2434AE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06003D4B RID: 15691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D7C")]
		private object Current
		{
			[Token(Token = "0x60074A9")]
			[Address(RVA = "0x2434C20", Offset = "0x2434D21", VA = "0x2434C20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003D4C RID: 15692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074AA")]
		[Address(RVA = "0x2434C30", Offset = "0x2434D31", VA = "0x2434C30", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06003D4D RID: 15693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D7D")]
		private object Current
		{
			[Token(Token = "0x60074AB")]
			[Address(RVA = "0x2434C90", Offset = "0x2434D91", VA = "0x2434C90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04007F93 RID: 32659
		[Token(Token = "0x40198DD")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007F94 RID: 32660
		[Token(Token = "0x40198DE")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007F95 RID: 32661
		[Token(Token = "0x40198DF")]
		[FieldOffset(Offset = "0x20")]
		public AdvStaffRollBase <>4__this;

		// Token: 0x04007F96 RID: 32662
		[Token(Token = "0x40198E0")]
		[FieldOffset(Offset = "0x28")]
		public int prefabNo;
	}
}
