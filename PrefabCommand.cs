using System;
using Il2CppDummyDll;
using Loader;
using Loader.ID;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000074 RID: 116
[Token(Token = "0x2000057")]
public class PrefabCommand : ActionCommandBase
{
	// Token: 0x1700005C RID: 92
	// (get) Token: 0x06000228 RID: 552 RVA: 0x00002A48 File Offset: 0x00000C48
	[Token(Token = "0x17000059")]
	private Prefab PrefabID
	{
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x280A760", Offset = "0x280A861", VA = "0x280A760")]
		get
		{
			return Prefab.NONE;
		}
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x06000229 RID: 553 RVA: 0x00002A60 File Offset: 0x00000C60
	[Token(Token = "0x1700005A")]
	public bool IsAttach
	{
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x280A7E0", Offset = "0x280A8E1", VA = "0x280A7E0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600022A RID: 554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x280A800", Offset = "0x280A901", VA = "0x280A800")]
	public PrefabCommand(ActionCommandDataTable actionCommandData, ActionScriptControllerBase controller)
	{
	}

	// Token: 0x0600022B RID: 555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x280A8D0", Offset = "0x280A9D1", VA = "0x280A8D0", Slot = "8")]
	public override void DoAction()
	{
	}

	// Token: 0x0600022C RID: 556 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x280AB30", Offset = "0x280AC31", VA = "0x280AB30")]
	public void Create()
	{
	}

	// Token: 0x0600022D RID: 557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x280ACF0", Offset = "0x280ADF1", VA = "0x280ACF0", Slot = "11")]
	public override void ActionFinal()
	{
	}

	// Token: 0x0600022E RID: 558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x280ADD0", Offset = "0x280AED1", VA = "0x280ADD0", Slot = "12")]
	public override void Destroy()
	{
	}

	// Token: 0x0600022F RID: 559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x280AEA0", Offset = "0x280AFA1", VA = "0x280AEA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A030", Offset = "0x19A131")]
	private void <DoAction>b__11_0(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x0400018C RID: 396
	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0x80")]
	private Prefab _PrefabID;

	// Token: 0x0400018D RID: 397
	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0x84")]
	private bool IsParse;

	// Token: 0x0400018E RID: 398
	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0x88")]
	private GameObject PrefabParentObject;

	// Token: 0x0400018F RID: 399
	[Token(Token = "0x400012E")]
	[FieldOffset(Offset = "0x90")]
	private PrefabCommand.PrefabLoadState CurrentPrefabLoadState;

	// Token: 0x04000190 RID: 400
	[Token(Token = "0x400012F")]
	[FieldOffset(Offset = "0x98")]
	private UnityEvent OnComplete;

	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000FA7")]
	private enum PrefabLoadState
	{
		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4018CDA")]
		None,
		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4018CDB")]
		Entry,
		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4018CDC")]
		Complete,
		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4018CDD")]
		Destroy
	}
}
