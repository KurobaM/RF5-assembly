using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using DataTable;
using Il2CppDummyDll;

// Token: 0x02000556 RID: 1366
[Token(Token = "0x20003E0")]
public class GimmickManager : SingletonMonoBehaviour<GimmickManager>
{
	// Token: 0x06002115 RID: 8469 RVA: 0x0000D860 File Offset: 0x0000BA60
	[Token(Token = "0x6001C1A")]
	[Address(RVA = "0x1FE7DE0", Offset = "0x1FE7EE1", VA = "0x1FE7DE0")]
	public static GimmickLayoutDataTable GetGimmickLayoutDataTable(GimmickLayoutID gimmickLayoutID)
	{
		return default(GimmickLayoutDataTable);
	}

	// Token: 0x17000562 RID: 1378
	// (get) Token: 0x06002116 RID: 8470 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002117 RID: 8471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700045C")]
	public HashSet<GimmickLayoutID> ExistGimmickLayoutIDs
	{
		[Token(Token = "0x6001C1B")]
		[Address(RVA = "0x1FE7E60", Offset = "0x1FE7F61", VA = "0x1FE7E60")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001C1C")]
		[Address(RVA = "0x1FE7E70", Offset = "0x1FE7F71", VA = "0x1FE7E70")]
		private set
		{
		}
	}

	// Token: 0x06002118 RID: 8472 RVA: 0x0000D878 File Offset: 0x0000BA78
	[Token(Token = "0x6001C1D")]
	[Address(RVA = "0x1FE7E80", Offset = "0x1FE7F81", VA = "0x1FE7E80")]
	public bool AddGimmickBase(GimmickBase gimmickBase, GimmickLayoutID gimmickLayoutID)
	{
		return default(bool);
	}

	// Token: 0x06002119 RID: 8473 RVA: 0x0000D890 File Offset: 0x0000BA90
	[Token(Token = "0x6001C1E")]
	[Address(RVA = "0x1FE8000", Offset = "0x1FE8101", VA = "0x1FE8000")]
	public bool RemoveGimmickBase(GimmickBase gimmickBase, GimmickLayoutID gimmickLayoutID)
	{
		return default(bool);
	}

	// Token: 0x0600211A RID: 8474 RVA: 0x0000D8A8 File Offset: 0x0000BAA8
	[Token(Token = "0x6001C1F")]
	[Address(RVA = "0x1FE8140", Offset = "0x1FE8241", VA = "0x1FE8140")]
	public bool GimmickBaseIDExists(GimmickLayoutID gimmickLayoutID)
	{
		return default(bool);
	}

	// Token: 0x0600211B RID: 8475 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C20")]
	[Address(RVA = "0x1FE81B0", Offset = "0x1FE82B1", VA = "0x1FE81B0")]
	public HashSet<GimmickBase> GetGimmickBases(GimmickLayoutID gimmickLayoutID)
	{
		return null;
	}

	// Token: 0x0600211C RID: 8476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C21")]
	[Address(RVA = "0x1FE8250", Offset = "0x1FE8351", VA = "0x1FE8250")]
	public void UpdateGimmickBase(GimmickLayoutID gimmickLayoutID, bool value)
	{
	}

	// Token: 0x0600211D RID: 8477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C22")]
	[Address(RVA = "0x1FE83E0", Offset = "0x1FE84E1", VA = "0x1FE83E0")]
	private void OnSceneChangeSetFlag()
	{
	}

	// Token: 0x0600211E RID: 8478 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C23")]
	[Address(RVA = "0x1FE86B0", Offset = "0x1FE87B1", VA = "0x1FE86B0")]
	public string SetTargetItemName(string targetItemName)
	{
		return null;
	}

	// Token: 0x0600211F RID: 8479 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C24")]
	[Address(RVA = "0x1FE86E0", Offset = "0x1FE87E1", VA = "0x1FE86E0")]
	public string GetTargetItemName()
	{
		return null;
	}

	// Token: 0x06002120 RID: 8480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C25")]
	[Address(RVA = "0x1FE86F0", Offset = "0x1FE87F1", VA = "0x1FE86F0")]
	private void Start()
	{
	}

	// Token: 0x06002121 RID: 8481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C26")]
	[Address(RVA = "0x1FE8780", Offset = "0x1FE8881", VA = "0x1FE8780")]
	public void InitializeLoad()
	{
	}

	// Token: 0x06002122 RID: 8482 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C27")]
	[Address(RVA = "0x1FE8810", Offset = "0x1FE8911", VA = "0x1FE8810")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A0660", Offset = "0x1A0761")]
	private IEnumerator LoadGimmickData()
	{
		return null;
	}

	// Token: 0x06002123 RID: 8483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C28")]
	[Address(RVA = "0x1FE88C0", Offset = "0x1FE89C1", VA = "0x1FE88C0")]
	public void OnAfterGameDataLoad()
	{
	}

	// Token: 0x06002124 RID: 8484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C29")]
	[Address(RVA = "0x1FE0030", Offset = "0x1FE0131", VA = "0x1FE0030")]
	public static void SetGimmickLayoutFlag(GimmickLayoutID id, bool value)
	{
	}

	// Token: 0x06002125 RID: 8485 RVA: 0x0000D8C0 File Offset: 0x0000BAC0
	[Token(Token = "0x6001C2A")]
	[Address(RVA = "0x1FE1670", Offset = "0x1FE1771", VA = "0x1FE1670")]
	public static bool GetGimmickLayoutFlag(GimmickLayoutID id)
	{
		return default(bool);
	}

	// Token: 0x06002126 RID: 8486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C2B")]
	[Address(RVA = "0x1FE8970", Offset = "0x1FE8A71", VA = "0x1FE8970")]
	public GimmickManager()
	{
	}

	// Token: 0x040067DD RID: 26589
	[Token(Token = "0x40061C5")]
	[FieldOffset(Offset = "0x18")]
	private GimmickLayoutDataTableArray _GimmickLayoutDataTableArray;

	// Token: 0x040067DE RID: 26590
	[Token(Token = "0x40061C6")]
	[FieldOffset(Offset = "0x20")]
	private HashSet<GimmickLayoutID> _ExistGimmickLayoutIDs;

	// Token: 0x040067DF RID: 26591
	[Token(Token = "0x40061C7")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<GimmickLayoutID, HashSet<GimmickBase>> GimmickBaseDictonary;

	// Token: 0x040067E0 RID: 26592
	[Token(Token = "0x40061C8")]
	[FieldOffset(Offset = "0x30")]
	private string TargetItemName;

	// Token: 0x02000557 RID: 1367
	[Token(Token = "0x20010FF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157DB0", Offset = "0x157EB1")]
	private sealed class <LoadGimmickData>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002127 RID: 8487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FE6")]
		[Address(RVA = "0x1FE8890", Offset = "0x1FE8991", VA = "0x1FE8890")]
		[DebuggerHidden]
		public <LoadGimmickData>d__18(int <>1__state)
		{
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FE7")]
		[Address(RVA = "0x1FE8A30", Offset = "0x1FE8B31", VA = "0x1FE8A30", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x0000D8D8 File Offset: 0x0000BAD8
		[Token(Token = "0x6006FE8")]
		[Address(RVA = "0x1FE8A40", Offset = "0x1FE8B41", VA = "0x1FE8A40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x0600212A RID: 8490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC3")]
		private object Current
		{
			[Token(Token = "0x6006FE9")]
			[Address(RVA = "0x1FE8BB0", Offset = "0x1FE8CB1", VA = "0x1FE8BB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FEA")]
		[Address(RVA = "0x1FE8BC0", Offset = "0x1FE8CC1", VA = "0x1FE8BC0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x0600212C RID: 8492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC4")]
		private object Current
		{
			[Token(Token = "0x6006FEB")]
			[Address(RVA = "0x1FE8C20", Offset = "0x1FE8D21", VA = "0x1FE8C20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040067E1 RID: 26593
		[Token(Token = "0x401928B")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040067E2 RID: 26594
		[Token(Token = "0x401928C")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040067E3 RID: 26595
		[Token(Token = "0x401928D")]
		[FieldOffset(Offset = "0x20")]
		public GimmickManager <>4__this;
	}
}
